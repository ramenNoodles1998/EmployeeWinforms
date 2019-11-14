using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1phase1v2
{
    public partial class AddClasses : Form
    {
        public AddClasses()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var x = BusinessRules.Instance.searchEmployee(searchBox.Text);
            if(x == null)
            {
                searchBox.Text = "Not Found! Retry!";
                return;
            }
            else
            {
                classesList.Items.Clear();
                classesList.Items.Add(x.firstName);
                foreach (var item in x.courses)
                {
                    classesList.Items.Add(item.Key);
                }
                   
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            if(classesList.Items.Count > 0)
            {
                var x = BusinessRules.Instance.searchEmployee(classesList.Items[0].ToString());
                int creditHours = 0;
                double courseG =0 ;
                double courseCountGrade = 0;
                Course course = null;
                try
                {
                    classesList.BackColor = Color.White;
                    courseG = Convert.ToDouble(CourseGrade.Text);
                    creditHours = Int32.Parse(CreditHours.Text);
                    
                }
                catch
                {
                    classesList.BackColor = Color.Red;
                    classesList.Items.Clear();
                    classesList.Items.Add("Course Grade must be a double and Credit Hours must be an int.");
                }
                
                
                if (x != null)
                {
                    course = new Course(CourseID.Text, CourseDescription.Text, courseG, ApprovedDate.Text, creditHours);
                    foreach (var items in x.courses)
                    {
                        courseCountGrade += items.Value.grade;
                        creditHours += items.Value.creditHours;
                    }

                }
                
                double avgGrade = x.courses.Count() == 0 ? courseG: courseCountGrade/x.courses.Count();


                if (x.empType == 0)//hourly
                {
                    
                    if (avgGrade >= 3 && creditHours <= 3  )
                    {
                        if (!x.courses.ContainsKey(CourseID.Text))
                        {
                            x.courses.Add(CourseID.Text, course);
                            classesList.Items.Add(CourseID.Text);

                        }
                        else
                        {
                            MessageBox.Show("Course ID must be unique!");
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("Grades must average above a 3.0 and less than 3 credit hours!");
                    }
                }
                else if(x.empType == 1)//salary
                {
                    if (avgGrade >= 3.3 && creditHours <= 6 )
                    {
                        if (!x.courses.ContainsKey(CourseID.Text))
                        {
                            x.courses.Add(CourseID.Text, course);
                            classesList.Items.Add(CourseID.Text);

                        }
                        else
                        {
                            MessageBox.Show("Course ID must be unique!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Grades must average above a 3.3 and less than 6 credit hours!");
                    }

                }
                else if(x.empType == 2)//sales
                {
                    if (avgGrade >= 2.0 && creditHours <= 5 )
                    {
                        if (!x.courses.ContainsKey(CourseID.Text))
                        {
                            x.courses.Add(CourseID.Text, course);
                            classesList.Items.Add(CourseID.Text);

                        }
                        else
                        {
                            MessageBox.Show("Course ID must be unique!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Grades must average above a 2.0 and less than 5 credit hours!");
                    }

                }
                else//contract
                {
                    classesList.Items.Add("No education benefits");
                }
                
            }
            
        }

       
    }
}
