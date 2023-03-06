using Maestro.Framework.Interfaces;

namespace Maestro.Framework.Repositories.EntityFrameworkCore
{
    public interface IEfCoreBulkOperationProvider
    {
        Task InsertManyAsync<TDbContext, TEntity>(IEfCoreRepository<TEntity> repository, IEnumerable<TEntity> entities, bool autoSave, CancellationToken cancellationToken) where TDbContext : IEfCoreDbContext where TEntity : class, IEntity;

        Task UpdateManyAsync<TDbContext, TEntity>(IEfCoreRepository<TEntity> repository, IEnumerable<TEntity> entities, bool autoSave, CancellationToken cancellationToken) where TDbContext : IEfCoreDbContext where TEntity : class, IEntity;

        Task DeleteManyAsync<TDbContext, TEntity>(IEfCoreRepository<TEntity> repository, IEnumerable<TEntity> entities, bool autoSave, CancellationToken cancellationToken) where TDbContext : IEfCoreDbContext where TEntity : class, IEntity;
    }
}
