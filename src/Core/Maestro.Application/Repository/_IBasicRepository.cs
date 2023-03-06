using Maestro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository
{
    //public partial interface IBasicRepository<TEntity> : IReadOnlyBasicRepository<TEntity>, IRepository where TEntity : class, IEntity
    //    //  IBasicRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    //{

    //    //  Read
    //    IQueryable<TEntity> GetAll(bool tracking = true);
    //    IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true);
    //    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true);
    //    Task<TEntity> GetByIdAsync(string id, bool tracking = true);


    //    //  Write
    //    Task<TEntity> InsertAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
    //    Task InsertManyAsync(IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
        
    //    Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
    //    Task UpdateManyAsync(IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

    //    Task DeleteAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));
    //    Task DeleteManyAsync(IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default(CancellationToken));

    //    Task<int> SaveAsync();

    //}
}
