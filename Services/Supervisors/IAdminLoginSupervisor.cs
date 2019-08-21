using System;
using System.Threading.Tasks;
using PortofolioAdmin.Services.Viewmodels;

namespace PortofolioAdmin.Services.Supervisors
{
    public interface IAdminLoginSupervisor : IDisposable
    {
        Task<bool> CreateAdmin(AdminLoginViewmodel adminLoginViewmodel);
    }
}