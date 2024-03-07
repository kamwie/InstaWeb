using InstaWeb.Application.Drivers;
using Microsoft.Extensions.DependencyInjection;

namespace InstaWeb.Application.Extensions
{
    public static class Configuration
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            services.AddTransient<IDriversService,DriversService>();

        }
    }
}
