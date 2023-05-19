namespace IELearn.Models
{
    public class Course : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Author? Author { get; set; }
        public int? AuthorId { get; set; }
        public int? Count { get; set; }
        public int? Price { get; set; }
        public bool Status { get; set; }
        public CourseImage? CourseImages { get; set; }


    }
}
