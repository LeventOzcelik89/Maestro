using Maestro.Framework.Repository.Extension;
using Maestro.Framework.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.Uow
{
    public interface IUnitOfWorkManager
    {
        IUnitOfWork Current { get; }

        IUnitOfWork Begin(AbpUnitOfWorkOptions options, bool requiresNew = false);

        IUnitOfWork Reserve(string reservationName, bool requiresNew = false);

        void BeginReserved(string reservationName, AbpUnitOfWorkOptions options);

        bool TryBeginReserved(string reservationName, AbpUnitOfWorkOptions options);
    }
}
