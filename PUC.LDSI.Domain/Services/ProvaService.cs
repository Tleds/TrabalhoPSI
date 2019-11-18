using PUC.LDSI.Domain.QueryResult;
using PUC.LDSI.Domain.Repository;
using PUC.LDSI.Domain.Services.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using PUC.LDSI.Domain.Exception;
using PUC.LDSI.Domain.InputData;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.Domain.Services
{
    public class ProvaService : IProvaService
    {
        private readonly IPublicacaoRepository _publicacaoRepository;
        private readonly IProvaRepository _provaRepository;
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IQuestaoProvaRepository _questaoRepository;
        private readonly IOpcaoAvaliacaoRepository _opcaoProvaRepository;

        public ProvaService(IPublicacaoRepository publicacaoRepository,
                            IProvaRepository provaRepository,
                            IAvaliacaoRepository avaliacaoRepository,
                            IAlunoRepository alunoRepository,
                            IQuestaoProvaRepository questaoRepository,
                            IOpcaoAvaliacaoRepository opcaoProvaRepository)
        {
            _provaRepository = provaRepository;
            _alunoRepository = alunoRepository;
            _avaliacaoRepository = avaliacaoRepository;
            _publicacaoRepository = publicacaoRepository;
            _questaoRepository = questaoRepository;
            _opcaoProvaRepository = opcaoProvaRepository;
        }

        public async Task<List<AvaliacaoPublicadaQueryResult>> ListarAvaliacoesPublicadasAsync(string login)
        {
            var aluno = _alunoRepository.ObterPorLogin(login);

            if (aluno == null) throw new DomainException("O aluno não foi localizado!");

            var publicacoes = await _publicacaoRepository.ListarPublicacoesDoAlunoAsync(login);

            var retorno = new List<AvaliacaoPublicadaQueryResult>();

            publicacoes.ForEach(x =>
            {
                var prova = x.Avaliacao.Provas.FirstOrDefault(a => a.AlunoId == aluno.Id);

                retorno.Add(new AvaliacaoPublicadaQueryResult()
                {
                    AlunoId = aluno.Id,
                    AvaliacaoId = x.AvaliacaoId,
                    DataFim = x.DataFim,
                    DataInicio = x.DataInicio,
                    DataPublicacao = x.DataPublicacao,
                    Descricao = x.Avaliacao.Descricao,
                    Disciplina = x.Avaliacao.Disciplina,
                    Materia = x.Avaliacao.Materia,
                    ValorProva = x.ValorProva,
                    PublicacaoId = x.Id,
                    ProvaId = prova == null ? (int?)null : prova.Id,
                    DataRealizacao = prova == null ? (DateTime?)null : prova.DataProva,
                    NotaObtida = prova == null ? (decimal?)null : GetNota(prova) //TODO - Calcular a nota obtida e retornar nesse atributo.
                });
            });

            return retorno;
        }

        public async Task<ProvaQueryResult> ObterProvaAsync(int publicacaoId, string login)
        {
            var aluno = _alunoRepository.ObterPorLogin(login);

            if (aluno == null) throw new DomainException("O aluno não foi localizado!");

            var publicacao = await _publicacaoRepository.ObterAsync(publicacaoId);

            if (publicacao == null) throw new DomainException("A publicacao não foi localizada!");

            var avaliacaoCompleta = await _avaliacaoRepository.ObterComQuestoresAsync(publicacao.AvaliacaoId);

            var provaCompleta = await _provaRepository.ObterProvaDoAlunoAsync(publicacao.AvaliacaoId, aluno.Id);

            var retorno = new ProvaQueryResult()
            {
                AvaliacaoId = publicacao.AvaliacaoId,
                PublicacaoId = publicacao.Id,
                Questoes = avaliacaoCompleta.Questoes.Select(x => new QuestaoProvaQueryResult()
                {
                    QuestaoId = x.Id,
                    Enunciado = x.Enunciado,
                    Tipo = x.Tipo,
                    Opcoes = x.Opcoes.Select(y => new OpcaoProvaQueryResult()
                    {
                        OpcaoAvaliacaoId = y.Id,
                        QuestaoId = y.QuestaoId,
                        Descricao = y.Descricao
                    }).ToList()
                }).ToList()
            };

            retorno.Questoes.SelectMany(x => x.Opcoes).ToList().ForEach(x =>
            {
                x.Resposta = provaCompleta?.QuestoesProva?
                    .SelectMany(y => y.OpcoesProva)
                    .FirstOrDefault(y => y.OpcaoAvaliacaoId == x.OpcaoAvaliacaoId)?.Resposta ?? false;
            });

            return retorno;
        }

        public double QuestoesCorretas(List<OpcaoAvaliacao> inputProva)
        {
            return 5;
        }
        public decimal GetNota(Prova x)
        {
            decimal nota = 0;
            foreach (var item in x.QuestoesProva)
            {
                nota += item.Nota;
            }
            
            return nota;
        }
        public void SalvarProva(ProvaInputData provaInputData, string login)
        {
            //Registro aluno - 1
            var aluno = _alunoRepository.ObterPorLogin(login);
            var avaliacao = _avaliacaoRepository.ObterAvalicao(provaInputData.AvaliacaoId);
            //var questoeProva = _questaoRepository.Consultar(x => x.ProvaId == provaInputData.AvaliacaoId).ToList();
            //Objeto prova - 2
            Prova prova = new Prova
            {
                DataProva = DateTime.Now,
                AvaliacaoId = provaInputData.AvaliacaoId,
                AlunoId = aluno.Id,
                
               Aluno = aluno,
                Avaliacao = avaliacao
            };
            foreach (var x in provaInputData.Questoes)
            {
                var questaoProva = new QuestaoProva() { QuestaoId = x.QuestaoId };
                prova.QuestoesProva.Add(questaoProva);
                foreach(var y in x.Opcoes)
                {
                    var opcaoProva = new OpcaoProva() { OpcaoAvaliacaoId = y.OpcaoAvaliacaoId, Resposta = y.Resposta };
                    questaoProva.OpcoesProva.Add(opcaoProva);
                }
            }
            //Calcula nota
            var avaliacaoTeste = _avaliacaoRepository.ObterComQuestoresAsync(provaInputData.AvaliacaoId);
            var acertos = new List<OpcaoProva>();
            foreach(var x in prova.QuestoesProva)
            {
                var questaoAvaliacao = avaliacaoTeste.Result.Questoes.Find(y => y.Id == x.QuestaoId);
                if(questaoAvaliacao.Tipo == 1)
                {
                    var idVerdadeira = questaoAvaliacao.Opcoes.Find(z => z.Verdadeira).Id;
                    x.Nota = x.OpcoesProva.Find(y => y.OpcaoAvaliacaoId == idVerdadeira && y.Resposta) == null ? 0 : 1;
                }
                if (questaoAvaliacao.Tipo == 2)
                {
                    acertos.AddRange(questaoAvaliacao.Opcoes.Select(z => new OpcaoProva { Resposta = z.Verdadeira, OpcaoAvaliacaoId = z.Id}));
                    x.Nota = (1 / (decimal)questaoAvaliacao.Opcoes.Count * (decimal)acertos.Count);
                    
                }
            }
            _provaRepository.Adicionar(prova);
        }
    }
}
