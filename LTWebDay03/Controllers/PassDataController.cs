using LTWebDay03.Models;
using Microsoft.AspNetCore.Mvc;

namespace LTWebDay03.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "Đặng Huy";
            ViewData["time"] = DateTime.Now;

            var student = new Student()
            {
                Id = 1,
                Name = "Huy",
                Age = 21,
                Gender = "Nam",
                IsActive = true,
                
            };
            ViewData["student"] = student;
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "VipGG" , Age = 18 , Gender = "Nam"},
                new Student { Id = 2, Name = "VipA" , Age = 18 , Gender = "Nam"},
                new Student { Id = 3, Name = "VipB" , Age = 18 , Gender = "Nam"},
                new Student { Id = 4, Name = "VipC" , Age = 18 , Gender = "Nam"},
                new Student { Id = 5, Name = "VipD" , Age = 18 , Gender = "Nam"}
            }; 
            ViewData["students"] = students;


            
            return View();
        }
        public IActionResult ViewBagDemo()
        {
            ViewBag.name = "Đặng Huy";
            ViewBag.time = DateTime.Now;

            var student = new Student()
            {
                Id = 1,
                Name = "Huy",
                Age = 21,
                Gender = "Nam",
                IsActive = true

            };
            ViewBag.student = student;
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "VipGG" , Age = 18 , Gender = "Nam"},
                new Student { Id = 2, Name = "VipA" , Age = 18 , Gender = "Nam"},
                new Student { Id = 3, Name = "VipB" , Age = 18 , Gender = "Nam"},
                new Student { Id = 4, Name = "VipC" , Age = 18 , Gender = "Nam"},
                new Student { Id = 5, Name = "VipD" , Age = 18 , Gender = "Nam"}
            };
            ViewBag.students = students;



            return View();
        }
    }
}
