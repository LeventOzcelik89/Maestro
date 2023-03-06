using Maestro.Application.Repositories;
using Maestro.Domain.Interfaces;
using Maestro.Domain.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Domain.Repositories
{
    public interface IReadOnlyRepository<TEntity> : IQueryable<TEntity>, IEnumerable<TEntity>, IEnumerable, IQueryable, IReadOnlyBasicRepository<TEntity>, IRepository where TEntity : class, IEntity
    {
        IAsyncQueryableExecuter AsyncExecuter { get; }

        [Obsolete("Use WithDetailsAsync method.")]
        IQueryable<TEntity> WithDetails();

        [Obsolete("Use WithDetailsAsync method.")]
        IQueryable<TEntity> WithDetails(params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<IQueryable<TEntity>> WithDetailsAsync();

        Task<IQueryable<TEntity>> WithDetailsAsync(params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<IQueryable<TEntity>> GetQueryableAsync();
    }
}
