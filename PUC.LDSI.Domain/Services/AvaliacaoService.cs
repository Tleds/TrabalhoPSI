using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Services.Interfaces;
using PUC.LDSI.Domain.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }
        public async Task<int> AdicionarAvaliacaoAsync(Avaliacao ava)
        {
            var avaliacao = new Avaliacao() { ProfessorId = ava.ProfessorId, Descricao = ava.Descricao, Disciplina = ava.Disciplina, Materia = ava.Materia };
            _avaliacaoRepository.Adicionar(avaliacao);
            await _avaliacaoRepository.SaveChangesAsync();
            return avaliacao.Id;
        }
        public async Task<int> AlterarAvaliacaoAsync(Avaliacao ava)
        {
            var avaliacao = await _avaliacaoRepository.ObterAsync(ava.Id);
            avaliacao.Materia = ava.Materia;
            avaliacao.Professor = ava.Professor;
            avaliacao.Provas = ava.Provas;
            avaliacao.Publicacoes = ava.Publicacoes;
            avaliacao.Questoes = ava.Questoes;

            _avaliacaoRepository.Modificar(avaliacao);
            return await _avaliacaoRepository.SaveChangesAsync();
        }
        public async Task ExcluirAsync(int id)
        {
            var avaliacao = await _avaliacaoRepository.ObterAsync(id);
            if (avaliacao.Provas?.Count > 0)
                throw new Exception("Não é possível excluir uma avaliação que já possui provas!");
            _avaliacaoRepository.Remover(id);
            await _avaliacaoRepository.SaveChangesAsync();
        }
    }

}
