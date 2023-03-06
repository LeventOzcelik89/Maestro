using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.Repositories.EntityFrameworkCore
{
    public interface IDbContextProvider<TDbContext> where TDbContext : IEfCoreDbContext
    {
        [Obsolete("Use GetDbContextAsync method.")]
        TDbContext GetDbContext();

        Task<TDbContext> GetDbContextAsync();
    }
}
