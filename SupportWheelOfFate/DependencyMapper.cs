using Business.ConnectionManager;
using Business.ExceptionManager;
using Business.Managers;
using Business.Repositories;
using Business.RuleEngine;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportWheelOfFate
{
    public static class DependencyMapper
    {
        public static void SetDependencies(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddTransient<ISchedulingManager, SchedulingManager>();
            services.AddTransient<IEngineerRepository, EngineerRepository>();
            services.AddTransient<IEngineerManager, EngineerManager>();
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            services.AddTransient<IBusinessRuleEngine, BusinessRuleEngine>();
            services.AddTransient<IExceptionHandler, ExceptionHandler>();
            services.AddSingleton<IAppConnectionManager, AppConnectionManager>();
        }
    }
}
