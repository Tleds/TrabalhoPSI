using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Services.Interfaces;

namespace PUC.LDSI.Domain.Services
{
    public class QuestaoService : IQuestaoService
    {
        private readonly IQuestaoRepository _questaoRepository;

        public QuestaoService(IQuestaoRepository questaoRepository)
        {
            _questaoRepository = questaoRepository;
        }
        public async Task<int> AdicionarQuestaoAsync(string Enunciado, int tipo, Avaliacao avaliacao)
        {
            var questao = new Questao() { Enunciado = Enunciado, Tipo = tipo, Avaliacao = avaliacao };
            _questaoRepository.Adicionar(questao);
            await _questaoRepository.SaveChangesAsync();
            return questao.Id;
        }

        public async Task<int> AlterarQuestaoAsync(int id, string enunciado, int tipo, Avaliacao avaliacao)
        {
            var questao = await _questaoRepository.ObterAsync(id);
            questao.Enunciado = enunciado;
            _questaoRepository.Modificar(questao);
            return await _questaoRepository.SaveChangesAsync();
        }
        
        public async Task ExcluirAsync(int id)
        {
            var questao = await _questaoRepository.ObterQuestoesAsync(id);
            _questaoRepository.Remover(id);
            await _questaoRepository.SaveChangesAsync();

        }
         
    }
}
