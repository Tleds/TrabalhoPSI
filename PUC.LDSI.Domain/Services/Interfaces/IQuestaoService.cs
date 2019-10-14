using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;
namespace PUC.LDSI.Domain.Services.Interfaces
{
    public interface IQuestaoService
    {
        Task<int> AdicionarQuestaoAsync(string Enunciado, int tipo, Avaliacao avaliacao);
        Task<int> AlterarQuestaoAsync(int id, string enunciado, int tipo, Avaliacao avaliacao);
        Task ExcluirAsync(int id);

    }
}
