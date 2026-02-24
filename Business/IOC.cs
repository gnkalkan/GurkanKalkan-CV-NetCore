using Business.Profiles;
using Business.Services;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Data;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    // IOC (Inversion of Control) : Yapıcı methodlarla gelen yapıların new operatörlerini ortadan kaldırmak için kullanırız.
    public static class IOC 
    {
        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CvDbContext>(options => options.UseSqlite(configuration.GetConnectionString("cvdb")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(config =>
            {
                config.AddMaps(typeof(PersonalProfiles).Assembly);
            });

            services.AddScoped<IPersonalService, PersonalService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IExperienceService, ExperienceService>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IContactService, ContactService>();

            return services;
        }
    }
}
