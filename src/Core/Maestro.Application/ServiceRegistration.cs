using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Maestro.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(Assembly.GetExecutingAssembly());
            collection.AddHttpClient();
        }
    }
}
