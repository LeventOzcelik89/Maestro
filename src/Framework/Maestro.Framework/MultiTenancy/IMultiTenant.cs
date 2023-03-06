using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.MultiTenancy
{
    public interface IMultiTenant
    {
        //
        // Summary:
        //     Id of the related tenant.
        Guid? TenantId { get; }
    }
}
