using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstudoASPNET.Models;

namespace EstudoASPNET.Controllers;

public class OperacoesMatematicasController : Controller
{
    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Soma() 
    {
        return View();
    }

    public IActionResult SomaResultado([FromForm] NumeroModel numeros) 
    {
        return View(numeros);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}