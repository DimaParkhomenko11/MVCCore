using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCCore.Infrastructure.Data;

namespace MVCCore.Extensions
{
    public static class DiExtensions
    {
        public static void AddSQL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MVCDBContext>(options =>
                {
                    options.UseSqlServer(
                            configuration.GetConnectionString("SqlDatabase"),
                            b => b.MigrationsAssembly(typeof(MVCDBContext).Assembly.FullName))
                        .UseLazyLoadingProxies();
                }
            ); 
        }
    }
}