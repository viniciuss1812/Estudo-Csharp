using Microsoft.AspNetCore.Mvc;
using TesteASP.DAL;
using TesteASP.Models;

namespace TesteASP.Controllers
{
    public class Ben10Controller : Controller
    {
        public IActionResult Index()
        {
            Ben10DAL episodios = new Ben10DAL();
            ViewBag.ListaEpisodios = episodios.getTodosEpisodios(); 
            return View();
        }
      
    }
}
