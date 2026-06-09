namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class HrChangePass
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
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(187, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 515);
            panel1.TabIndex = 3;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(18, 17);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(53, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<-- Back";
            linkLabel2.Click += Back;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(286, 287);
            button1.Name = "button1";
            button1.Size = new Size(138, 38);
            button1.TabIndex = 7;
            button1.Text = "Sign In";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnChangePassword_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(227, 227);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(227, 169);
            label2.Name = "label2";
            label2.Size = new Size(207, 19);
            label2.TabIndex = 4;
            label2.Text = "Username or email to change password";
            // 
            // richTextBox3
            // 
            richTextBox3.Anchor = AnchorStyles.None;
            richTextBox3.Location = new Point(227, 249);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(250, 23);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Location = new Point(227, 191);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(250, 23);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(227, 33);
            label1.Name = "label1";
            label1.Size = new Size(250, 82);
            label1.TabIndex = 0;
            label1.Text = "Change Password (HR)";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // HrChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1017, 632);
            Controls.Add(panel1);
            Name = "HrChangePass";
            Text = "Form1";
            Click += btnChangePassword_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel2;
        private Button button1;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}