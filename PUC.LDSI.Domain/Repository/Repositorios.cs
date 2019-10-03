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

}
