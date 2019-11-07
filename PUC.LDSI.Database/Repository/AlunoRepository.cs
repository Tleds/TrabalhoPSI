using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        private readonly AppDbContext _context;
        public AlunoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<int> IncluirNovoAlunoAsync(Aluno aluno)
        {
            _context.Add(aluno);
            var retorno = await _context.SaveChangesAsync();
            return retorno;
        }
        public Aluno ObterPorMatricula(string matricula)
        {
            var retorno = _context.Alunos
            
           .Where(x => x.Matricula == matricula).FirstOrDefault();
            return retorno;
        }
    }
}
