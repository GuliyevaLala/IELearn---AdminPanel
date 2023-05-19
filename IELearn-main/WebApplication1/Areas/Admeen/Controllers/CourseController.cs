using IELearn.Areas.Admeen.ViewModels;
using IELearn.Models;
using Microsoft.AspNetCore.Mvc;
using IELearn.Data;
using Microsoft.EntityFrameworkCore;


namespace IELearn.Areas.Admeen.Controllers {

    [Area("Admeen")]

    public class CourseController : Controller {
        private readonly AppDbContext _context;

        public CourseController (AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CourseVM> courseList = new();
            IEnumerable<Course> courses = await _context.Courses.Where(m => !m.SoftDelete).Include(ci => ci.CourseImages).Include(a => a.Author).ToListAsync();
            foreach (Course course in courses)
            {
                CourseVM model = new()
                {
                    Id = course.Id,

                    Image = course.CourseImages?.Image,
                    Title = course.Title,
                    Price = (int)course.Price,
                    Count = (int)course.Count,
                    Status = course.Status,
                    Description = course.Description,
                    AuthorName = course.Author.Fullname,
                    CreateDate = course.CreatedDate.ToString("dd-MM-yyyy")
                };

                courseList.Add(model);
            }

            return View(courseList);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Course dbCourse = await _context.Courses.FirstOrDefaultAsync(m => m.Id == id);

            if (dbCourse is null) return NotFound();

            CourseDetailVM model = new()
            {
                CreateDate = dbCourse.CreatedDate.ToString("dd-MM-yyyy"),
                Status = dbCourse.Status,
            };

            return View(model);


        }
    }
}
