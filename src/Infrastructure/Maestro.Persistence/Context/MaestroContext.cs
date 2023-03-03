using Maestro.Application.Interfaces.Context;
using Maestro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SH_User>(a =>
            {
                a.UseTpcMappingStrategy();
                a.Property(p => p.Id).HasDefaultValueSql("(newsequentialid())");
            });


            modelBuilder.Entity<UT_City>(a =>
            {
                a.UseTpcMappingStrategy();
                a.Property(p => p.Id).HasDefaultValueSql("(newsequentialid())");
            });


            modelBuilder.Entity<UT_Town>(a =>
            {
                a.UseTpcMappingStrategy();
                a.Property(p => p.Id).HasDefaultValueSql("(newsequentialid())");
                a.HasOne(p => p.UT_City).WithMany(p => p.UT_Towns).HasForeignKey(p => p.CityId).OnDelete(DeleteBehavior.NoAction);
            });

            SH_User.AddAsync(new SH_User { FirstName = "FN", LastName = "LN" });
            SaveChangesAsync();

            var rs = SH_User.AllAsync(a => true);

            var dbg = "";
        }

    }

}
