using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
   [Serializable]
    class Salary : Employee
    {
        internal double monthlySalary { get; set; }
        public Salary(double Id, double type, string first, string full, string last, string departmentN, string t,string startD, string ben, bool delete, double salary) : base(Id, type, first, full, last, departmentN, t, startD, ben, delete)
        {
            monthlySalary = salary;
        }
        
    }
}
