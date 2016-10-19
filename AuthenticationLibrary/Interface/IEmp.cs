using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface
{
    public interface IEmp
    {
        IEnumerable<Employee> GetAllEmp();
        Employee GetEmpById(int? empId);
        IEnumerable<Employee> GetEmpByDepId(int? depId);
        bool EmployeeExists(int? empId);
        bool Insert(Employee emp);
        bool Delete(int? empId);
        bool Update(int id, Employee emp);
    }
}
