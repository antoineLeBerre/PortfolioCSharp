using System.ComponentModel.DataAnnotations;

namespace PortofolioAdmin.Services.Viewmodels
{
    public class AdminLoginViewmodel
    {
        public int Id { get; set; }
        
        [Required(
            AllowEmptyStrings = false, 
            ErrorMessage = "Veuillez mettre un login")]
        public string Login { get; set; }
        
        [Required(
            AllowEmptyStrings = false, 
            ErrorMessage = "Veuillez mettre un mot de passe")]
        public string Password { get; set; }
    }
}