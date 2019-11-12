using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    [Serializable]
    sealed class Sales: Salary
    {
        internal double commission { get; set; }
        internal double grossSales { get; set; }
        public Sales(double Id, double type, string first, string full, string last, string departmentN, string startD, string ben, bool delete, double salary, double com, double sales) : base(Id, type, first, full, last, departmentN, startD, ben, delete, salary)
        {
            commission = com;
            grossSales = sales;
        }
        
       

    }
}
