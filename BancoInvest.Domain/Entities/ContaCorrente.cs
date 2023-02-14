using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Domain.Entities
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente() {
            Cliente = new Cliente();
        }
        public decimal LimiteEspecial { get; set; }

    }
}
