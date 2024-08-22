﻿namespace dotNet_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }
          
        public ICollection<StudentCourse> Enrollment { get; set; } 
    }
}
