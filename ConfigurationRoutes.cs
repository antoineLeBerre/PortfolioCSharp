using Microsoft.AspNetCore.Builder;

namespace PortofolioAdmin
{
    public static class ConfigurationRoutes
    {
        public static void GetRoutes(this IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}