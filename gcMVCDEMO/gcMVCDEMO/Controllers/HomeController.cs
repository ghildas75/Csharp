using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gcMVCDEMO.Models;

namespace gcMVCDEMO.Controllers
{
    public class HomeController : Controller
    {
        //HTTP://localhost:[portNumber]/[controler]/Action
        
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult sendListStudent()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student(2, "melanie", "jackson", "aaa@mial.net"));
            studentList.Add( new Student(3, "ghilas", "jackson", "aaa@mial.net"));
            return View("StudentList",studentList);
        }
        public IActionResult SendModelToView()

        {
            Student jennifer = new Student();
            jennifer.StudentId = 1;
            jennifer.LastName = "jenny";
            jennifer.FirstName = "jany";
            jennifer.Email = "jcapirati@gmail.com";
            return  View("Student",jennifer);
        }
        public IActionResult jeny()
        {
            ViewBag.username = "Gerlad godin";
            ViewData["Password"] = "cgodin";
            return View("jeny");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
