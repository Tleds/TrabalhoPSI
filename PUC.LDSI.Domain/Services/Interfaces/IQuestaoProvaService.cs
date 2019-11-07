using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services.Interfaces
{
     public interface IQuestaoProvaService
    {
        Task<int> AdicionarQuestaoProvaAsync(Questao questao,Prova prova,Decimal Nota);
        Task ExcluirAsync(int id);

    }
}
