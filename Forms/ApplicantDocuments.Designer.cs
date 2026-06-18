namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class ApplicantDocuments
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
            cboDocumentType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnUpload = new Button();
            btnRefresh = new Button();
            label3 = new Label();
            lblStatus = new Label();
            dgvDocuments = new DataGridView();
            label4 = new Label();
            txtRemarks = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnDelete = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // cboDocumentType
            // 
            cboDocumentType.FormattingEnabled = true;
            cboDocumentType.Items.AddRange(new object[] { "Resume", "Valid ID", "Transcript", "Certificate" });
            cboDocumentType.Location = new Point(188, 154);
            cboDocumentType.Margin = new Padding(4, 5, 4, 5);
            cboDocumentType.Name = "cboDocumentType";
            cboDocumentType.Size = new Size(160, 28);
            cboDocumentType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 155);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 1;
            label1.Text = "Document type:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(359, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(352, 38);
            label2.TabIndex = 2;
            label2.Text = "APPLICANT DOCUMENTS";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 97);
            panel1.TabIndex = 3;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.MidnightBlue;
            btnUpload.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.Azure;
            btnUpload.Location = new Point(467, 136);
            btnUpload.Margin = new Padding(4, 5, 4, 5);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(113, 58);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.MidnightBlue;
            btnRefresh.Font = new Font("Segoe UI", 10.2F);
            btnRefresh.ForeColor = Color.Azure;
            btnRefresh.Location = new Point(729, 136);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 58);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(28, 262);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 6;
            label3.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblStatus.Location = new Point(184, 262);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(76, 23);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Missing:";
            // 
            // dgvDocuments
            // 
            dgvDocuments.BackgroundColor = Color.Azure;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.GridColor = Color.Azure;
            dgvDocuments.Location = new Point(28, 339);
            dgvDocuments.Margin = new Padding(4, 5, 4, 5);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.Size = new Size(983, 368);
            dgvDocuments.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 780);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 9;
            label4.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.BackColor = Color.GhostWhite;
            txtRemarks.BorderStyle = BorderStyle.None;
            txtRemarks.Location = new Point(125, 777);
            txtRemarks.Margin = new Padding(4, 5, 4, 5);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(880, 259);
            txtRemarks.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MidnightBlue;
            btnDelete.Font = new Font("Segoe UI", 10.2F);
            btnDelete.ForeColor = Color.Azure;
            btnDelete.Location = new Point(598, 136);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 58);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MidnightBlue;
            btnBack.Font = new Font("Segoe UI", 10.2F);
            btnBack.ForeColor = Color.Azure;
            btnBack.Location = new Point(862, 136);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 58);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ApplicantDocuments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1057, 1055);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(txtRemarks);
            Controls.Add(label4);
            Controls.Add(dgvDocuments);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpload);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cboDocumentType);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ApplicantDocuments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant Documents";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDocumentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDelete;
        private Button btnBack;
    }
}

