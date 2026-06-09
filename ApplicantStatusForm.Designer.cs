namespace HR_Applicant_Process_Windows_System_MAIN.Forms
{
    partial class ApplicationStatusForm
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
            label1 = new Label();
            dgvStatusHistory = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStatusHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(284, 29);
            label1.Name = "label1";
            label1.Size = new Size(389, 41);
            label1.TabIndex = 0;
            label1.Text = "Your Application TimeLine";
            // 
            // dgvStatusHistory
            // 
            dgvStatusHistory.AllowUserToDeleteRows = false;
            dgvStatusHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatusHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatusHistory.Location = new Point(50, 125);
            dgvStatusHistory.Name = "dgvStatusHistory";
            dgvStatusHistory.ReadOnly = true;
            dgvStatusHistory.RowHeadersWidth = 51;
            dgvStatusHistory.Size = new Size(874, 405);
            dgvStatusHistory.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MidnightBlue;
            btnBack.Font = new Font("Segoe UI", 7F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(64, 43);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 28);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // ApplicationStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(982, 653);
            Controls.Add(btnBack);
            Controls.Add(dgvStatusHistory);
            Controls.Add(label1);
            Name = "ApplicationStatusForm";
            Text = "Application Status";
            ((System.ComponentModel.ISupportInitialize)dgvStatusHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvStatusHistory;
        private Button btnBack;
    }
}