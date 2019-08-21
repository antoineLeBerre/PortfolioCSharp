using Microsoft.Extensions.DependencyInjection;
using PortofolioAdmin.Models.Repositories;
using PortofolioAdmin.Models.Repositories.Impl;
using PortofolioAdmin.Services.Supervisors;
using PortofolioAdmin.Services.Supervisors.Impl;

namespace PortofolioAdmin
{
    public static class ConfigurationDi
    {
        public static void SupervisorDi(this IServiceCollection services)
        {
            services.AddScoped<IAdminLoginSupervisor, AdminLoginSupervisor>();
        }
        
        public static void RepositoryDi(this IServiceCollection services)
        {
            services.AddScoped<IAdminLoginRepository, AdminLoginRepository>();
        }
    }
}