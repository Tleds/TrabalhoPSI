using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services.Interfaces
{
    public interface IAvaliacaoService
    {
            Task<int> AdicionarAvaliacaoAsync(Avaliacao avaliacao);
            Task<int> AlterarAvaliacaoAsync(Avaliacao avaliacao);
            Task ExcluirAsync(int id);
    }

}
