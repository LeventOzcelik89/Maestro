using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Persistence.Context
{
    public class MaestroContextFactory : DesignTimeMaestroContextFactory<MaestroContext>
    {
        protected override MaestroContext CreateNewInstance(DbContextOptions<MaestroContext> options)
        {
            return new MaestroContext(options);
        }
    }
}
