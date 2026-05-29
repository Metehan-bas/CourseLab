using Microsoft.AspNetCore.Mvc;
using CourseLab.Data;
using System.Linq;

namespace CourseLab.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var student = _context.Students
                .FirstOrDefault(x => x.Email == email && x.Password == password);

            if (student != null)
            {
                HttpContext.Session.SetString("UserName", student.FirstName);
                HttpContext.Session.SetString("Email", student.Email);
                HttpContext.Session.SetString("Role", "Student");
                return RedirectToAction("Index", "Home");
            }

            var instructor = _context.Instructors
                .FirstOrDefault(x => x.Email == email && x.Password == password);

            if (instructor != null)
            {
                HttpContext.Session.SetString("UserName", instructor.FirstName);
                HttpContext.Session.SetString("Email", instructor.Email);
                HttpContext.Session.SetString("Role", "Instructor");

                return RedirectToAction("Index", "Home");
            }                    
            ViewBag.Error = "Email veya şifre yanlış!";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}