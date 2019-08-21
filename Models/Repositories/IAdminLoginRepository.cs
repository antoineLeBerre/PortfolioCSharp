using System;
using System.Threading.Tasks;
using PortofolioAdmin.Models.Models;

namespace PortofolioAdmin.Models.Repositories
{
    public interface IAdminLoginRepository : IDisposable
    {
        Task<int> CreateAdmin(AdminLogin adminLogin);
    }
}