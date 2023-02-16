using BancoInvest.Application.Interfaces;
using BancoInvest.Application.Security;
using BancoInvest.Application.ViewModel;
using BancoInvest.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BancoInvest.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISessaoServices _sessaoServices;
        private readonly IContaCorrenteServices _contaCorrenteServices;

        public HomeController(ILogger<HomeController> logger, ISessaoServices sessaoservices, IContaCorrenteServices contaCorrenteServices)
        {
            _logger = logger;
            _sessaoServices = sessaoservices;
            _contaCorrenteServices = contaCorrenteServices;
        }

       
        public async Task<IActionResult> Index()
        {
            ClienteViewModel cliente = _sessaoServices.BuscarSessaoCliente();

            cliente.Contas = await  _contaCorrenteServices.GetContasByClientId(cliente.Id);

            return View(cliente);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}