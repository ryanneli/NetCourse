
using API.Domain.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;
using API.Infra.Data.Context;
using API.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using API.Domain.Interfaces;
using API.Infra.Data.Context.EntitiesCOnfiguration;
using System.Collections.Generic;
using System.Text;
using System;

namespace API.Infra.Ioc
{
    public static class DependencieInjector {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            {

                options.UseSqlServer(connectionString, b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped<ICourse, CourseRepository>();
            services.AddScoped<IGroup, GroupRepository>();
            services.AddScoped<IRegistration, RegistrationRepository>();
            services.AddScoped<IScore, ScoreRepository>();
            services.AddScoped<IUser, UserRepository>();
            
            return services;
        }

    }

}