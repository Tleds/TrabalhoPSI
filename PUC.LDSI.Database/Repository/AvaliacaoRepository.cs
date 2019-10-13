using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
    {
        private readonly AppDbContext _context;
        public AvaliacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Avaliacao> ObterComIdProfessor(int id)
        {
            var avaliacao = await _context.Avaliacoes
           .Include(x => x.Professor)
           .Where(x => x.ProfessorId == id).FirstOrDefaultAsync();
            return avaliacao;
        }
    }

}
