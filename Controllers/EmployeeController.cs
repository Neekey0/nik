using Microsoft.AspNetCore.Mvc;
using nik.Models;
namespace nik.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            return View("EmpDetail", emp);
        }
    }
}
