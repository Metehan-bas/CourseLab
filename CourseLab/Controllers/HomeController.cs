using Microsoft.AspNetCore.Mvc;

namespace CourseLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}