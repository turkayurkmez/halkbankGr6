using System.ComponentModel.DataAnnotations;

namespace eshop.API.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Boş olamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Boş olamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
