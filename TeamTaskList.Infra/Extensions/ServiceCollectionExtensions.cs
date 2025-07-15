using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TeamTaskList.Infra.Context;
using TeamTaskList.Infra.Repositories;

namespace TeamTaskList.Infra.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TaskManagerDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<ProjectRepository>();
            services.AddScoped<TaskRepository>();

            return services;
        }
    }
}
