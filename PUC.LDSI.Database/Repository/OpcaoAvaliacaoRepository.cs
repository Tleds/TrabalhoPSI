using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
   public class OpcaoAvaliacaoRepository : Repository <OpcaoAvaliacao> , IOpcaoAvaliacaoRepository
    {
        private readonly AppDbContext _context;

        public OpcaoAvaliacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<OpcaoAvaliacao> ObterOpcaoAvaliacao(int id)
        {

            var opcaoAvaliacao = await _context.OpcoesAvaliacao
           .Include(x => x.Descricao)
           .Where(x => x.Id == id).FirstOrDefaultAsync();
            return opcaoAvaliacao;
        }

    }
}
