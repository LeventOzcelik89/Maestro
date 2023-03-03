using Maestro.Application.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Maestro.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmailService, EmailService>();
        }
    }
}
