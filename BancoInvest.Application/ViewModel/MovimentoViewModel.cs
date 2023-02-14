using BancoInvest.Domain.Entities;
using BancoInvest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Application.ViewModel
{
    public class MovimentoViewModel
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public decimal valor { get; set; }
        public decimal Saldo { get; set; }
        public int ClienteId { get; set; }

        [DisplayName("Tipo de Movimentação")]
        public TipoMovimentacao TipoMovimentacao { get; set; }

        [DisplayName("Tipo de Serviço")]
        public TipoServico TipoServico { get; set; }
        public DateTime DataRegistro { get; set; }

        public string Resumo { get; set; }

        [DisplayName("Data de Execução")]
        public DateTime DataCompensacao { get; set; }
        public bool Ativo { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
