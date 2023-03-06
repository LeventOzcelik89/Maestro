using Maestro.Domain.Interfaces;
using System.Linq.Expressions;

namespace Maestro.Domain.Repositories
{
    public interface IReadOnlyBasicRepository<TEntity> : IRepository where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default(CancellationToken));

        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false, CancellationToken cancellationToken = default(CancellationToken));

        Task<long> GetCountAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<List<TEntity>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false, CancellationToken cancellationToken = default(CancellationToken));
    }
}
