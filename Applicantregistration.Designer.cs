namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class Applicantregistration
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
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(261, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 384);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button2.Location = new Point(124, 248);
            button2.Name = "button2";
            button2.Size = new Size(175, 35);
            button2.TabIndex = 6;
            button2.Text = "Register Now";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(78, 195);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(78, 139);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(78, 78);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(78, 217);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(279, 25);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(78, 161);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(279, 25);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(78, 100);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(279, 25);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(78, 22);
            label1.Name = "label1";
            label1.Size = new Size(279, 37);
            label1.TabIndex = 0;
            label1.Text = "Applicant Registration";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(19, 12);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(53, 15);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<-- Back";
            linkLabel2.Click += Back;
            // 
            // Applicantregistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(891, 487);
            Controls.Add(panel1);
            Name = "Applicantregistration";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label1;
        private LinkLabel linkLabel2;
    }
}