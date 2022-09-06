using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstudoASPNET.Models;

namespace EstudoASPNET.Controllers;

public class CalculadoraController : Controller
{
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    public IActionResult Calculadora()
    {
        return View();
    }

    public IActionResult CalculadoraResultado([FromForm] double numeroUm, [FromForm] double numeroDois, [FromForm] string operador)
    {
        if(operador == "Soma") 
        {
            ViewBag.Operador = "Soma";
            ViewBag.Resultado = numeroUm + numeroDois;
        }
        else if(operador == "Subtração")
        {
            ViewBag.Operador = "Subtração";
            ViewBag.Resultado = numeroUm - numeroDois;
        }
        else if(operador == "Multiplicação")
        {
            ViewBag.Operador = "Multiplicação";
            ViewBag.Resultado = numeroUm * numeroDois;
        }
        else if(operador == "Divisão")
        {
            ViewBag.Operador = "Divisão";
            ViewBag.Resultado = numeroUm / numeroDois;
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}