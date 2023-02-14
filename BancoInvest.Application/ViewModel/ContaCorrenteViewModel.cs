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
    public class ContaCorrenteViewModel
    {
        public Guid Id { get; set; }
        
        [Required]
        [DisplayName("Número")]
        public int Numero { get; set; }

        [Required]
        [DisplayName("Agência")]
        public int Agencia { get; set; }


        public decimal Saldo { get; set; }

        [DisplayName("Limite especial")]
        public decimal LimiteEspecial { get; set; }
        public int ClienteId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de Cadastro")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Última Atualização")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
