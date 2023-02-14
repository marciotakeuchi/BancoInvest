namespace BancoInvest.Domain.Entities
{
    public abstract class Conta
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
        public Cliente Cliente { get; set; }
    }
}
