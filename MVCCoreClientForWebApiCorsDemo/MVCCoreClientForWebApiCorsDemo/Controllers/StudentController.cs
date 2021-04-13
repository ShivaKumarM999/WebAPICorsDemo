using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreClientForWebApiCorsDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetStudents()
        {
            return View();
        }
        public IActionResult GetStudentById()
        {
            return View();
        }
        public IActionResult UpdateStudent()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        public IActionResult DeleteStudent()
        {
            return View();
        }
    }
}
