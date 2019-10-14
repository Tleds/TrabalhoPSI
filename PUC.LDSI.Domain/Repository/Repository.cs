using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using PUC.LDSI.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        IQueryable<TEntity> ObterTodos();
        Task<List<TEntity>> ListarTodosAsync();
        IQueryable<TEntity> Consultar(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> ObterAsync(int id);
        void Adicionar(TEntity entity);
        void Modificar(TEntity entity);
        void Remover(int id);
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
    public interface IProfessorRepository
    {
        Task<int> IncluirNovoProfessorAsync(Professor professor);
        Professor ObterPorLogin(string login);
    }
    public interface ITurmaRepository : IRepository<Turma>
    {
        Task<Turma> ObterComAlunosAsync(int id);
    }
    public interface IAvaliacaoRepository : IRepository<Avaliacao>
    {
        Task<Avaliacao> ObterComIdProfessor(int id);
    }
public interface IAlunoRepository 
    {
        Task<int> IncluirNovoAlunoAsync(Aluno aluno);
        Aluno ObterPorMatricula(string matricula);        
    }
    public interface IQuestaoProvaRepository : IRepository<QuestaoProva>
    {
        Task<QuestaoProva> ObterComProva(int id);
    }
    public interface IPublicacaoRepository : IRepository<Publicacao>
    {
     
    }

}
