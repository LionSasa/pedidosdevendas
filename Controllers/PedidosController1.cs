using Microsoft.AspNetCore.Mvc;

namespace pedidosdevendas.Controllers
{
    public class PedidosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
