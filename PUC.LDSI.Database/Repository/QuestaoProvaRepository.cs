using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class QuestaoProvaRepository : Repository<QuestaoProva>, IQuestaoProvaRepository
    {
        public readonly AppDbContext _context;
        public QuestaoProvaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<QuestaoProva> ObterComProva(int id)
        {
            var QuestaoProva = await _context.QuestoesProva
                 .Include(x => x.Prova)
                 .Where(x => x.Id == id).FirstOrDefaultAsync();
            return QuestaoProva;
        }
    }
}
