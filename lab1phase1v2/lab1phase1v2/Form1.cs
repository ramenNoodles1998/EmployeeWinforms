using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1phase1v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Random random = new Random();
            string employeeId = random.Next(0, 100000).ToString();
            mainPanel.BackColor = Color.GhostWhite;
            mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TextBox firstNameText = new TextBox();
            firstNameText.Location = new Point(260, 100);
            this.Controls.Add(firstNameText);
            firstNameText.BringToFront();


            Label firstName = new Label();
            firstName.Location = new Point(260, 70);
            this.Controls.Add(firstName);
            firstName.BringToFront();
            firstName.Text = "First Name*";


            TextBox lastNameText = new TextBox();
            lastNameText.Location = new Point(260, 170);
            this.Controls.Add(lastNameText);
            lastNameText.BringToFront();

            Label lastNameLabel = new Label();
            lastNameLabel.Location = new Point(260, 140);
            this.Controls.Add(lastNameLabel);
            lastNameLabel.BringToFront();
            lastNameLabel.Text = "Last Name*";

            ComboBox dropDownEmp = new ComboBox();
            dropDownEmp.Location = new Point(260, 240);
            this.Controls.Add(dropDownEmp);
            dropDownEmp.Items.Add("Hourly");
            dropDownEmp.Items.Add("Salary");
            dropDownEmp.Items.Add("Sales");
            dropDownEmp.Items.Add("Contract");
            dropDownEmp.BringToFront();
            dropDownEmp.SelectedIndexChanged += delegate (object sender1, EventArgs e1) { dropDownEmp_SelectedIndexChanged(sender1, e1, firstNameText, lastNameText, employeeId); };
            //this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);

            Label empT = new Label();
            empT.Location = new Point(260, 210);
            this.Controls.Add(empT);
            empT.BringToFront();
            empT.Text = "Employee Type*";

            this.employeeList.SelectedIndexChanged += delegate (object sender1, EventArgs e1) { employeeList_SelectedIndexChanged(sender1, e1, firstNameText, lastNameText, dropDownEmp); }; ;
        }

        private void dropDownEmp_SelectedIndexChanged(object sender, EventArgs e, TextBox firstName, TextBox lastName, string employeeId)
        {
            mainPanel.Controls.Clear();

            ComboBox lb = sender as ComboBox;
            int selected = lb.SelectedIndex;


            if (selected == 0)
            {
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox hourlyRateText = new TextBox();
                hourlyRateText.Location = new Point(175, 65);
                mainPanel.Controls.Add(hourlyRateText);
                hourlyRateText.BringToFront();


                Label hourlyRateLabel = new Label();
                hourlyRateLabel.Location = new Point(175, 40);
                mainPanel.Controls.Add(hourlyRateLabel);
                hourlyRateLabel.BringToFront();
                hourlyRateLabel.Text = "Hourly Rate*";

                TextBox HoursWorkedText = new TextBox();
                HoursWorkedText.Location = new Point(175, 120);
                mainPanel.Controls.Add(HoursWorkedText);
                HoursWorkedText.BringToFront();

                Label HoursWorkedLabel = new Label();
                HoursWorkedLabel.Location = new Point(175, 90);
                mainPanel.Controls.Add(HoursWorkedLabel);
                HoursWorkedLabel.BringToFront();
                HoursWorkedLabel.Text = "Hours Worked*";



                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickHourly(sender1, e1, HoursWorkedText, hourlyRateText, firstName, lastName, employeeId); };



            }
            else if (selected == 1)
            {
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox monthlyTextBox = new TextBox();
                monthlyTextBox.Location = new Point(175, 65);
                mainPanel.Controls.Add(monthlyTextBox);
                monthlyTextBox.BringToFront();


                Label monthlySalary = new Label();
                monthlySalary.Location = new Point(175, 40);
                mainPanel.Controls.Add(monthlySalary);
                monthlySalary.BringToFront();
                monthlySalary.Text = "Monthly Salary*";

                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickSalary(sender1, e1, monthlyTextBox, firstName, lastName, employeeId); };

            }
            else if (selected == 2)
            {
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox monthlyTextBox = new TextBox();
                monthlyTextBox.Location = new Point(175, 65);
                mainPanel.Controls.Add(monthlyTextBox);
                monthlyTextBox.BringToFront();


                Label monthlySalary = new Label();
                monthlySalary.Location = new Point(175, 40);
                mainPanel.Controls.Add(monthlySalary);
                monthlySalary.BringToFront();
                monthlySalary.Text = "Monthly Salary*";

                Label grossSales = new Label();
                grossSales.Location = new Point(175, 90);
                mainPanel.Controls.Add(grossSales);
                grossSales.BringToFront();
                grossSales.Text = "Gross Sales*";

                TextBox grossTextBox = new TextBox();
                grossTextBox.Location = new Point(175, 120);
                mainPanel.Controls.Add(grossTextBox);
                grossTextBox.BringToFront();

                Label Commission = new Label();
                Commission.Location = new Point(300, 40);
                mainPanel.Controls.Add(Commission);
                Commission.BringToFront();
                Commission.Text = "Commission*";

                TextBox commissionTextBox = new TextBox();
                commissionTextBox.Location = new Point(300, 65);
                mainPanel.Controls.Add(commissionTextBox);
                commissionTextBox.BringToFront();

                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickSales(sender1, e1, monthlyTextBox, grossTextBox, commissionTextBox, firstName, lastName, employeeId); };
            }
            else
            {
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox contractWageText = new TextBox();
                contractWageText.Location = new Point(175, 65);
                mainPanel.Controls.Add(contractWageText);
                contractWageText.BringToFront();


                Label contractWageLabel = new Label();
                contractWageLabel.Location = new Point(175, 40);
                mainPanel.Controls.Add(contractWageLabel);
                contractWageLabel.BringToFront();
                contractWageLabel.Text = "Contract Wage*";



                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickContract(sender1, e1, contractWageText, firstName, lastName, employeeId); };


            }
        }


        private void employeeList_SelectedIndexChanged(object sender, EventArgs e, TextBox firstName, TextBox lastName, ComboBox dropdown)
        {
            mainPanel.Controls.Clear();
            ListBox lb = sender as ListBox;
            int selected = lb.SelectedIndex;
            if (selected == -1)
            {
                return;
            }
            
            var empId = lb.Items[selected];
            string id = empId.ToString();

            var employee = BusinessRules.Instance.empData.ContainsKey(id) ? BusinessRules.Instance.empData[id] : BusinessRules.Instance.empDel[id];
            string employeeId = employee.empId.ToString();


            if (employee.empType == 0)
            {
                HourlyEmployee hEmployee = (HourlyEmployee)employee;
                dropdown.SelectedIndex = (int)hEmployee.empType;
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox hourlyRateText = new TextBox();
                hourlyRateText.Location = new Point(175, 65);
                mainPanel.Controls.Add(hourlyRateText);
                hourlyRateText.BringToFront();
                hourlyRateText.Text = hEmployee.hourlyRate.ToString();


                Label hourlyRateLabel = new Label();
                hourlyRateLabel.Location = new Point(175, 40);
                mainPanel.Controls.Add(hourlyRateLabel);
                hourlyRateLabel.BringToFront();
                hourlyRateLabel.Text = "Hourly Rate*";

                TextBox HoursWorkedText = new TextBox();
                HoursWorkedText.Location = new Point(175, 120);
                mainPanel.Controls.Add(HoursWorkedText);
                HoursWorkedText.BringToFront();
                HoursWorkedText.Text = hEmployee.hoursWorked.ToString();

                Label HoursWorkedLabel = new Label();
                HoursWorkedLabel.Location = new Point(175, 90);
                mainPanel.Controls.Add(HoursWorkedLabel);
                HoursWorkedLabel.BringToFront();
                HoursWorkedLabel.Text = "Hours Worked*";


                firstName.Text = hEmployee.firstName;
                lastName.Text = hEmployee.lastName;

                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();



                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickHourly(sender1, e1, HoursWorkedText, hourlyRateText, firstName, lastName, employeeId); };



            }
            else if (employee.empType == 1)
            {
                Salary sEmployee = (Salary)employee;
                dropdown.SelectedIndex = (int)sEmployee.empType;
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox monthlyTextBox = new TextBox();
                monthlyTextBox.Location = new Point(175, 65);
                mainPanel.Controls.Add(monthlyTextBox);
                monthlyTextBox.BringToFront();
                monthlyTextBox.Text = sEmployee.monthlySalary.ToString();


                Label monthlySalary = new Label();
                monthlySalary.Location = new Point(175, 40);
                mainPanel.Controls.Add(monthlySalary);
                monthlySalary.BringToFront();
                monthlySalary.Text = "Monthly Salary*";

                firstName.Text = sEmployee.firstName;
                lastName.Text = sEmployee.lastName;


                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickSalary(sender1, e1, monthlyTextBox, firstName, lastName, employeeId); };

            }
            else if (employee.empType == 2)
            {
                Sales saleEmployee = (Sales)employee;

                dropdown.SelectedIndex = (int)saleEmployee.empType;
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox monthlyTextBox = new TextBox();
                monthlyTextBox.Location = new Point(175, 65);
                mainPanel.Controls.Add(monthlyTextBox);
                monthlyTextBox.BringToFront();
                monthlyTextBox.Text = saleEmployee.monthlySalary.ToString();


                Label monthlySalary = new Label();
                monthlySalary.Location = new Point(175, 40);
                mainPanel.Controls.Add(monthlySalary);
                monthlySalary.BringToFront();
                monthlySalary.Text = "Monthly Salary*";

                Label grossSales = new Label();
                grossSales.Location = new Point(175, 90);
                mainPanel.Controls.Add(grossSales);
                grossSales.BringToFront();
                grossSales.Text = "Gross Sales*";

                TextBox grossTextBox = new TextBox();
                grossTextBox.Location = new Point(175, 120);
                mainPanel.Controls.Add(grossTextBox);
                grossTextBox.BringToFront();
                grossTextBox.Text = saleEmployee.grossSales.ToString();


                Label Commission = new Label();
                Commission.Location = new Point(300, 40);
                mainPanel.Controls.Add(Commission);
                Commission.BringToFront();
                Commission.Text = "Commission*";

                TextBox commissionTextBox = new TextBox();
                commissionTextBox.Location = new Point(300, 65);
                mainPanel.Controls.Add(commissionTextBox);
                commissionTextBox.BringToFront();
                commissionTextBox.Text = saleEmployee.commission.ToString();

                firstName.Text = saleEmployee.firstName;
                lastName.Text = saleEmployee.lastName;


                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickSales(sender1, e1, monthlyTextBox, grossTextBox, commissionTextBox, firstName, lastName, employeeId); };
            }
            else
            {
                Contract cEmployee = (Contract)employee;

                dropdown.SelectedIndex = (int)cEmployee.empType;
                Label empID = new Label();
                empID.Location = new Point(175, 10);
                mainPanel.Controls.Add(empID);
                empID.AutoSize = true;
                empID.BringToFront();
                empID.Text = "Employee ID: " + employeeId;

                TextBox contractWageText = new TextBox();
                contractWageText.Location = new Point(175, 65);
                mainPanel.Controls.Add(contractWageText);
                contractWageText.BringToFront();
                contractWageText.Text = cEmployee.contractWage.ToString();


                Label contractWageLabel = new Label();
                contractWageLabel.Location = new Point(175, 40);
                mainPanel.Controls.Add(contractWageLabel);
                contractWageLabel.BringToFront();
                contractWageLabel.Text = "Contract Wage*";

                firstName.Text = cEmployee.firstName;
                lastName.Text = cEmployee.lastName;




                Button SaveButton = new Button();
                SaveButton.Location = new Point(175, 275);
                mainPanel.Controls.Add(SaveButton);
                SaveButton.BringToFront();
                SaveButton.Text = "Save";
                SaveButton.Click += delegate (object sender1, EventArgs e1) { SaveButton_ClickContract(sender1, e1, contractWageText, firstName, lastName, employeeId); };

            }
        }
        private void SaveButton_ClickHourly(object sender, EventArgs e, TextBox hoursW, TextBox hourlyW, TextBox firstName, TextBox lastName, string empId)
        {

            if (BusinessRules.Instance.empData.ContainsKey(empId))
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }
                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double hoursWorked = Convert.ToDouble(hoursW.Text);
                    double emplTy = Convert.ToDouble(empType.Hourly);
                    double hourlyRate = Convert.ToDouble(hourlyW.Text);

                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;
                    hoursW.BackColor = Color.White;
                    hourlyW.BackColor = Color.White;


                    BusinessRules.Instance.UpdateEmployee(eId, emplTy, firstName.Text, fullName, lastName.Text, hourlyRate, hoursWorked);
                    MessageBox.Show(firstName.Text + " has been updated!");

                }
                catch (Exception ex)
                {
                    if (ex.Message == "Input string was not in a correct format.")
                    {

                        hoursW.BackColor = Color.Red;
                        hourlyW.BackColor = Color.Red;

                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Hourly Rate, and Hours worked should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        hoursW.BackColor = Color.White;
                        hourlyW.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */ex.Message);

                    }
                }


            }
            else
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }
                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double hoursWorked = Convert.ToDouble(hoursW.Text);
                    double emplTy = Convert.ToDouble(empType.Hourly);
                    double hourlyRate = Convert.ToDouble(hourlyW.Text);

                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;
                    hoursW.BackColor = Color.White;
                    hourlyW.BackColor = Color.White;

                    HourlyEmployee employee = new HourlyEmployee(eId, emplTy, firstName.Text, fullName, lastName.Text, "", "", "", false, hourlyRate, hoursWorked);
                    employeeList.Items.Add(employee.empId);

                    BusinessRules.Instance.AddEmployee(empId, employee);

                }
                catch (Exception ex)
                {
                    if (ex.Message == "Input string was not in a correct format.")
                    {

                        hoursW.BackColor = Color.Red;
                        hourlyW.BackColor = Color.Red;

                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Hourly Rate, and Hours worked should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        hoursW.BackColor = Color.White;
                        hourlyW.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */ex.Message);

                    }
                }

            }
        }


        private void SaveButton_ClickSales(object sender1, EventArgs e1, TextBox monthlyTextBox, TextBox grossTextBox, TextBox commissionTextBox, TextBox firstName, TextBox lastName, string empId)
        {
            if (BusinessRules.Instance.empData.ContainsKey(empId))
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }
                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double salary = Convert.ToDouble(monthlyTextBox.Text);
                    double emplTy = Convert.ToDouble(empType.Sales);
                    double com = Convert.ToDouble(commissionTextBox.Text);
                    double sales = Convert.ToDouble(grossTextBox.Text);

                    monthlyTextBox.BackColor = Color.White;
                    grossTextBox.BackColor = Color.White;
                    commissionTextBox.BackColor = Color.White;
                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;

                    BusinessRules.Instance.UpdateEmployee(eId, emplTy, firstName.Text, fullName, lastName.Text, salary, com, sales);
                    MessageBox.Show(firstName.Text + " has been updated!");
                }
                catch (Exception e)
                {
                    if (e.Message == "Input string was not in a correct format.")
                    {

                        monthlyTextBox.BackColor = Color.Red;
                        grossTextBox.BackColor = Color.Red;
                        commissionTextBox.BackColor = Color.Red;
                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;

                        MessageBox.Show("Monthly Salary, Gross Salary, and Commission should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        monthlyTextBox.BackColor = Color.White;
                        grossTextBox.BackColor = Color.White;
                        commissionTextBox.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */e.Message);

                    }
                }

            }
            else
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }
                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double salary = Convert.ToDouble(monthlyTextBox.Text);
                    double emplTy = Convert.ToDouble(empType.Sales);
                    double com = Convert.ToDouble(commissionTextBox.Text);
                    double sales = Convert.ToDouble(grossTextBox.Text);

                    monthlyTextBox.BackColor = Color.White;
                    grossTextBox.BackColor = Color.White;
                    commissionTextBox.BackColor = Color.White;
                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;

                    Sales employee = new Sales(eId, emplTy, firstName.Text, fullName, lastName.Text, "", "", "", false, salary, com, sales);
                    employeeList.Items.Add(employee.empId);

                    BusinessRules.Instance.AddEmployee(empId, employee);

                }
                catch (Exception e)
                {
                    if (e.Message == "Input string was not in a correct format.")
                    {

                        monthlyTextBox.BackColor = Color.Red;
                        grossTextBox.BackColor = Color.Red;
                        commissionTextBox.BackColor = Color.Red;
                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Monthly Salary, Gross Salary, and Commission should only contain numbers");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        monthlyTextBox.BackColor = Color.White;
                        grossTextBox.BackColor = Color.White;
                        commissionTextBox.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */e.Message);

                    }
                }

            }

        }

        private void SaveButton_ClickSalary(object sender1, EventArgs e1, TextBox monthlyTextBox, TextBox firstName, TextBox lastName, string empId)
        {
            if (BusinessRules.Instance.empData.ContainsKey(empId))
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }

                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double salary = Convert.ToDouble(monthlyTextBox.Text);
                    double emplTy = Convert.ToDouble(empType.Salary);

                    monthlyTextBox.BackColor = Color.White;
                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;

                    BusinessRules.Instance.UpdateEmployee(eId, emplTy, firstName.Text, fullName, lastName.Text, salary);
                    MessageBox.Show(firstName.Text + " has been updated!");
                }
                catch (Exception e)
                {
                    if (e.Message == "Input string was not in a correct format.")
                    {

                        monthlyTextBox.BackColor = Color.Red;
                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Monthly Salary should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        monthlyTextBox.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */e.Message);

                    }
                }
            }
            else
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }

                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double salary = Convert.ToDouble(monthlyTextBox.Text);
                    double emplTy = Convert.ToDouble(empType.Salary);

                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;
                    monthlyTextBox.BackColor = Color.White;

                    Salary employee = new Salary(eId, emplTy, firstName.Text, fullName, lastName.Text, "", "", "", false, salary);
                    employeeList.Items.Add(employee.empId);

                    BusinessRules.Instance.AddEmployee(empId, employee);
                }
                catch (Exception e)
                {
                    if (e.Message == "Input string was not in a correct format.")
                    {

                        monthlyTextBox.BackColor = Color.Red;
                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Monthly Salary should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        monthlyTextBox.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */e.Message);

                    }
                }
            }
        }
        private void SaveButton_ClickContract(object sender1, EventArgs e1, TextBox contractWageText, TextBox firstName, TextBox lastName, string empId)
        {
            if (BusinessRules.Instance.empData.ContainsKey(empId))
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }
                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double contractWage = Convert.ToDouble(contractWageText.Text);
                    double emplTy = Convert.ToDouble(empType.Contract);

                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;
                    contractWageText.BackColor = Color.White;

                    BusinessRules.Instance.UpdateEmployee(eId, emplTy, firstName.Text, fullName, lastName.Text, contractWage);
                    MessageBox.Show(firstName.Text + " has been updated!");
                }
                catch (Exception e)
                {

                    if (e.Message == "Input string was not in a correct format.")
                    {

                        contractWageText.BackColor = Color.Red;
                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Contract Wage should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        contractWageText.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */e.Message);

                    }
                }
            }
            else
            {
                try
                {

                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("First name should only contain letters");
                    }
                    if (Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$") == false)
                    {
                        throw new Exception("Last name should only contain letters");
                    }

                    string fullName = firstName.Text + " " + lastName.Text;
                    double eId = Convert.ToDouble(empId);
                    double contractWage = Convert.ToDouble(contractWageText.Text);
                    double emplTy = Convert.ToDouble(empType.Contract);

                    firstName.BackColor = Color.White;
                    lastName.BackColor = Color.White;
                    contractWageText.BackColor = Color.White;

                    Contract employee = new Contract(eId, emplTy, firstName.Text, fullName, lastName.Text, "", "", "", false, contractWage);
                    employeeList.Items.Add(employee.empId);

                    BusinessRules.Instance.AddEmployee(empId, employee);
                }
                catch (Exception e)
                {
                    if (e.Message == "Input string was not in a correct format.")
                    {

                        contractWageText.BackColor = Color.Red;
                        firstName.BackColor = Color.White;
                        lastName.BackColor = Color.White;
                        MessageBox.Show("Contract Wage should only contain numbers ");

                    }
                    else
                    {
                        firstName.BackColor = Color.Red;
                        lastName.BackColor = Color.Red;
                        contractWageText.BackColor = Color.White;
                        MessageBox.Show( /*"Contract should only contain numbers "+ Environment.NewLine + */e.Message);

                    }


                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var emp = BusinessRules.Instance.searchEmployee(searchBox.Text);
            if (emp == null)
            {
                searchBox.Text = "Must be ID, First or Last Name.";
                searchBox.ForeColor = Color.Red;
                //not found
            }
            else
            {
                searchBox.ForeColor = Color.Black;
                employeeList.SelectedItem = emp.empId;
            }
           
            //searchBox.Text
        }

        private void OpenFileDB_Click(object sender, EventArgs e)
        {
            FileIO.Instance.EmployeeDB = BusinessRules.Instance.empData;
            FileIO.Instance.OpenFileDB();
            FileIO.Instance.WriteDB();
        }

        private void SaveFileDB_Click(object sender, EventArgs e)
        {
            FileIO.Instance.EmployeeDB = BusinessRules.Instance.empData;
            FileIO.Instance.OpenFileDB();
            FileIO.Instance.ReadDB();
            FileIO.Instance.SaveFileDB();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(employeeList.SelectedIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete employee id:" + employeeList.SelectedItem.ToString(), "Delete Employee", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    var empToDelete = BusinessRules.Instance.empData[employeeList.SelectedItem.ToString()];

                    BusinessRules.Instance.deleteEmp(empToDelete);



                    employeeList.Items.RemoveAt(employeeList.SelectedIndex);
                }

            }
           
            
            
           
            
        }
        //make delete function in business rules so it has 2 sorted dictionaries deleted and not deleted
        private void showDeleted_Click(object sender, EventArgs e)
        {
            employeeList.BackColor = Color.Red;
            employeeList.Items.Clear();
            foreach(var item in BusinessRules.Instance.empDel)
            {
                employeeList.Items.Add(item.Value.empId.ToString());
            }
        }

        private void showEmployees_Click(object sender, EventArgs e)
        {
            employeeList.BackColor = Color.White;
            employeeList.Items.Clear();
            foreach (var item in BusinessRules.Instance.empData)
            {
                employeeList.Items.Add(item.Value.empId.ToString());

            }

        }
    }   
}
