namespace dotNet_MVC.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Enrollment { get; set; }
        public Student Student { get; set; } = new Student();
        public Course Course{ get; set; } = new Course();   
    }
}
