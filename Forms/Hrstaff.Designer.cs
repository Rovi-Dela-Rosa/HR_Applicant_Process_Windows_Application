namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class Hrstaff
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
            panel2 = new Panel();
            label10 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            label14 = new Label();
            lblApplicantCount = new Label();
            lblTotalHired = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label10);
            panel2.Location = new Point(227, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 80);
            panel2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.ForeColor = Color.Azure;
            label10.Location = new Point(21, 25);
            label10.Name = "label10";
            label10.Size = new Size(141, 35);
            label10.TabIndex = 0;
            label10.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(0, 95);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 52);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "HR Staff";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 241);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 2;
            label4.Text = "Screening";
            label4.Click += Screening;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 288);
            label5.Name = "label5";
            label5.Size = new Size(196, 30);
            label5.TabIndex = 3;
            label5.Text = "Interview Schedule";
            label5.Click += InterviewSched;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 333);
            label6.Name = "label6";
            label6.Size = new Size(206, 30);
            label6.TabIndex = 4;
            label6.Text = "Interview Evaluation";
            label6.Click += InterviewEval;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 381);
            label7.Name = "label7";
            label7.Size = new Size(0, 30);
            label7.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(14, 555);
            label9.Name = "label9";
            label9.Size = new Size(81, 30);
            label9.TabIndex = 7;
            label9.Text = "Logout";
            label9.Click += Logout;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.SteelBlue;
            label11.Font = new Font("Segoe UI", 13F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(14, 105);
            label11.Name = "label11";
            label11.Size = new Size(118, 30);
            label11.TabIndex = 8;
            label11.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 601);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 196);
            label3.Name = "label3";
            label3.Size = new Size(177, 30);
            label3.TabIndex = 2;
            label3.Text = "Applicant Review";
            label3.Click += ApplicantReview;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 151);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 1;
            label2.Text = "Applicant List";
            label2.Click += ApplicantList;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(248, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(642, 125);
            panel4.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Azure;
            label13.Location = new Point(182, 75);
            label13.Name = "label13";
            label13.Size = new Size(271, 23);
            label13.TabIndex = 1;
            label13.Text = "Use the navigation menu to begin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Azure;
            label12.Location = new Point(182, 15);
            label12.Name = "label12";
            label12.Size = new Size(264, 38);
            label12.TabIndex = 0;
            label12.Text = "Welcome, HR Staff";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(248, 288);
            label8.Name = "label8";
            label8.Size = new Size(305, 38);
            label8.TabIndex = 2;
            label8.Text = "Applicant Registered: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(248, 355);
            label14.Name = "label14";
            label14.Size = new Size(239, 38);
            label14.TabIndex = 5;
            label14.Text = "Applicant Hired: ";
            // 
            // lblApplicantCount
            // 
            lblApplicantCount.AutoSize = true;
            lblApplicantCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicantCount.ForeColor = Color.MidnightBlue;
            lblApplicantCount.Location = new Point(531, 288);
            lblApplicantCount.Name = "lblApplicantCount";
            lblApplicantCount.Size = new Size(33, 38);
            lblApplicantCount.TabIndex = 6;
            lblApplicantCount.Text = "0";
            // 
            // lblTotalHired
            // 
            lblTotalHired.AutoSize = true;
            lblTotalHired.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHired.ForeColor = Color.MidnightBlue;
            lblTotalHired.Location = new Point(531, 355);
            lblTotalHired.Name = "lblTotalHired";
            lblTotalHired.Size = new Size(33, 38);
            lblTotalHired.TabIndex = 7;
            lblTotalHired.Text = "0";
            // 
            // Hrstaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(914, 600);
            Controls.Add(lblTotalHired);
            Controls.Add(lblApplicantCount);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Hrstaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Staff Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label10;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Panel panel1;
        private Panel panel4;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label lblApplicantCount;
        private Label lblTotalHired;
    }
}