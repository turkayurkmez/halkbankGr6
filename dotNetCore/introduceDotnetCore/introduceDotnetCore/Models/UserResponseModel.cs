using System.ComponentModel.DataAnnotations;

namespace introduceDotnetCore.Models
{
    public class UserResponseModel
    {
        [Required(ErrorMessage = "Adınızı girmeyi unutmayın!")]
        [MinLength(2, ErrorMessage = "En az 2 karakter giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınızı girmeyi unutmayın!")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Eposta formatı hatalı")]
        [Required(ErrorMessage = "Eposta adresi belirtilmeli!")]
        public string Email { get; set; }

    }
}
