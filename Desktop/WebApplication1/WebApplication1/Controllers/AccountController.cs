using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace MeuProjetoMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aqui você salvaria no banco de dados
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}