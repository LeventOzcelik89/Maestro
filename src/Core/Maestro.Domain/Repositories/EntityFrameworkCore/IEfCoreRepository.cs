using Maestro.Application.Repositories;
using Maestro.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Domain.Repositories.EntityFrameworkCore
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
}
