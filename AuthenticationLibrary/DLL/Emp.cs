using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AuthenticationLibrary.DLL
{
    class Emp
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal IEnumerable<Employee> GetAllEmp()
        {
            try
            {
                return OE.Employees.Include(x=>x.tbl_Dpt);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected internal Employee GetEmpById(int? empId)
        {
            try
            {
                Employee emps = (empId == null) ? null : OE.Employees.Where(x => x.Eid == empId).FirstOrDefault();
                return emps;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected internal IEnumerable<Employee> GetEmpByDepId(int? depId)
        {
            try
            {
                return OE.Employees.Where(x => x.Did == depId).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected internal bool EmployeeExists(int? empId)
        {
            try
            {
                return OE.Employees.Count(x => x.Eid == empId) > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        protected internal bool Insert(Employee emp)
        {
            try
            {
                OE.Employees.Add(emp);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        protected internal bool Delete(int? empId)
        {
            try
            {
                Employee employee = OE.Employees.Find(empId);
                if (employee == null)
                {
                    return false;
                }
                else
                {
                    OE.Employees.Remove(employee);
                    OE.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        protected internal bool Update(int id, Employee emp)
        {
            try
            {
                OE.Entry(emp).State = EntityState.Modified;
                OE.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

        }
       
    }
}
