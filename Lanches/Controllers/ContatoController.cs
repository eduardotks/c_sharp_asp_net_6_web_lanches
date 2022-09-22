using Microsoft.AspNetCore.Mvc;

namespace Lanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
