using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoInvest.Domain.Interfaces;

namespace BancoInvest.Domain.Entities
{
    public class ContaCorrente : IConta
    {
        public ContaCorrente() {
            Cliente = new Cliente();
        }
        public int Numero { get; set ; }
        public int Agencia { get; set ; }
        public decimal Saldo { get ; set ; }
        public decimal LimiteEspecial { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataCriacao { get ; set ; }
        public DateTime DataAtualizacao { get ; set ; }
        public bool Ativo { get ; set ; }
        public Cliente Cliente { get; set; }
    }
}
