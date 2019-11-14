using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    [Serializable]
    sealed class HourlyEmployee : Employee
    {
        internal double hourlyRate { get; set; }
        internal double hoursWorked { get; set; }

        
        public HourlyEmployee(double Id, double type, string first, string full, string last, string departmentN, string t, string startD, string ben, bool delete, double rate, double hours) : base(Id, type, first, full, last, departmentN,t, startD, ben, delete)
        {
            hourlyRate = rate;
            hoursWorked = hours;
            
        }
        
    }
}
