using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => {
                //options.UseMySql("server=localhost;database=myapp_db;user=root;password=");
                options.UseMySql("server=localhost;database=myapp_db;user=root;password=", new MySqlServerVersion(new Version(8, 0, 30)));
            });
            return services;
        }
    }
}
