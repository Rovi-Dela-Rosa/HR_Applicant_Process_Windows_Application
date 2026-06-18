namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class Choice
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 120;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 30F);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(120, 81);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(338, 396);
            button1.TabIndex = 0;
            button1.Text = "HR Admin/Staff";
            button1.UseVisualStyleBackColor = false;
            button1.Click += HR;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 120;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 30F);
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(501, 81);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(338, 396);
            button2.TabIndex = 1;
            button2.Text = "Applicant";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Applicant;
            // 
            // Choice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(961, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Choice";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}