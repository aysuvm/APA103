using _26_DynamicPropertiesViewModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewModels.Models;
using ViewModels.ViewModels;

namespace Dynamic_data__ViewModels.Controllers
{
    public class HomeController : Controller
    {
        
        private List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Ruad", Age = 20 },
            new Student { Id = 2, Name = "Gunel", Age = 19 },
            new Student { Id = 3, Name = "Aysu", Age = 19 }
        };

        List<Teacher> teachers = new List<Teacher>()
{
    new Teacher { Id = 1, Name = "Ali", Salary = 500 },
    new Teacher { Id = 2, Name = "Ruad", Salary = 4200 }
};


    

        public IActionResult Index()
        {
           
            //ViewBag .Students = students;
            return View();
        }

        HomeVM homeVM = new()
        {
            Teachers = teachers,
            Students = students
        };

return View(homeVM);



        //[Route("korporativ-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
