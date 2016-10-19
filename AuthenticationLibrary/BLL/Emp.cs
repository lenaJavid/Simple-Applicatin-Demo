using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class Emp : IEmp
    {
        public IEnumerable<Employee> GetAllEmp()
        {
            try
            {
                DLL.Emp obj = new DLL.Emp();
                return obj.GetAllEmp();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Employee GetEmpById(int? empId)
        {
            try
            {
                if (empId != null)
                {
                    DLL.Emp obj = new DLL.Emp();
                    return obj.GetEmpById(empId);
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Employee> GetEmpByDepId(int? depId)
        {
            try
            {
                if (depId != null)
                {
                    DLL.Emp obj = new DLL.Emp();
                    return obj.GetEmpByDepId(depId);
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool EmployeeExists(int? empId)
        {
            try
            {
                if (empId != null)
                {
                    DLL.Emp obj = new DLL.Emp();
                    return obj.EmployeeExists(empId);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Insert(Employee emp)
        {
            try
            {
                if (emp != null)
                {
                    DLL.Emp employee = new DLL.Emp();
                    return employee.Insert(emp);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int? empId)
        {
            try
            {
                if (empId != null)
                {
                    DLL.Emp employee = new DLL.Emp();
                    return employee.Delete(empId);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(int id, Employee emp)
        {
            try
            {
                if (id != emp.Eid)
                {
                    return false;
                } 

                if (emp.Eid.ToString() != String.Empty && emp.Ename != String.Empty)
                {
                    DLL.Emp employee = new DLL.Emp();
                    return employee.Update(id , emp);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
