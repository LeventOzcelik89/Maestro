using Maestro.Application.Interfaces.Context;
using Maestro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Persistence.Context
{

    public class MaestroContext : DbContext, IApplicationContext
    {
        public MaestroContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<SH_User> SH_User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .Entity<SH_User>()
                .HasBaseType<BaseEntity>();

            builder.Entity<SH_User>().Property(a => a.FirstName).HasColumnName("aaaaa");


        }
    }

}
