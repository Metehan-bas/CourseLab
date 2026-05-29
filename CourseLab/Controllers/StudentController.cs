using Microsoft.AspNetCore.Mvc;
using CourseLab.Data;
using CourseLab.Models;

namespace CourseLab.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(student);
        }   
    }
}