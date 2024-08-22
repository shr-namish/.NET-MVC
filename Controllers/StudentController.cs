using dotNet_MVC.Data;
using dotNet_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_MVC.Controllers
{
    public class StudentController : Controller
    {

        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StudentBio()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StudentCourse()
        {
            return View(new StudentCourse());
        }


        [HttpPost]
        public IActionResult StudentBio(Student model)
        {   
            _context.Student.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }
    } 
}
