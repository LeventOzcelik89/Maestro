using Maestro.Framework.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.Repositories
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>, IQueryable<TEntity>, IEnumerable<TEntity>, IEnumerable, IQueryable, IReadOnlyBasicRepository<TEntity>, IRepository, IBasicRepository<TEntity> where TEntity : class, IEntity
    {
        //
        // Summary:
        //     Get a single entity by the given predicate.
        //     It returns null if there is no entity with the given predicate. It throws System.InvalidOperationException
        //     if there are multiple entities with the given predicate.
        //
        // Parameters:
        //   predicate:
        //     A condition to find the entity
        //
        //   includeDetails:
        //     Set true to include all children of this entity
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Get a single entity by the given predicate.
        //     It throws Volo.Abp.Domain.Entities.EntityNotFoundException if there is no entity
        //     with the given predicate. It throws System.InvalidOperationException if there
        //     are multiple entities with the given predicate.
        //
        // Parameters:
        //   predicate:
        //     A condition to filter entities
        //
        //   includeDetails:
        //     Set true to include all children of this entity
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Deletes many entities by the given predicate.
        //     Please note: This may cause major performance problems if there are too many
        //     entities returned for a given predicate and the database provider doesn't have
        //     a way to efficiently delete many entities.
        //
        // Parameters:
        //   predicate:
        //     A condition to filter entities
        //
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
    }

}
