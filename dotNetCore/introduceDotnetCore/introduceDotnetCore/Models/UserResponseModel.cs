using System.ComponentModel.DataAnnotations;

namespace introduceDotnetCore.Models
{
    public class UserResponseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }
}
