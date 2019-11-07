using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class QuestaoRepository : Repository <Questao>, IQuestaoRepository
    {
        private readonly AppDbContext _context;

        public QuestaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        
         public async Task <Questao> ObterQuestoesAsync (int id)
         {
             var questao = await _context.Questoes.Include(x => x.Id)
                 .Where(x=>x.Id == id).FirstOrDefaultAsync();

             return questao;
         }
          
    }

}
