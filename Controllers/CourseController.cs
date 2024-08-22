using dotNet_MVC.Data;
using dotNet_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataContext _context;

        public CourseController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET Section of Course Model
        /// </summary>
        /// <returns></returns>

        
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details() 
        {

            IEnumerable<Course> courses = _context.Courses.ToList();
            return View(courses);
            /*
            var course = _context.Courses.Where(x =>  x.Id == id).FirstOrDefault();
            return View(course);
            */
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(course);

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(course);
        }

        /// <summary>
        /// POST Section of Course Model
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Create(Course model)
        {
            _context.Courses.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            _context.Courses.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }

        [HttpPost]
        public IActionResult Delete(Course model)
        {
            _context.Courses.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }

    }
}
