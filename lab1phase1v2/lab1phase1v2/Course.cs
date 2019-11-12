using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1phase1v2
{
    class Course
    {
        private string id { get; set; }
        private string description { get; set; }

        private string grade { get; set; }

        private string date { get; set; }

        public Course(string ident, string descript, string Cgrade, string Adate)
        {
            id = ident;
            description = descript;
            grade = Cgrade;
            date = Adate;

        }
    }
}
