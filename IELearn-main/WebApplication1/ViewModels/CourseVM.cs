using IELearn.Models;

namespace IELearn.ViewModels
{
    public class CourseVM
    {
        public IEnumerable<Course>? Courses { get; set; }
        public IEnumerable<CourseImage>? CourseImages { get; set; }
        public IEnumerable<Author>? Author { get; set; }

    }
}
