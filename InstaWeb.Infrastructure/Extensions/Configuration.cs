using InstaWeb.Application.Drivers;
using InstaWeb.Infrastructure.DAL;
using InstaWeb.Infrastructure.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InstaWeb.Infrastructure.Extensions
{
    public static class Configuration
    {
        public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InstaWebDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDriversRepository, DriversRepository>();
        }
    }
}
