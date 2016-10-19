using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationLibrary.Model;
using AuthenticationLibrary.BLL;

namespace MyTestApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            Dep obj = new Dep();
            IEnumerable<Department> departments = obj.GetAllDep();

            return View(departments);
        }

        public ActionResult AdminIndex()
        {
            Dep obj = new Dep();
            IEnumerable<Department> departments = obj.GetAllDep();

            return View(departments);
        }

        //---------------------------------
        public ActionResult Details(int id)
        {
            Dep obj = new Dep();
            Department dep = obj.GetDepById(id);

            return View(dep);
        }
        ////---------------------------------
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Dep obj = new Dep();
            Department dep = obj.GetDepById(id);
            return View(dep);
        }

        [HttpPost]
        public ActionResult Edit(int id, Department selectedDep)
        {
            Dep obj = new Dep();
            bool result = obj.Update(id,selectedDep);
             
            return RedirectToAction("AdminIndex");
        }
        ////-----------------------------------
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Dep obj = new Dep();
            Department dep = obj.GetDepById(id);
            return View(dep);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Dep obj = new Dep();
            bool result = obj.Delete(id);

            return RedirectToAction("AdminIndex");
        }

        [HttpGet]
        public ActionResult MainIndex(int id)
        {
            Dep obj = new Dep();           
            bool result = obj.Delete(id);

            return PartialView(obj.GetAllDep());
        }
        ////--------------------------------------
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            Dep obj = new Dep();
            bool result = obj.Insert(department);

            return RedirectToAction("AdminIndex");
        }
    }
}