using IELearn.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using IELearn.Models;

namespace IELearn.Data
{
       public class AppDbContext : DbContext
       {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Author>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<CourseImage>().HasQueryFilter(m => !m.SoftDelete);


        }
    }
}