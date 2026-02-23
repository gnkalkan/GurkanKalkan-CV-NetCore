using Core.Abstracts;
using Data;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    // IOC (Inversion of Control)
    public static class IOC 
    {
        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CvDbContext>(options => options.UseSqlite(configuration.GetConnectionString("cvdb")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
