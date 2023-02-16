using BancoInvest.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Text.Json;

namespace BancoInvest.Application.Security
{
    public class SessaoServices : ISessaoServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessaoServices(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public ClienteViewModel BuscarSessaoCliente()
        {
            string sessaoCliente = _httpContextAccessor.HttpContext.Session.GetString("SessaoCliente");
            if (string.IsNullOrEmpty(sessaoCliente)) 
                return null;
           
            return JsonSerializer.Deserialize<ClienteViewModel>(sessaoCliente);
        }

        public void CriarSessaoCliente(ClienteViewModel cliente)
        {

            string valor = JsonSerializer.Serialize<ClienteViewModel>(cliente);
           // _httpContextAccessor.HttpContext.Session.Set("SessaoCliente", Encoding.ASCII.GetBytes(valor));
            _httpContextAccessor.HttpContext.Session.SetString("SessaoCliente", valor);
        }

        public void RemoverSessaoCliente()
        {
            _httpContextAccessor.HttpContext.Session.Remove("SessaoCliente");
        }
    }
}
