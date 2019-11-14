using System;

namespace lab1phase1v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.employeeList = new System.Windows.Forms.ListBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.OpenFileDB = new System.Windows.Forms.Button();
            this.SaveFileDB = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.showDeleted = new System.Windows.Forms.Button();
            this.showEmployees = new System.Windows.Forms.Button();
            this.AddClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(23, 28);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(174, 55);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add New Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Location = new System.Drawing.Point(23, 128);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(174, 277);
            this.employeeList.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(221, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(567, 393);
            this.mainPanel.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(149, 98);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(48, 24);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(23, 89);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(120, 33);
            this.searchBox.TabIndex = 4;
            // 
            // OpenFileDB
            // 
            this.OpenFileDB.Location = new System.Drawing.Point(12, 0);
            this.OpenFileDB.Name = "OpenFileDB";
            this.OpenFileDB.Size = new System.Drawing.Size(86, 23);
            this.OpenFileDB.TabIndex = 5;
            this.OpenFileDB.Text = "Open File DB";
            this.OpenFileDB.UseVisualStyleBackColor = true;
            this.OpenFileDB.Click += new System.EventHandler(this.OpenFileDB_Click);
            // 
            // SaveFileDB
            // 
            this.SaveFileDB.Location = new System.Drawing.Point(122, 0);
            this.SaveFileDB.Name = "SaveFileDB";
            this.SaveFileDB.Size = new System.Drawing.Size(93, 23);
            this.SaveFileDB.TabIndex = 6;
            this.SaveFileDB.Text = "Save File DB";
            this.SaveFileDB.UseVisualStyleBackColor = true;
            this.SaveFileDB.Click += new System.EventHandler(this.SaveFileDB_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(57, 35);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete Employee";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // showDeleted
            // 
            this.showDeleted.Location = new System.Drawing.Point(75, 415);
            this.showDeleted.Name = "showDeleted";
            this.showDeleted.Size = new System.Drawing.Size(57, 35);
            this.showDeleted.TabIndex = 8;
            this.showDeleted.Text = "Show Deleted";
            this.showDeleted.UseVisualStyleBackColor = true;
            this.showDeleted.Click += new System.EventHandler(this.showDeleted_Click);
            // 
            // showEmployees
            // 
            this.showEmployees.Location = new System.Drawing.Point(138, 415);
            this.showEmployees.Name = "showEmployees";
            this.showEmployees.Size = new System.Drawing.Size(77, 35);
            this.showEmployees.TabIndex = 9;
            this.showEmployees.Text = "Show Employees";
            this.showEmployees.UseVisualStyleBackColor = true;
            this.showEmployees.Click += new System.EventHandler(this.showEmployees_Click);
            // 
            // AddClasses
            // 
            this.AddClasses.Location = new System.Drawing.Point(386, 421);
            this.AddClasses.Name = "AddClasses";
            this.AddClasses.Size = new System.Drawing.Size(193, 23);
            this.AddClasses.TabIndex = 10;
            this.AddClasses.Text = "Add Classes To Employee";
            this.AddClasses.UseVisualStyleBackColor = true;
            this.AddClasses.Click += new System.EventHandler(this.AddClasses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddClasses);
            this.Controls.Add(this.showEmployees);
            this.Controls.Add(this.showDeleted);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.SaveFileDB);
            this.Controls.Add(this.OpenFileDB);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.ListBox employeeList;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button OpenFileDB;
        private System.Windows.Forms.Button SaveFileDB;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button showDeleted;
        private System.Windows.Forms.Button showEmployees;
        private System.Windows.Forms.Button AddClasses;
    }
}

