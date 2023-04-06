using Microsoft.AspNetCore.Mvc;

namespace Botão_asp.Controllers
{
    public class TestePaginaController : Controller
    {
        public IActionResult Index(string email)
        {
            return View();
        }
    }
}
