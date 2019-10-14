using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.Domain.Services.Interfaces
{
    public interface IProvaService
    {
        Task<int> AdicionarProvaAsync(Avaliacao avaliacao, Aluno aluno, DateTime dataProva, decimal notaObtida);
        Task<int> AlterarProvaAsync(int id, Avaliacao avaliacao, Aluno aluno, DateTime dataProva, decimal notaObtida);
        Task ExcluirAsync(int id);
    }
}
