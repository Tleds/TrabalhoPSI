using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;


namespace PUC.LDSI.Domain.Services.Interfaces
{
    public interface IOpcaoAvaliacaoService
    {
        Task<int> AdicionarOpcaoAvaliacaoAsync(string descricao, bool verdadeira, Questao questao);
        Task<int> AlterarOpcaoAvaliacaoAsync(int id, string descricao, bool verdadeira, Questao questao);
        Task ExcluirAsync(int id);
    }
}
