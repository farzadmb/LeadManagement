using LeadManagement.Application;
using LeadManagement.Data;
using LeadManagement.Data.DbHandlers;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

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

        public static void AddSwaggerConfigs(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                c => c.SwaggerDoc(
                    "v1",
                    new OpenApiInfo()
                        {
                            Version = "v1",
                            Title = "Lead Management",
                            Description = "A sample application to manage leads",
                            Contact = new OpenApiContact() { Name = "Fred Momeni" }
                        }));
        }

        #endregion
    }
}