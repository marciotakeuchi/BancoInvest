using BancoInvest.Application.Interfaces;
using BancoInvest.Application.Models;
using BancoInvest.Domain.Interfaces;
using BancoInvest.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BancoInvest.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IClienteServices _clienteServices;
        public LoginController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
               // var result = await _clienteServices. 
                return RedirectToAction("Index", "Home");
            }

            return View(model);
            
        }

    }

    
}
