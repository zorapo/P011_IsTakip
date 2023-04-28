using Microsoft.AspNetCore.Mvc;

namespace P011_IsTakip.WebUI.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
