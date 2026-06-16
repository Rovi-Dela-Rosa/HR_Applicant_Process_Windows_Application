namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class ApplicantReviewForm
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
            splitContainer1 = new SplitContainer();
            dgvApplicants = new DataGridView();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            cboStatusFilter = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnViewDocument = new Button();
            btnLockApplication = new Button();
            btnRefresh = new Button();
            panel3 = new Panel();
            dgvDocuments = new DataGridView();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Azure;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5, 4, 5, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.MediumBlue;
            splitContainer1.Panel1.Controls.Add(dgvApplicants);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.MidnightBlue;
            splitContainer1.Panel2.Controls.Add(btnViewDocument);
            splitContainer1.Panel2.Controls.Add(btnLockApplication);
            splitContainer1.Panel2.Controls.Add(btnRefresh);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(txtAddress);
            splitContainer1.Panel2.Controls.Add(txtPhone);
            splitContainer1.Panel2.Controls.Add(txtEmail);
            splitContainer1.Panel2.Controls.Add(txtName);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1066, 987);
            splitContainer1.SplitterDistance = 354;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // dgvApplicants
            // 
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicants.Location = new Point(0, 149);
            dgvApplicants.Margin = new Padding(5, 4, 5, 4);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.Size = new Size(367, 837);
            dgvApplicants.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(cboStatusFilter);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 149);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(16, 108);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += Back;
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Items.AddRange(new object[] { "All", "", "Submitted", "", "Under Review", "", "Approved", "", "Rejected", "", "Locked" });
            cboStatusFilter.Location = new Point(16, 60);
            cboStatusFilter.Margin = new Padding(5, 4, 5, 4);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(218, 28);
            cboStatusFilter.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(242, 17);
            btnSearch.Margin = new Padding(5, 4, 5, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 19);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(218, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnViewDocument
            // 
            btnViewDocument.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnViewDocument.Location = new Point(484, 838);
            btnViewDocument.Name = "btnViewDocument";
            btnViewDocument.Size = new Size(167, 42);
            btnViewDocument.TabIndex = 11;
            btnViewDocument.Text = "View Document";
            btnViewDocument.UseVisualStyleBackColor = true;
            btnViewDocument.Click += btnViewDocument_Click;
            // 
            // btnLockApplication
            // 
            btnLockApplication.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLockApplication.Location = new Point(197, 835);
            btnLockApplication.Margin = new Padding(5, 4, 5, 4);
            btnLockApplication.Name = "btnLockApplication";
            btnLockApplication.Size = new Size(270, 49);
            btnLockApplication.TabIndex = 12;
            btnLockApplication.Text = "Start Review";
            btnLockApplication.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(78, 838);
            btnRefresh.Margin = new Padding(5, 4, 5, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 42);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(dgvDocuments);
            panel3.Location = new Point(1, 524);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 280);
            panel3.TabIndex = 10;
            // 
            // dgvDocuments
            // 
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Location = new Point(14, 27);
            dgvDocuments.Margin = new Padding(5, 4, 5, 4);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.Size = new Size(677, 231);
            dgvDocuments.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(229, 407);
            txtAddress.Margin = new Padding(5, 4, 5, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(356, 61);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(229, 352);
            txtPhone.Margin = new Padding(5, 4, 5, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(356, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 291);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(229, 227);
            txtName.Margin = new Padding(5, 4, 5, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 27);
            txtName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(32, 404);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 5;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(32, 351);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 24);
            label3.TabIndex = 4;
            label3.Text = "Phone number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(32, 291);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(32, 231);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(-6, 0);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 149);
            panel2.TabIndex = 1;
            // 
            // ApplicantReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1066, 987);
            Controls.Add(splitContainer1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ApplicantReviewForm";
            Text = "ApplicantReviewForm";
            Load += ApplicantReviewForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLockApplication;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private LinkLabel linkLabel1;
        private Button btnViewDocument;
    }
}