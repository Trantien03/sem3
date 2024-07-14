using System.ComponentModel.DataAnnotations;

namespace t2210m_api.Models.Auth
{
    public class LoginModel
    {
        [Required]
        public string email { get; set; }
        [Required]
        [MinLength(6)]
        public string password { get; set; }
    }
}
