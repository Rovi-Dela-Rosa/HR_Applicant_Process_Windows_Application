namespace HR_Recruitment_System
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
            HRsigninbtn = new Button();
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
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(HRsigninbtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(305, 125);
            panel1.MaximumSize = new Size(1200, 700);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 355);
            panel1.TabIndex = 0;
            // 
            // HRsigninbtn
            // 
            HRsigninbtn.Anchor = AnchorStyles.None;
            HRsigninbtn.BackColor = Color.Red;
            HRsigninbtn.Font = new Font("Segoe UI", 15F);
            HRsigninbtn.Location = new Point(122, 255);
            HRsigninbtn.MaximumSize = new Size(1200, 700);
            HRsigninbtn.Name = "HRsigninbtn";
            HRsigninbtn.Size = new Size(138, 38);
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
            label4.Location = new Point(68, 147);
            label4.MaximumSize = new Size(1200, 700);
            label4.Name = "label4";
            label4.Size = new Size(138, 19);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(68, 204);
            label3.MaximumSize = new Size(1200, 700);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(68, 92);
            label2.MaximumSize = new Size(1200, 700);
            label2.Name = "label2";
            label2.Size = new Size(138, 19);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // richTextBox3
            // 
            richTextBox3.Anchor = AnchorStyles.None;
            richTextBox3.Location = new Point(68, 226);
            richTextBox3.MaximumSize = new Size(1200, 700);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(250, 23);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.None;
            richTextBox2.Location = new Point(68, 169);
            richTextBox2.MaximumSize = new Size(1200, 700);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(250, 23);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Location = new Point(68, 114);
            richTextBox1.MaximumSize = new Size(1200, 700);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(250, 23);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(122, 20);
            label1.MaximumSize = new Size(1200, 700);
            label1.Name = "label1";
            label1.Size = new Size(138, 42);
            label1.TabIndex = 0;
            label1.Text = "HR Log-In";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(21, 20);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(53, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<-- Back";
            linkLabel2.Click += Back;
            // 
            // HRLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1011, 633);
            Controls.Add(panel1);
            Name = "HRLogin";
            Text = "Form1";
            Click += btnLogin_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label3;
        private Button HRsigninbtn;
        private Label label4;
        private Label label2;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel2;
    }
}