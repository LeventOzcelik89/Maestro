using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.Interfaces
{
    public interface ITransactionApi : IDisposable
    {
        Task CommitAsync();
    }
}
