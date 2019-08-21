using PortofolioAdmin.Models.Models;
using PortofolioAdmin.Services.Viewmodels;

namespace PortofolioAdmin.Services.Converter
{
    public static class AdminUserConverter
    {
        public static AdminLogin Convert(this AdminLoginViewmodel adminLoginViewmodel)
        {
            return new AdminLogin
            {
                Id = adminLoginViewmodel.Id,
                Login = adminLoginViewmodel.Login,
                Password = adminLoginViewmodel.Password
            };
        }

        public static AdminLoginViewmodel Convert(this AdminLogin adminLogin)
        {
            return new AdminLoginViewmodel
            {
                Id = adminLogin.Id,
                Login = adminLogin.Login,
                Password = adminLogin.Password
            };
        }
    }
}