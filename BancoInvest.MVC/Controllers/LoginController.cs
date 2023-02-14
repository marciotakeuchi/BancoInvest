using Microsoft.AspNetCore.Mvc;

namespace BancoInvest.MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
