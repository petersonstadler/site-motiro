using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using site_motiro.Models;
using site_motiro.Repositories.Implementations;

namespace site_motiro.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult QuemSomos()
    {
        var colaboradores = new ColaboradoresRepository().GetAllColaboradores();
        return View(colaboradores);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
