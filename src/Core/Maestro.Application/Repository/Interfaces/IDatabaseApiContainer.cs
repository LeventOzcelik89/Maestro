using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.Interfaces
{
    public interface IDatabaseApiContainer : IServiceProviderAccessor
    {
        IDatabaseApi FindDatabaseApi(string key);

        void AddDatabaseApi(string key, IDatabaseApi api);

        IDatabaseApi GetOrAddDatabaseApi(string key, Func<IDatabaseApi> factory);
    }
}
