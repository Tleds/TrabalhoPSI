using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services.Interfaces
{
    public interface IPublicacaoService
    {
        Task<int> AdicionarPublicacaoAsync(Avaliacao avaliacao, DateTime dataPublicacao, Turma Turma, DateTime dataInicio, DateTime dataFim, int valorProva);
        Task<int> AlterarPublicacaoAsync(int id,Avaliacao avaliacao,DateTime dataPublicacao,Turma Turma, DateTime dataInicio,DateTime dataFim,int valorProva);
        Task ExcluirAsync(int id);
    }
}
