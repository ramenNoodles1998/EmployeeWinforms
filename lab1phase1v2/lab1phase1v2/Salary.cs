using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    class Salary : Employee
    {
        internal double monthlySalary { get; set; }
        public Salary(double Id, double type, string first, string full, string last, double salary) : base(Id, type, first, full, last)
        {
            monthlySalary = salary;
        }
        
    }
}
