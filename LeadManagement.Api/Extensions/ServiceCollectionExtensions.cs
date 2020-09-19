using LeadManagement.Application;
using LeadManagement.Data;
using LeadManagement.Data.DbHandlers;

using Microsoft.Extensions.DependencyInjection;

namespace LeadManagement.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        #region Public Methods

        public static void AddSqLiteConfigs(this IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite().AddDbContext<SqLiteDbContext>();
        }

        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IJobDbHandler, JobDbHandler>();
            services.AddScoped<IJobServices, JobServices>();
        }

        #endregion
    }
}