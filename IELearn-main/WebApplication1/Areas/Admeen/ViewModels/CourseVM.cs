using IELearn.Models;

namespace IELearn.Areas.Admeen.ViewModels {
    public class CourseVM {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public bool Status { get; set; }
        public string? CreateDate { get; set; }
        public string? AuthorName { get; set; }
        public string? Image { get; set; }


    }
}