using GUIA08.Models;
using Microsoft.AspNetCore.Mvc;

namespace GUIA08.Controllers
{
    public class NacionalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: Nacionales
        public ActionResult Nacionales(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }
        [HttpPost]
        public ActionResult NacionalesNuevo(string sNumeroTarjeta, double? sSaldo, double? cantidad)
        {
            if (string.IsNullOrEmpty(sNumeroTarjeta) || sSaldo == null || cantidad == null)
            {
                return BadRequest("Faltan datos para procesar la transacción.");
            }
            Transaccion nuevaTransaccion = new Transaccion(sNumeroTarjeta, sSaldo.Value);
            if (cantidad.Value > 0)
            {
                nuevaTransaccion.TransferenciaNacional(cantidad.Value);
            }
            double nuevoSaldo = nuevaTransaccion.GetSaldo();
            return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" +
           nuevoSaldo);
        }
    }
}