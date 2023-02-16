using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoInvest.Application.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Campo Login é obrigatório.")]
        [DisplayName("Usuario")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Campo senha obrigatório.")]
        [DataType(DataType.Password)]
        public string  Password { get; set; }


    }
}
