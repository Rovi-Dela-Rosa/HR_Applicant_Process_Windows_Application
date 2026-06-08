namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class ApplicantLogin
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
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(238, 64);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 473);
            panel1.TabIndex = 1;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.None;
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(21, 436);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(126, 20);
            linkLabel3.TabIndex = 10;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Change password";
            linkLabel3.Click += Changepassapli;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(21, 23);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(66, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<-- Back";
            linkLabel2.Click += Back;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(334, 436);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Now";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(139, 340);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 51);
            button1.TabIndex = 7;
            button1.Text = "Sign In";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(78, 196);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(78, 272);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(78, 123);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // richTextBox3
            // 
            richTextBox3.Anchor = AnchorStyles.None;
            richTextBox3.Location = new Point(78, 301);
            richTextBox3.Margin = new Padding(3, 4, 3, 4);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(285, 29);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.None;
            richTextBox2.Location = new Point(78, 225);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(285, 29);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Location = new Point(78, 152);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 29);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(78, 43);
            label1.Name = "label1";
            label1.Size = new Size(286, 56);
            label1.TabIndex = 0;
            label1.Text = "Applicant Log-In";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ApplicantLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicantLogin";
            Text = "Applicant Log In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
    }
}