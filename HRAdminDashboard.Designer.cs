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
            panel3.Location = new Point(0, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 39);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "HR Admin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 195);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 5;
            label7.Text = "Hiring Decisions";
            label7.Click += Hiredeci;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 238);
            label8.Name = "label8";
            label8.Size = new Size(73, 25);
            label8.TabIndex = 6;
            label8.Text = "Reports";
            label8.Click += Report;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 416);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 7;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.SteelBlue;
            label11.Font = new Font("Segoe UI", 13F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(12, 79);
            label11.Name = "label11";
            label11.Size = new Size(100, 25);
            label11.TabIndex = 8;
            label11.Text = "Dashboard";
            label11.Click += label11_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(11, 116);
            label12.Name = "label12";
            label12.Size = new Size(186, 25);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 451);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(11, 158);
            label10.Name = "label10";
            label10.Size = new Size(178, 25);
            label10.TabIndex = 11;
            label10.Text = "Maintenance Module";
            label10.Click += Maintenance;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
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
            panel2.Location = new Point(206, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 426);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(richTextBox5);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(richTextBox6);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(360, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 425);
            panel4.TabIndex = 11;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15F);
            label19.Location = new Point(52, 0);
            label19.Name = "label19";
            label19.Size = new Size(121, 28);
            label19.TabIndex = 14;
            label19.Text = "Change Role";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(3, 41);
            label20.Name = "label20";
            label20.Size = new Size(71, 19);
            label20.TabIndex = 15;
            label20.Text = "Username";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.Beige;
            richTextBox5.Location = new Point(3, 63);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(184, 35);
            richTextBox5.TabIndex = 16;
            richTextBox5.Text = "";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(-1, 104);
            label21.Name = "label21";
            label21.Size = new Size(123, 19);
            label21.TabIndex = 18;
            label21.Text = "1(Admin) | 2 (Staff)";
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = Color.Beige;
            richTextBox6.Location = new Point(3, 132);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(88, 35);
            richTextBox6.TabIndex = 19;
            richTextBox6.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.BurlyWood;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(65, 179);
            button2.Name = "button2";
            button2.Size = new Size(88, 41);
            button2.TabIndex = 17;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnChangeRole_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(87, 352);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAddHR_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F);
            label18.Location = new Point(18, 15);
            label18.Name = "label18";
            label18.Size = new Size(206, 28);
            label18.TabIndex = 9;
            label18.Text = "Enter new HR member";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(18, 265);
            label16.Name = "label16";
            label16.Size = new Size(127, 19);
            label16.TabIndex = 7;
            label16.Text = "1 (Admin) | 2 (Staff)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(18, 194);
            label15.Name = "label15";
            label15.Size = new Size(67, 19);
            label15.TabIndex = 6;
            label15.Text = "Password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(18, 136);
            label14.Name = "label14";
            label14.Size = new Size(41, 19);
            label14.TabIndex = 5;
            label14.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(18, 67);
            label13.Name = "label13";
            label13.Size = new Size(71, 19);
            label13.TabIndex = 4;
            label13.Text = "Username";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.Beige;
            richTextBox4.Location = new Point(18, 297);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(50, 33);
            richTextBox4.TabIndex = 3;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Beige;
            richTextBox3.Location = new Point(18, 217);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(175, 33);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Beige;
            richTextBox2.Location = new Point(18, 158);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(175, 33);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Beige;
            richTextBox1.Location = new Point(18, 93);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(175, 33);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // HRAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HRAdminDashboard";
            Text = "Form1";
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
        private Label label3;
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
    }
}