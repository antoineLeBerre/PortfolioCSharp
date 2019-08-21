using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortofolioAdmin.Services.Supervisors;
using PortofolioAdmin.Services.Viewmodels;

namespace PortofolioAdmin.Controllers
{
    [Route("Admin")]
    public class AdminLoginController : Controller
    {
        private readonly IAdminLoginSupervisor _adminLoginSupervisor;

        public AdminLoginController(IAdminLoginSupervisor adminLoginSupervisor)
        {
            _adminLoginSupervisor = adminLoginSupervisor;
        }

        [HttpGet("sign-up", Name = "GetSign-up")]
        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost("sign-up", Name = "PostSign-up")]
        public async Task<IActionResult> SignUp(AdminLoginViewmodel adminLoginViewmodel)
        {
            if (!ModelState.IsValid) return View();
            bool isCreated = await _adminLoginSupervisor.CreateAdmin(adminLoginViewmodel);
            if (isCreated)
            {
                return RedirectToAction("SignIn");
            }
            else
            {
                return View();
            }
        }
        
        [HttpGet("sign-in", Name = "GetSign-in")]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}