using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PortofolioAdmin.Models.Models;

namespace PortofolioAdmin.Models.Repositories.Impl
{
    public class AdminLoginRepository : IAdminLoginRepository
    {
        private readonly PortfolioContext _context;
        private readonly ILogger<AdminLoginRepository> _logger;
        
        public AdminLoginRepository(PortfolioContext context, ILogger<AdminLoginRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<int> CreateAdmin(AdminLogin adminLogin)
        {
            _context.AdminLogins.Add(adminLogin);
            try
            {
                int isSaved = await _context.SaveChangesAsync();
                _logger.LogInformation("Sauvegarde reussis !!!");
                return isSaved;
            }
            catch (Exception e)
            {
                _logger.LogError("Erreur dans la sauvegarde voir message ci-dessous pour plus de précision", e);
                return 0;
            }
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}