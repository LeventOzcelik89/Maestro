using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Maestro.Framework.Interfaces;
using Maestro.Framework.Repositories;

namespace Maestro.Framework.Repositories
{

    public interface IBasicRepository<TEntity> : IReadOnlyBasicRepository<TEntity>, IRepository where TEntity : class, IEntity
    {
        //
        // Summary:
        //     Inserts a new entity.
        //
        // Parameters:
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        //   entity:
        //     Inserted entity
        Task<TEntity> InsertAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Inserts multiple new entities.
        //
        // Parameters:
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        //   entities:
        //     Entities to be inserted.
        //
        // Returns:
        //     Awaitable System.Threading.Tasks.Task.
        Task InsertManyAsync(IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Updates an existing entity.
        //
        // Parameters:
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        //   entity:
        //     Entity
        Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Updates multiple entities.
        //
        // Parameters:
        //   entities:
        //     Entities to be updated.
        //
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        // Returns:
        //     Awaitable System.Threading.Tasks.Task.
        Task UpdateManyAsync(IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Deletes an entity.
        //
        // Parameters:
        //   entity:
        //     Entity to be deleted
        //
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        Task DeleteAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Deletes multiple entities.
        //
        // Parameters:
        //   entities:
        //     Entities to be deleted.
        //
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        // Returns:
        //     Awaitable System.Threading.Tasks.Task.
        Task DeleteManyAsync(IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IBasicRepository<TEntity, TKey> : IBasicRepository<TEntity>, IReadOnlyBasicRepository<TEntity>, IRepository, IReadOnlyBasicRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        //
        // Summary:
        //     Deletes an entity by primary key.
        //
        // Parameters:
        //   id:
        //     Primary key of the entity
        //
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        Task DeleteAsync(TKey id, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

        //
        // Summary:
        //     Deletes multiple entities by primary keys.
        //
        // Parameters:
        //   ids:
        //     Primary keys of the each entity.
        //
        //   autoSave:
        //     Set true to automatically save changes to database. This is useful for ORMs /
        //     database APIs those only save changes with an explicit method call, but you need
        //     to immediately save changes to the database.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task to
        //     complete.
        //
        // Returns:
        //     Awaitable System.Threading.Tasks.Task.
        Task DeleteManyAsync(IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
    }

}
