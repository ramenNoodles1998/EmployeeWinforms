using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    
    public abstract class Employee
    {
        
        internal double empId { get; set; }
        internal double empType { get; set; }
        internal string firstName { get; set; }
        internal string fullName { get; set; }
        internal string lastName { get; set; }

        


        private double empCounter;
        

        public Employee(double Id, double type, string first, string full, string last)
        {
            empId = Id;
            empType = type;
            firstName = first;
            fullName = full;
            lastName = last;
            empCounter =+ 1;
        }
        


    }
}
