using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClientToMVCWebAPICorsDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudents()
        {
            return View();
        }

        public ActionResult GetStudentById()
        {
            return View();
        }
        public ActionResult UpdateStudent()
        {
            return View();
        }
        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult DeleteStudent()
        {
            return View();
        }
    }
}