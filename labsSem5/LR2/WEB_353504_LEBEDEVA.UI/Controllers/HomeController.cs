using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_353504_LEBEDEVA.UI.Models;

namespace WEB_353504_LEBEDEVA.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Лабораторная работа №2";
            var items = new List<string>()
            {
                "элемент 0 списка",
                "элемент 1 списка",
                "элемент 2 списка",
                "элемент 3 списка",
                "элемент 4 списка"
            };
            ViewData["ListItems"] = items;

            var selectItems = new List<ListDemo>
            {
                new ListDemo { Id = 1, Name = "item 1" },
                new ListDemo { Id = 2, Name = "item 2" },
                new ListDemo { Id = 3, Name = "item 3" }
            };
            ViewData["SelectItems"] = new SelectList(selectItems, "Id", "Name");

            return View();
        }
    }
}
