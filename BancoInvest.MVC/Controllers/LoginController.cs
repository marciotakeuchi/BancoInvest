using BancoInvest.Application.Interfaces;
using BancoInvest.Application.Models;
using BancoInvest.Application.Security;
using BancoInvest.Application.ViewModel;
using BancoInvest.Domain.Interfaces;
using BancoInvest.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BancoInvest.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IClienteServices _clienteServices;
        private readonly ISessaoServices _sessaoServices;
        public LoginController(IClienteServices clienteServices, ISessaoServices sessaoServices)
        {
            _clienteServices = clienteServices;
            _sessaoServices = sessaoServices;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (_sessaoServices.BuscarSessaoCliente() != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult Logoff()
        {
            _sessaoServices.RemoverSessaoCliente();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ClienteViewModel cliente = await _clienteServices.ConsultaLogin(model.Login);
                
                if(cliente != null)
                {
                    if(cliente.SenhaValida(model.Password))
                    {
                        _sessaoServices.CriarSessaoCliente(cliente);
                        return RedirectToAction("Index", "Home");
                    }
                }

                TempData["MensagemErro"] = $"Login ou senha inválidos!";
                return View(model);
            }

            TempData["MensagemErro"] = $"Preencha os campos corretamente!";
            return View(model);
            
        }

    }

    
}
