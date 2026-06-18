namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class HRLogin
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
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            linkLabel2 = new LinkLabel();
            HRsigninbtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(HRsigninbtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(349, 167);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.MaximumSize = new Size(1371, 933);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 473);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(290, 429);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Change Password";
            linkLabel1.Click += Changepass;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 300);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 1;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DodgerBlue;
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.MidnightBlue;
            linkLabel2.LinkColor = Color.MidnightBlue;
            linkLabel2.Location = new Point(24, 27);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(66, 20);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<-- Back";
            linkLabel2.Click += Back;
            // 
            // HRsigninbtn
            // 
            HRsigninbtn.Anchor = AnchorStyles.None;
            HRsigninbtn.BackColor = Color.MidnightBlue;
            HRsigninbtn.Font = new Font("Segoe UI", 15F);
            HRsigninbtn.ForeColor = Color.Azure;
            HRsigninbtn.Location = new Point(139, 356);
            HRsigninbtn.Margin = new Padding(3, 4, 3, 4);
            HRsigninbtn.MaximumSize = new Size(1371, 933);
            HRsigninbtn.Name = "HRsigninbtn";
            HRsigninbtn.Size = new Size(158, 51);
            HRsigninbtn.TabIndex = 7;
            HRsigninbtn.Text = "Sign In";
            HRsigninbtn.TextAlign = ContentAlignment.TopCenter;
            HRsigninbtn.UseVisualStyleBackColor = false;
            HRsigninbtn.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(78, 196);
            label4.MaximumSize = new Size(1371, 933);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(78, 272);
            label3.MaximumSize = new Size(1371, 933);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(78, 123);
            label2.MaximumSize = new Size(1371, 933);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.None;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(78, 225);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.MaximumSize = new Size(1371, 932);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(285, 29);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(78, 152);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.MaximumSize = new Size(1371, 932);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 29);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(139, 39);
            label1.MaximumSize = new Size(1371, 933);
            label1.Name = "label1";
            label1.Size = new Size(170, 56);
            label1.TabIndex = 0;
            label1.Text = "HR Log-in";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkGray;
            button1.Location = new Point(339, 300);
            button1.Name = "button1";
            button1.Size = new Size(24, 25);
            button1.TabIndex = 2;
            button1.Text = "👁";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HRLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1155, 749);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HRLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Log In";
            Click += btnLogin_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label3;
        private Button HRsigninbtn;
        private Label label4;
        private Label label2;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private Button button1;
    }
}