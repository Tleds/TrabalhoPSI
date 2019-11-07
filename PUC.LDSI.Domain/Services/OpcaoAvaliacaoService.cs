using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Services.Interfaces;


namespace PUC.LDSI.Domain.Services
{
   public class OpcaoAvaliacaoService : IOpcaoAvaliacaoService
    {
        private readonly IOpcaoAvaliacaoRepository _OpcaoAvaliacaoRepository;

        public OpcaoAvaliacaoService(IOpcaoAvaliacaoRepository OpcaoAvaliacaoRepository)
        {
            _OpcaoAvaliacaoRepository = OpcaoAvaliacaoRepository;
        }
        public async Task<int> AdicionarOpcaoAvaliacaoAsync(string descricao, bool verdadeira, Questao questao)
        {
            var OpcaoAvaliacao = new OpcaoAvaliacao() {Descricao = descricao, Verdadeira = verdadeira, Questao = questao };
           _OpcaoAvaliacaoRepository.Adicionar(OpcaoAvaliacao);
            await _OpcaoAvaliacaoRepository.SaveChangesAsync();
            return questao.Id;
        }

        public async Task<int> AlterarOpcaoAvaliacaoAsync(int id, string descricao, bool verdadeira, Questao questao)
        {
            var opcaoAvaliacao = await _OpcaoAvaliacaoRepository.ObterAsync(id);
            opcaoAvaliacao.Descricao = descricao;
            _OpcaoAvaliacaoRepository.Modificar(opcaoAvaliacao);
            return await _OpcaoAvaliacaoRepository.SaveChangesAsync();
        }
        public async Task ExcluirAsync(int id)
        {
            var opcaoAvaliacao = await _OpcaoAvaliacaoRepository.ObterOpcaoAvaliacao(id);
            _OpcaoAvaliacaoRepository.Remover(id);
            await _OpcaoAvaliacaoRepository.SaveChangesAsync();

        }
    }
}
