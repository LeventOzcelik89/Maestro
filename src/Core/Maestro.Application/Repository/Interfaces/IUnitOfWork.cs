using Maestro.Application.Repository.Extension;
using Maestro.Application.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.Interfaces
{
    public interface IUnitOfWork : IDatabaseApiContainer, IServiceProviderAccessor, ITransactionApiContainer, IDisposable
    {
        Guid Id { get; }

        Dictionary<string, object> Items { get; }

        IAbpUnitOfWorkOptions Options { get; }

        IUnitOfWork Outer { get; }

        bool IsReserved { get; }

        bool IsDisposed { get; }

        bool IsCompleted { get; }

        string ReservationName { get; }

        event EventHandler<UnitOfWorkFailedEventArgs> Failed;

        event EventHandler<UnitOfWorkEventArgs> Disposed;

        void SetOuter(IUnitOfWork outer);

        void Initialize(AbpUnitOfWorkOptions options);

        void Reserve(string reservationName);

        Task SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task CompleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken));

        void OnCompleted(Func<Task> handler);
    }
}
