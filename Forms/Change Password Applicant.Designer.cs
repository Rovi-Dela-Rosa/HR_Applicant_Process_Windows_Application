namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class Changepassaplicant
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
            textBox1 = new TextBox();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(386, 134);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 595);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.DarkGray;
            button2.Location = new Point(389, 275);
            button2.Name = "button2";
            button2.Size = new Size(27, 27);
            button2.TabIndex = 11;
            button2.Text = "👁";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 10;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DodgerBlue;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.SteelBlue;
            linkLabel2.DisabledLinkColor = Color.MidnightBlue;
            linkLabel2.LinkColor = Color.MidnightBlue;
            linkLabel2.Location = new Point(21, 23);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(66, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<-- Back";
            linkLabel2.Click += Back;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(199, 335);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 51);
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
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(131, 247);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 5;
            label3.Text = "Enter new password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(131, 166);
            label2.Name = "label2";
            label2.Size = new Size(237, 25);
            label2.TabIndex = 4;
            label2.Text = "Username or email to change password";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(131, 195);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 29);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(301, 109);
            label1.TabIndex = 0;
            label1.Text = "Change Password (Applicant)";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Changepassaplicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1251, 889);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Changepassaplicant";
            StartPosition = FormStartPosition.CenterScreen;
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
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
    }
}