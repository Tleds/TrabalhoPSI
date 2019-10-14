using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using PUC.LDSI.Domain.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services
{
    public class QuestaoProvaService: IQuestaoProvaService
    {
        private readonly IQuestaoProvaRepository _QuestaoProvaRepository;
        public QuestaoProvaService(IQuestaoProvaRepository questaoProvaRepository)
        {
            _QuestaoProvaRepository = questaoProvaRepository;
        }

        public async Task<int> AdicionarQuestaoProvaAsync(Questao questao, Prova prova, Decimal nota)
        {
            var questaoProva = new QuestaoProva() { Questao = questao , Prova = prova,Nota = nota};
            _QuestaoProvaRepository.Adicionar(questaoProva);
            await _QuestaoProvaRepository.SaveChangesAsync();
            return questaoProva.Id;
        }

        public async Task ExcluirAsync(int id)
        {
            var questaoProva = await _QuestaoProvaRepository.ObterComProva(id);
            _QuestaoProvaRepository.Remover(id);
            await _QuestaoProvaRepository.SaveChangesAsync();
        }
    }
}
