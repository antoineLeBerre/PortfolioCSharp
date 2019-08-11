using Microsoft.Extensions.DependencyInjection;

namespace Portofolio
{
    public static class ConfigurationDi
    {
        public static void SupervisorDi(this IServiceCollection services)
        {
            //services.AddScoped<IUserSupervisor, UserSupervisor>();
        }
        
        public static void RepositoryDi(this IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}