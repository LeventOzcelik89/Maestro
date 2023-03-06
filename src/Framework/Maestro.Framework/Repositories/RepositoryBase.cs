using Maestro.Application.Uow;
using Maestro.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.Repositories
{
    public abstract class RepositoryBase<TEntity> : BasicRepositoryBase<TEntity>, IRepository<TEntity>, IUnitOfWorkManagerAccessor
        where TEntity : class, IEntity
    {
        [Obsolete("This method will be removed in future versions.")]
        public virtual Type ElementType => GetQueryable().ElementType;

        [Obsolete("This method will be removed in future versions.")]
        public virtual Expression Expression => GetQueryable().Expression;

        [Obsolete("This method will be removed in future versions.")]
        public virtual IQueryProvider Provider => GetQueryable().Provider;

        [Obsolete("Use WithDetailsAsync method.")]
        public virtual IQueryable<TEntity> WithDetails()
        {
            return GetQueryable();
        }

        [Obsolete("Use WithDetailsAsync method.")]
        public virtual IQueryable<TEntity> WithDetails(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return GetQueryable();
        }

        public virtual Task<IQueryable<TEntity>> WithDetailsAsync()
        {
            return GetQueryableAsync();
        }

        public virtual Task<IQueryable<TEntity>> WithDetailsAsync(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return GetQueryableAsync();
        }

        [Obsolete("This method will be removed in future versions.")]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        [Obsolete("This method will be removed in future versions.")]
        public IEnumerator<TEntity> GetEnumerator()
        {
            return GetQueryable().GetEnumerator();
        }

        [Obsolete("Use GetQueryableAsync method.")]
        protected abstract IQueryable<TEntity> GetQueryable();

        public abstract Task<IQueryable<TEntity>> GetQueryableAsync();

        public abstract Task<TEntity> FindAsync(
            Expression<Func<TEntity, bool>> predicate,
            bool includeDetails = true,
            CancellationToken cancellationToken = default);

        public async Task<TEntity> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            bool includeDetails = true,
            CancellationToken cancellationToken = default)
        {
            var entity = await FindAsync(predicate, includeDetails, cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity));
            }

            return entity;
        }

        public abstract Task DeleteAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false, CancellationToken cancellationToken = default);

        protected virtual TQueryable ApplyDataFilters<TQueryable>(TQueryable query)
            where TQueryable : IQueryable<TEntity>
        {
            if (typeof(ISoftDelete).IsAssignableFrom(typeof(TEntity)))
            {
                query = (TQueryable)query.WhereIf(DataFilter.IsEnabled<ISoftDelete>(), e => ((ISoftDelete)e).IsDeleted == false);
            }

            if (typeof(IMultiTenant).IsAssignableFrom(typeof(TEntity)))
            {
                var tenantId = CurrentTenant.Id;
                query = (TQueryable)query.WhereIf(DataFilter.IsEnabled<IMultiTenant>(), e => ((IMultiTenant)e).TenantId == tenantId);
            }

            return query;
        }
    }
}
