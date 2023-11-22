using Microsoft.AspNetCore.Mvc;

namespace SignalRDevExpress.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
    }
}
