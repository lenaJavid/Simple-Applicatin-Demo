using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface.Builder;

namespace AuthenticationLibrary.BLL.Builder
{
    public class EmpBuilder : IEmpBuilder
    {
        private Model.Employee _employee;

        public EmpBuilder()
        {
            this._employee = new Model.Employee();
        }

        public IEmpBuilder SetEName(string name)
        {
            this._employee.Ename = name;
            return this;
        }

        public IEmpBuilder SetESal(decimal esal)
        {
            this._employee.ESal = esal;
            return this;
        }

        public IEmpBuilder SetEGen(bool isman)
        {
            this._employee.EGen = isman;
            return this;
        }

        public IEmpBuilder SetEDOB(DateTime date)
        {
            this._employee.EDOB = date;
            return this;
        }

        public IEmpBuilder SetDepartmentId(int did)
        {
            this._employee.Did = did;
            return this;
        }

        public Model.Employee GetResult()
        {
            return this._employee;
        }
    }
}
