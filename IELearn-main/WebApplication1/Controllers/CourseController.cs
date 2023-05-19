using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IELearn.Data;
using IELearn.Models;
using IELearn.ViewModels;

namespace IELearn.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()

        {
            IEnumerable<Course> course = await _context.Courses.Where(m => !m.SoftDelete).Include(ci => ci.CourseImages).Include(a => a.Author).ToListAsync();

            return View(course);
        }
    }
}