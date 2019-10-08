using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1phase1v2
{
    sealed public class BusinessRules
    {
        private static BusinessRules instance = null;



        public static BusinessRules Instance
        {
            get
            {


                if (instance == null)
                {
                    instance = new BusinessRules();
                }
                return instance;

            }
        }


        //public SortedDictionary<double, Employee> empData = new SortedDictionary<double, Employee>();
        public SortedDictionary<string, Employee> empData = new SortedDictionary<string, Employee>();

        private BusinessRules()
        {

        }
        public void UpdateEmployee(double Id, double type, string first, string full, string last, double wage = 0.0, double rate = 0.0, double sales = 0.0)
        {
            if(type == 0)
            {
                //Employee employee = empData[Id.ToString()];
                //HourlyEmployee hourlyEmployee = (HourlyEmployee)employee;
                //hourlyEmployee.empId = Id;
                //hourlyEmployee.empType = type;
                HourlyEmployee employee = new HourlyEmployee(Id, type, first, full, last, wage, rate);
                empData[Id.ToString()] = employee;
            }
            else if(type == 1)
            {
                Salary employee = new Salary(Id, type, first, full, last, wage);
                empData[Id.ToString()] = employee;
            }
            else if (type == 2)
            {
                Sales employee = new Sales(Id, type, first, full, last, wage, rate, sales);
                empData[Id.ToString()] = employee;
            }
            else
            {
                Contract employee = new Contract(Id, type, first, full, last, wage);
                empData[Id.ToString()] = employee;
            }
        }
        public void AddEmployee(string id, Employee emp)
        {
            empData.Add(id, emp);

        }
        
    }
}
