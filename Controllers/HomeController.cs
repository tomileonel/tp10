using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public string ObtenerTemporadasSerieAjax(int IdSerie){
        List<Temporadas> listaTemporadas = new List<Temporadas>(IdSerie);
        string TemporadasStr ="";
        foreach (Temporadas temp in listaTemporadas)
        {
            TemporadasStr += temp.NumeroTemporada + ": " + temp.TituloTemporada+ " ";
        }
        return TemporadasStr;
    }

    

    public IActionResult Privacy()
    {
        return View();
    }


}
