using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary.Model
{
    public class EmpMeta
    {
        public int Eid { get; set; }
        public Nullable<decimal> ESal { get; set; }
        public Nullable<bool> EGen { get; set; }
        public Nullable<System.DateTime> EDOB { get; set; }
        public int Did { get; set; }     
    }

    [MetadataTypeAttribute(typeof(EmpMeta))]
    public partial class Employee 
    {
        //----------Defining Constructors for Employee Model
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Constructor with values
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isman"></param>
        public Employee(String name, bool isman)
        {
            this._ename = name;
            this.EGen = isman;
        }

        //------------Defining Properties of Employee Class which are differ from a main model
        //define private values
        private string _ename;

        public string Ename
        {
            get
            {
                return _ename;
            }
            set
            {
                if ((value == "Ali"))
                {
                    _ename = value + "salam";
                }
                else
                    _ename = value;
            }
        }

        public Department tbl_Dpt { get; set; }
    }
}
