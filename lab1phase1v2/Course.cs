using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    [Serializable]
    class Course
    {
        public string id { get; set; }
        public string description { get; set; }

        public double grade { get; set; }

        public string date { get; set; }
        public int creditHours { get; set; }

        public Course(string ident, string descript, double Cgrade, string Adate, int cHours)
        {
            id = ident;
            description = descript;
            grade = Cgrade;
            date = Adate;
            creditHours = cHours;

        }
    }
}
