using System.ComponentModel.DataAnnotations;

namespace dotNet_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty ;
        public ICollection<Student> Enrollment { get; set; }
    }
}
