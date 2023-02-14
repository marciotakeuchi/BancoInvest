using BancoInvest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Domain.Entities
{
    public class Movimento
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public decimal valor { get; set; }
        public decimal Saldo { get; set; }
        public int ClienteId { get; set; }
        public TipoMovimentacao TipoMovimentacao  { get; set; }
        public TipoServico TipoServico { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataCompensacao { get; set; }
        public bool Ativo { get; set; }
        public Cliente Cliente { get; set; }
    }
}
