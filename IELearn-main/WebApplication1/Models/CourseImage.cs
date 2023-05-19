namespace IELearn.Models
{
    public class CourseImage:BaseEntity
    {
        public string Image { get; set; }
        public Course Courses { get; set; }
        public int? CourseId { get; set; }
        public bool? IsMain { get; set; }

    }
}
