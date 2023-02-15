namespace BancoInvest.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Ativo { get; set; }
        public List<ContaCorrente> ContaCorrentes { get; set; }
    }
}
