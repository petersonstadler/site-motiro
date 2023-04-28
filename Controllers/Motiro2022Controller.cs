using Microsoft.AspNetCore.Mvc;

namespace site_motiro.Controllers
{
    public class Motiro2022Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
