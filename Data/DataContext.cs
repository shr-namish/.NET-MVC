using dotNet_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNet_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> get{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student_Table");
            modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse_Table");
            modelBuilder.Entity<Course>().ToTable("Course_Table");
        }


    }
}
