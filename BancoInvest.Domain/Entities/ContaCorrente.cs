namespace BancoInvest.Domain.Entities
{
    public class ContaCorrente 
    {
        public ContaCorrente() {
            Cliente = new Cliente();
        }
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal LimiteEspecial { get; set; }

        
    }
}
