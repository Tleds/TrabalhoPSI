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
    public class ProvaRepository : Repository<Prova>, IProvaRepository
    {
        private readonly AppDbContext _context;
        public ProvaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Prova> ObterProva(int id)
        {
            var prova = await _context.Provas
           .Include(x => x.AvaliacaoId)
           .Where(x => x.Id == id).FirstOrDefaultAsync();
            return prova;
        }
    }
}

