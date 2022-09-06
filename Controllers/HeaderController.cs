using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstudoASPNET.Models;

namespace EstudoASPNET.Controllers;

public class HeaderController : Controller
{
    private readonly ILogger<HeaderController> _logger;

    public HeaderController(ILogger<HeaderController> logger)
    {
        _logger = logger;
    }

    public string Pesquisa([FromForm] string cor, [FromHeader] string valor) 
    {
        return $"{cor}, {valor}";
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}