using GUIA08.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GUIA08.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string sNumeroTarjeta, string sNumeroPIN)
        {
            double sSaldo;
            string numero;
            Transaccion nuevaTransaccion = new Transaccion(sNumeroTarjeta);
            if (sNumeroTarjeta == "123456" && sNumeroPIN == "654321")
            {
                numero = nuevaTransaccion.GetNumTarjeta();
                sSaldo = nuevaTransaccion.GetSaldo();
                return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" +
               sSaldo);
            }
            else
            {
                // Si el numero de pin o de tarjeta no corresponde, entonces se
                // procede a mostrar un mensaje de error
                ViewBag.Error = "Error en número de tarjeta o número de PIN. Verifique";
                return View();
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ??
           HttpContext.TraceIdentifier
            });
        }
    }
}