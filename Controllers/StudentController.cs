using Microsoft.AspNetCore.Mvc;
using nik.Models;
using nik.Repository;

namespace nik.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        StudentRepo stuRepo = new StudentRepo();
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            try{
                stuRepo.AddStudent(s);
                return Content("Data has been inserted successfully");
            }
            catch(Exception e)
            {
                return Content("Oops error has been occured"+e.Message);
            }
        }
         
    }

}

