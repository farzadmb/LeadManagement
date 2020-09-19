using LeadManagement.Application;
using LeadManagement.Data;
using LeadManagement.Data.DbHandlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeadManagement.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        #region Public Methods

        public static void AddMySqlConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            var host = configuration["DbHost"] ?? "localhost";
            var port = configuration["dbPort"] ?? "3306";
            var database = configuration["dbName"] = "hipages";
            var userId = configuration["dbUsername"] = "root";
            var password = configuration["dbPassword"] ?? "hipages";

            var connectionString = $"server={host}; userid={userId}; pwd={password}; port={port}; database={database}";

            services.AddDbContext<LeadDbContext>(options => { options.UseMySql(connectionString); });
        }

        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IJobDbHandler, JobDbHandler>();
            services.AddScoped<IJobServices, JobServices>();
        }

        #endregion
    }
}