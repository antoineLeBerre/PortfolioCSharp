using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using PortofolioAdmin.Services.Converter;
using PortofolioAdmin.Models.Models;
using PortofolioAdmin.Models.Repositories;
using PortofolioAdmin.Services.Viewmodels;

namespace PortofolioAdmin.Services.Supervisors.Impl
{
    public class AdminLoginSupervisor : IAdminLoginSupervisor
    {
        private readonly IAdminLoginRepository _adminLoginRepository;
        private const string SALT = "portfolioAdmin";

        public AdminLoginSupervisor(IAdminLoginRepository adminLoginRepository)
        {
            _adminLoginRepository = adminLoginRepository;
        }

        public async Task<bool> CreateAdmin(AdminLoginViewmodel adminLoginViewmodel)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: adminLoginViewmodel.Password,
                salt: Encoding.ASCII.GetBytes(SALT),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            int lebght = hashed.Length;

            adminLoginViewmodel.Password = hashed;
            AdminLogin adminLogin = adminLoginViewmodel.Convert();
            int isCreated = await _adminLoginRepository.CreateAdmin(adminLogin);
            return isCreated > 0;
        }
        
        public void Dispose()
        {
            _adminLoginRepository.Dispose();
        }
    }
}