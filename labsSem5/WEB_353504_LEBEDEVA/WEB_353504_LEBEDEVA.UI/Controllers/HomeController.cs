using Microsoft.AspNetCore.Mvc;

namespace WEB_353504_LEBEDEVA.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
