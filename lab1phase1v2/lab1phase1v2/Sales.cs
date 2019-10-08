using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    sealed class Sales: Salary
    {
        internal double commission { get; set; }
        internal double grossSales { get; set; }
        public Sales(double Id, double type, string first, string full, string last, double salary, double com, double sales) : base(Id, type, first, full, last, salary)
        {
            commission = com;
            grossSales = sales;
        }
        
       

    }
}
