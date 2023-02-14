using BancoInvest.Application.Models;
using BancoInvest.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BancoInvest.MVC.Controllers
{
    public class LoginController : Controller
    {
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
                //var result = await 
                return RedirectToAction("Index", "Home");
            }

            return View(model);
            
        }

    }

    
}
