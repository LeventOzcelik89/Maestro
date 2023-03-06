using Maestro.Framework.Interfaces;
using System.Linq.Expressions;

namespace Maestro.Framework.Repositories
{
    public interface IReadOnlyBasicRepository<TEntity> : IRepository where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default(CancellationToken));

        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false, CancellationToken cancellationToken = default(CancellationToken));

        Task<long> GetCountAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<List<TEntity>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false, CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IReadOnlyBasicRepository<TEntity, TKey> : IReadOnlyBasicRepository<TEntity>, IRepository where TEntity : class, IEntity<TKey>
    {
        //
        // Summary:
        //     Gets an entity with given primary key. Throws Volo.Abp.Domain.Entities.EntityNotFoundException
        //     if can not find an entity with given id.
        //
        // Parameters:
        //   id:
        //     Primary key of the entity to get
        //
        //   includeDetails:
        //     Set true to include all children of this entity
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        // Returns:
        //     Entity
        Task<TEntity> GetAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Gets an entity with given primary key or null if not found.
        //
        // Parameters:
        //   id:
        //     Primary key of the entity to get
        //
        //   includeDetails:
        //     Set true to include all children of this entity
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        // Returns:
        //     Entity or null
        Task<TEntity> FindAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default(CancellationToken));
    }

}
