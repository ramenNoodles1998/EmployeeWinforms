using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    [Serializable]
    public abstract class Employee
    {
        
        internal double empId { get; set; }
        internal double empType { get; set; }
        internal string firstName { get; set; }
        internal string fullName { get; set; }
        internal string lastName { get; set; }

        internal string departmentName { get; set; }
        
        internal string startDate { get; set; }

        internal string benefits { get; set; }

        internal string title { get; set; }

        internal SortedDictionary<string, Course> courses = new SortedDictionary<string, Course>();

        internal bool deleted { get; set; }



        


        
        

        public Employee(double Id, double type, string first, string full, string last, string departmentN, string t, string startD, string ben, bool delete)
        {
            empId = Id;
            empType = type;
            firstName = first;
            fullName = full;
            lastName = last;
            departmentName = departmentN;
            startDate = startD;
            benefits = ben;
            title = t;
           
            deleted = delete;
            
        }
        


    }
}
