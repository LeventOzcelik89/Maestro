using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.Interfaces
{
    public interface IAbpUnitOfWorkOptions
    {
        bool IsTransactional { get; }

        IsolationLevel? IsolationLevel { get; }

        //
        // Summary:
        //     Milliseconds
        int? Timeout { get; }
    }
}
