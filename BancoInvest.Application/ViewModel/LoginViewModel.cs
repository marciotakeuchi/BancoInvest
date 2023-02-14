using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoInvest.Application.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Usuario")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string  Password { get; set; }


    }
}
