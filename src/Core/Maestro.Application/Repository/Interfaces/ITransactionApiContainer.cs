using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.Interfaces
{
    public interface ITransactionApiContainer
    {
        ITransactionApi FindTransactionApi(string key);

        void AddTransactionApi(string key, ITransactionApi api);

        ITransactionApi GetOrAddTransactionApi(string key, Func<ITransactionApi> factory);
    }
}
