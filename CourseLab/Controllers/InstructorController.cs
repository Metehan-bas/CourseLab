using Microsoft.AspNetCore.Mvc;
using CourseLab.Data;
using CourseLab.Models;

namespace CourseLab.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _context;
        public InstructorController(AppDbContext context) => _context = context;

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                _context.Instructors.Add(instructor);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(instructor);
        }
    }
}