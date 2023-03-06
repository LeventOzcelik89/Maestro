using Maestro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository
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

        Task<TEntity> GetAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default(CancellationToken));

        Task<TEntity> FindAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default(CancellationToken));
    }

}
