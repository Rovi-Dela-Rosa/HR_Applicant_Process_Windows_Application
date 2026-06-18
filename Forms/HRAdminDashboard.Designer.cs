namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class HRAdminDashboard
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
            panel3 = new Panel();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            lblTotalHired = new Label();
            lblApplicantCount = new Label();
            label2 = new Label();
            label4 = new Label();
            label19 = new Label();
            label20 = new Label();
            richTextBox5 = new RichTextBox();
            label21 = new Label();
            richTextBox6 = new RichTextBox();
            button2 = new Button();
            button1 = new Button();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.ForeColor = Color.Azure;
            panel3.Location = new Point(0, 95);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 52);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(135, 35);
            label1.TabIndex = 0;
            label1.Text = "HR Admin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.Azure;
            label7.Location = new Point(14, 260);
            label7.Name = "label7";
            label7.Size = new Size(168, 30);
            label7.TabIndex = 5;
            label7.Text = "Hiring Decisions";
            label7.Click += Hiredeci;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.ForeColor = Color.Azure;
            label8.Location = new Point(14, 317);
            label8.Name = "label8";
            label8.Size = new Size(87, 30);
            label8.TabIndex = 6;
            label8.Text = "Reports";
            label8.Click += Report;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.ForeColor = Color.Azure;
            label9.Location = new Point(14, 555);
            label9.Name = "label9";
            label9.Size = new Size(81, 30);
            label9.TabIndex = 7;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.SteelBlue;
            label11.Font = new Font("Segoe UI", 13F);
            label11.ForeColor = Color.Azure;
            label11.Location = new Point(14, 105);
            label11.Name = "label11";
            label11.Size = new Size(118, 30);
            label11.TabIndex = 8;
            label11.Text = "Dashboard";
            label11.Click += label11_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F);
            label12.ForeColor = Color.Azure;
            label12.Location = new Point(13, 155);
            label12.Name = "label12";
            label12.Size = new Size(226, 30);
            label12.TabIndex = 10;
            label12.Text = "Manage job vacancies";
            label12.Click += JobVacant;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 601);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.ForeColor = Color.Azure;
            label10.Location = new Point(13, 211);
            label10.Name = "label10";
            label10.Size = new Size(218, 30);
            label10.TabIndex = 11;
            label10.Text = "Maintenance Module";
            label10.Click += Maintenance;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(richTextBox4);
            panel2.Controls.Add(richTextBox3);
            panel2.Controls.Add(richTextBox2);
            panel2.Controls.Add(richTextBox1);
            panel2.Location = new Point(237, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 569);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTotalHired);
            panel4.Controls.Add(lblApplicantCount);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(richTextBox5);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(richTextBox6);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(411, 3);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 566);
            panel4.TabIndex = 11;
            // 
            // lblTotalHired
            // 
            lblTotalHired.AutoSize = true;
            lblTotalHired.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTotalHired.ForeColor = Color.Azure;
            lblTotalHired.Location = new Point(3, 507);
            lblTotalHired.Name = "lblTotalHired";
            lblTotalHired.Size = new Size(28, 32);
            lblTotalHired.TabIndex = 22;
            lblTotalHired.Text = "0";
            // 
            // lblApplicantCount
            // 
            lblApplicantCount.AutoSize = true;
            lblApplicantCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblApplicantCount.ForeColor = Color.Azure;
            lblApplicantCount.Location = new Point(3, 432);
            lblApplicantCount.Name = "lblApplicantCount";
            lblApplicantCount.Size = new Size(28, 32);
            lblApplicantCount.TabIndex = 21;
            lblApplicantCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(-1, 473);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 21;
            label2.Text = "Applicant Hired";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(-1, 385);
            label4.Name = "label4";
            label4.Size = new Size(252, 32);
            label4.TabIndex = 20;
            label4.Text = "Applicant Registered";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15F);
            label19.ForeColor = Color.Azure;
            label19.Location = new Point(59, 0);
            label19.Name = "label19";
            label19.Size = new Size(154, 35);
            label19.TabIndex = 14;
            label19.Text = "Change Role";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.ForeColor = Color.Azure;
            label20.Location = new Point(3, 55);
            label20.Name = "label20";
            label20.Size = new Size(87, 23);
            label20.TabIndex = 15;
            label20.Text = "Username";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = SystemColors.Window;
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Location = new Point(3, 84);
            richTextBox5.Margin = new Padding(3, 4, 3, 4);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(210, 45);
            richTextBox5.TabIndex = 16;
            richTextBox5.Text = "";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.ForeColor = Color.Azure;
            label21.Location = new Point(-1, 139);
            label21.Name = "label21";
            label21.Size = new Size(150, 23);
            label21.TabIndex = 18;
            label21.Text = "1(Admin) | 2 (Staff)";
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = SystemColors.Window;
            richTextBox6.BorderStyle = BorderStyle.None;
            richTextBox6.Location = new Point(3, 176);
            richTextBox6.Margin = new Padding(3, 4, 3, 4);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(210, 45);
            richTextBox6.TabIndex = 19;
            richTextBox6.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(74, 239);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 55);
            button2.TabIndex = 17;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnChangeRole_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(99, 469);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 55);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAddHR_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F);
            label18.ForeColor = Color.Azure;
            label18.Location = new Point(21, 20);
            label18.Name = "label18";
            label18.Size = new Size(265, 35);
            label18.TabIndex = 9;
            label18.Text = "Enter new HR member";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.ForeColor = Color.Azure;
            label16.Location = new Point(21, 353);
            label16.Name = "label16";
            label16.Size = new Size(155, 23);
            label16.TabIndex = 7;
            label16.Text = "1 (Admin) | 2 (Staff)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.ForeColor = Color.Azure;
            label15.Location = new Point(21, 259);
            label15.Name = "label15";
            label15.Size = new Size(80, 23);
            label15.TabIndex = 6;
            label15.Text = "Password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.ForeColor = Color.Azure;
            label14.Location = new Point(21, 181);
            label14.Name = "label14";
            label14.Size = new Size(51, 23);
            label14.TabIndex = 5;
            label14.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.ForeColor = Color.Azure;
            label13.Location = new Point(21, 89);
            label13.Name = "label13";
            label13.Size = new Size(87, 23);
            label13.TabIndex = 4;
            label13.Text = "Username";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = SystemColors.Window;
            richTextBox4.Location = new Point(21, 396);
            richTextBox4.Margin = new Padding(3, 4, 3, 4);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(199, 43);
            richTextBox4.TabIndex = 3;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.Window;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(21, 289);
            richTextBox3.Margin = new Padding(3, 4, 3, 4);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(199, 43);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Window;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(21, 211);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(199, 43);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(21, 124);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(199, 43);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // HRAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HRAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Admin Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label lblApplicantCount;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label18;
        private Button button1;
        private Panel panel4;
        private Label label19;
        private Label label20;
        private RichTextBox richTextBox5;
        private Label label21;
        private RichTextBox richTextBox6;
        private Button button2;
        private Label label10;
        private Label label4;
        private Label lblTotalHired;
    }
}