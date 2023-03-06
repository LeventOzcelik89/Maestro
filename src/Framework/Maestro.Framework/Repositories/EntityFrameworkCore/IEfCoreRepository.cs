using Maestro.Framework.Repositories;
using Maestro.Framework.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.Repositories.EntityFrameworkCore
{
    public interface IEfCoreRepository<TEntity> : IRepository<TEntity>, IReadOnlyRepository<TEntity>, IQueryable<TEntity>, IEnumerable<TEntity>, IEnumerable, IQueryable, IReadOnlyBasicRepository<TEntity>, IRepository, IBasicRepository<TEntity> where TEntity : class, IEntity
    {
        [Obsolete("Use GetDbContextAsync() method.")]
        DbContext DbContext { get; }

        [Obsolete("Use GetDbSetAsync() method.")]
        DbSet<TEntity> DbSet { get; }

        Task<DbContext> GetDbContextAsync();

        Task<DbSet<TEntity>> GetDbSetAsync();
    }

    public interface IEfCoreRepository<TEntity, TKey> : IEfCoreRepository<TEntity>, IRepository<TEntity>, IReadOnlyRepository<TEntity>, IQueryable<TEntity>, IEnumerable<TEntity>, IEnumerable, IQueryable, IReadOnlyBasicRepository<TEntity>, IRepository, IBasicRepository<TEntity>, IRepository<TEntity, TKey>, IReadOnlyRepository<TEntity, TKey>, IReadOnlyBasicRepository<TEntity, TKey>, IBasicRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
    }

}
