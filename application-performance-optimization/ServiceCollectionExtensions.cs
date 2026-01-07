using application_performance_optimization.Context;
using application_performance_optimization.Domain;
using application_performance_optimization.Services;
using Microsoft.EntityFrameworkCore;

namespace application_performance_optimization
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependences(this IServiceCollection services, string mySqlConnection)
        {
            services.AddScoped<IUserDomain, UserDomain>();
            services.AddScoped<IUserService, UserService>();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(mySqlConnection);
            });

            return services;
        }
    }
}
