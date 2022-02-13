using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            ViewBag.number = int.Parse(Request.Form["number"]);
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
