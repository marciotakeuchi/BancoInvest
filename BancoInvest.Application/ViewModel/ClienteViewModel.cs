using BancoInvest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Application.ViewModel
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome Completo")]
        [MaxLength(200, ErrorMessage ="Informe até 200 caracteres.")]
        public string NomeCompleto { get; set; }

        [Required]
        [DisplayName("CPF")]
        [MaxLength(11, ErrorMessage ="Informe até 11 caracteres, sem pontos ou traços")]
        public string Cpf { get; set; }

        [Required]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(200, ErrorMessage = "Informe corretamente seu e-mail")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Login")]
        [MaxLength(100, ErrorMessage = "Informe até 100 caracteres.")]
        public string Login { get; set; }

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Repetir Senha")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="As senhas devem ser iguais")]
        public string ConfirmPassword { get; set; }
        public bool Ativo { get; set; }
        public virtual List<Conta> Contas { get; set; }
    }
}
