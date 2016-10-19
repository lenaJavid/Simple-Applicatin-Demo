using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTestApplication.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "1,2")]
        public ActionResult ViewEmployee()
        {
            return Redirect("~/HTML/ViewEmployee.html");
        }

        [Authorize(Roles = "2,1")]
        public ActionResult ViewDepartment()
        {
            ViewBag.Message = "Department Detail page.";

            return RedirectToAction("Index", "Departments");
        }

        [Authorize(Roles = "1")]
        public ActionResult AdminEmployee()
        {
            ViewBag.Message = "Employees Detail page.";

            return RedirectToAction("Index", "Employees");
        }

        [Authorize(Roles = "1")]
        public ActionResult AdminDepartment()
        {
            ViewBag.Message = "Departments Detail page.";

            return RedirectToAction("AdminIndex", "Departments");
        }
    }
}