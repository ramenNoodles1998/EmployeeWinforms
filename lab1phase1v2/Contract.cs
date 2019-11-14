using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    [Serializable]
    sealed class Contract : Employee
    {
        internal double contractWage { get; set; }
        public Contract(double Id, double type, string first, string full, string last, string departmentN, string t, string startD, string ben, bool delete, double Wage) : base(Id, type, first, full, last, departmentN, t, startD, ben, delete)
        {
            contractWage = Wage;
        }
    }
}
