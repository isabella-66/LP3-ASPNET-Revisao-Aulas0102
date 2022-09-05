using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstudoASPNET.Models;

namespace EstudoASPNET.Controllers;

public class QueryController : Controller
{
    private readonly ILogger<QueryController> _logger;

    public QueryController(ILogger<QueryController> logger)
    {
        _logger = logger;
    }

    public string Pesquisa([FromQuery] string cor, [FromQuery] string valorMaximo) 
    {
        return $"{cor}, {valorMaximo}";
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}