using Microsoft.AspNetCore.Mvc;

namespace CourseLab.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}