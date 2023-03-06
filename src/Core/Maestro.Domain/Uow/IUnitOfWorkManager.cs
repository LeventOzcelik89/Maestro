using Maestro.Application.Repository.Extension;
using Maestro.Application.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Uow
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
