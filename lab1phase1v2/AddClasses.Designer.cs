namespace lab1phase1v2
{
    partial class AddClasses
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.TextBox();
            this.classesList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addClassButton = new System.Windows.Forms.Button();
            this.CourseDescription = new System.Windows.Forms.TextBox();
            this.CourseGrade = new System.Windows.Forms.TextBox();
            this.ApprovedDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreditHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(223, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(120, 20);
            this.searchBox.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(349, 13);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 20);
            this.search.TabIndex = 1;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search employee ID/Name to add classes!";
            // 
            // CourseID
            // 
            this.CourseID.Location = new System.Drawing.Point(100, 187);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(120, 20);
            this.CourseID.TabIndex = 3;
            // 
            // classesList
            // 
            this.classesList.FormattingEnabled = true;
            this.classesList.Location = new System.Drawing.Point(194, 59);
            this.classesList.Name = "classesList";
            this.classesList.Size = new System.Drawing.Size(201, 95);
            this.classesList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type the class to add!";
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(336, 254);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(104, 20);
            this.addClassButton.TabIndex = 6;
            this.addClassButton.Text = "Add Classes!";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // CourseDescription
            // 
            this.CourseDescription.Location = new System.Drawing.Point(100, 217);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(120, 20);
            this.CourseDescription.TabIndex = 7;
            // 
            // CourseGrade
            // 
            this.CourseGrade.Location = new System.Drawing.Point(349, 216);
            this.CourseGrade.Name = "CourseGrade";
            this.CourseGrade.Size = new System.Drawing.Size(91, 20);
            this.CourseGrade.TabIndex = 8;
            // 
            // ApprovedDate
            // 
            this.ApprovedDate.Location = new System.Drawing.Point(83, 247);
            this.ApprovedDate.Name = "ApprovedDate";
            this.ApprovedDate.Size = new System.Drawing.Size(120, 20);
            this.ApprovedDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "UVU Course ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Course Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course Grade (ex. 3.0)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Approved Date";
            // 
            // CreditHours
            // 
            this.CreditHours.Location = new System.Drawing.Point(324, 187);
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.Size = new System.Drawing.Size(100, 20);
            this.CreditHours.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Credit Hours ";
            // 
            // AddClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 319);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreditHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApprovedDate);
            this.Controls.Add(this.CourseGrade);
            this.Controls.Add(this.CourseDescription);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classesList);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchBox);
            this.Name = "AddClasses";
            this.Text = "AddClasses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CourseID;
        private System.Windows.Forms.ListBox classesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.TextBox CourseDescription;
        private System.Windows.Forms.TextBox CourseGrade;
        private System.Windows.Forms.TextBox ApprovedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreditHours;
        private System.Windows.Forms.Label label7;
    }
}