using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AuthenticationLibrary.Model;
using AuthenticationLibrary.BLL;
namespace AuthenticationProjectFinal.Controllers
{
    public class EmployeeApiController : ApiController
    {
        private OrganizationEntities db = new OrganizationEntities();
        //public EmployeesController()
        //{
        //    db.Configuration.ProxyCreationEnabled = false;
        //    db.Configuration.LazyLoadingEnabled = false;
        //}

        public void index()
        {
        }

        //[AllowAnonymous]
        // GET: api/EmployeeApi
        public IEnumerable<Employee> GetEmployees()
        {
            Emp obj = new Emp();
            return obj.GetAllEmp();

            //باشد IQuareyable وقتی مقدار بازگشتی
            //return db.Employees.AsEnumerable();
        }

        // GET: api/EmployeeApi/5
        [ResponseType(typeof(Employee))]
        public Employee GetEmployee(int id)
        {
            Emp obj = new Emp();
            return obj.GetEmpById(id);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Emp obj = new Emp();
            bool result = obj.Update(id, employee);
            if (result)
                return Ok();
            else
                return BadRequest();

            //if (id != employee.Eid)
            //{
            //    return BadRequest();
            //}

            //db.Entry(employee).State = EntityState.Modified;

            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!obj.EmployeeExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EmployeeApi
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Emp obj = new Emp();
            bool result = obj.Insert(employee);
            if (result)
                return Ok();
            else
                return BadRequest();


            //db.Employees.Add(employee);
            //db.SaveChanges();
            //return CreatedAtRoute("DefaultApi", new { id = employee.Eid }, employee);
        }

        // DELETE: api/EmployeeApi/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Emp obj = new Emp();
            bool result = obj.Delete(id);

            if (result)
                return Ok();
            else
                return NotFound();

            //Employee employee = db.Employees.Find(id);
            //if (employee == null)
            //{
            //    return NotFound();
            //}

            //db.Employees.Remove(employee);
            //db.SaveChanges();

            //return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}