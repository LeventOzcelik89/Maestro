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
        public DbSet<UT_City> UT_City { get; set; }
        public DbSet<UT_Town> UT_Town { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            //  builder.Entity<BaseEntity>().Property(a => a.Id).HasDefaultValueSql("(newsequentialid())");

            builder.Entity<SH_User>().UseTpcMappingStrategy().Property(a => a.Id).HasDefaultValueSql("(newsequentialid())");
            builder.Entity<UT_City>().UseTpcMappingStrategy().Property(a => a.Id).HasDefaultValueSql("(newsequentialid())");
            builder.Entity<UT_Town>().UseTpcMappingStrategy().Property(a => a.Id).HasDefaultValueSql("(newsequentialid())");
            builder.Entity<UT_Town>().HasOne(a => a.UT_City).WithMany(a => a.UT_Towns).HasForeignKey(a => a.CityId).OnDelete(DeleteBehavior.NoAction);


            //builder
            //    .Entity<SH_User>()
            //    .HasBaseType<BaseEntity>();

            //builder.Entity<SH_User>().Property(a => a.FirstName).HasColumnName("aaaaa");


        }
    }

}
