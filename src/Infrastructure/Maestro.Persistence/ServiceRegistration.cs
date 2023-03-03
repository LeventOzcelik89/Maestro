using Maestro.Application.Repository.User;
using Maestro.Persistence.Context;
using Maestro.Persistence.Repositories.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {

            serviceCollection.AddDbContext<MaestroContext>(a =>
            {
                a.UseSqlServer(configuration?.GetConnectionString("SQLConnection"), sqlOption => sqlOption.UseNetTopologySuite());
            });

            serviceCollection.AddTransient<IUserReadRepository, UserReadRepository>();
            serviceCollection.AddTransient<IUserWriteRepository, UserWriteRepository>();

        }
    }
}
