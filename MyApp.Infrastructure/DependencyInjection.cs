using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Options;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CleanArchitecture.Infrastructure
{ 
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((provider,options) => {
                //options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=test_api_db;Trusted_Connection=True;TrustServerCertificate=True;");
                //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddHttpClient("");

            return services;
        }
    }
}
