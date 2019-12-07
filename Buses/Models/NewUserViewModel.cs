using System.ComponentModel.DataAnnotations;

namespace Buses.Models
{
    public class NewUserViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Contraseña { get; set; }
    }
}
