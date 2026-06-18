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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            cboStatusFilter = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvApplicants = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            pnlDetails = new Panel();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            pnlActions = new Panel();
            btnRefresh = new Button();
            btnLockApplication = new Button();
            btnViewDocument = new Button();
            panel3 = new Panel();
            dgvDocuments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            panel2.SuspendLayout();
            pnlDetails.SuspendLayout();
            pnlActions.SuspendLayout();
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
            // NOTE: panel1 (Top) must be added before dgvApplicants (Fill)
            // so the grid correctly fills whatever space remains below it.
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(dgvApplicants);
            splitContainer1.Panel1MinSize = 280;
            //
            // splitContainer1.Panel2
            //
            splitContainer1.Panel2.BackColor = Color.SteelBlue;
            // NOTE: order matters for Dock layout - Top docks first, then
            // Bottom dock, then the Fill dock added LAST so it consumes
            // whatever space is left over.
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(pnlDetails);
            splitContainer1.Panel2.Controls.Add(pnlActions);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2MinSize = 480;
            splitContainer1.Size = new Size(1066, 987);
            splitContainer1.SplitterDistance = 360;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            //
            // panel1 (search / filter bar - left side)
            //
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(cboStatusFilter);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 149);
            panel1.TabIndex = 0;
            //
            // linkLabel1
            //
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
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
            cboStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Location = new Point(16, 60);
            cboStatusFilter.Margin = new Padding(5, 4, 5, 4);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(218, 28);
            cboStatusFilter.TabIndex = 4;
            //
            // btnSearch
            //
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Azure;
            btnSearch.Location = new Point(235, 17);
            btnSearch.Margin = new Padding(5, 4, 5, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            //
            // txtSearch
            //
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(16, 19);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 27);
            txtSearch.TabIndex = 2;
            //
            // dgvApplicants
            //
            dgvApplicants.BackgroundColor = SystemColors.Window;
            dgvApplicants.BorderStyle = BorderStyle.None;
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicants.Dock = DockStyle.Fill;
            dgvApplicants.Location = new Point(0, 149);
            dgvApplicants.Margin = new Padding(5, 4, 5, 4);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.Size = new Size(360, 838);
            dgvApplicants.TabIndex = 1;
            //
            // panel2 (header)
            //
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 90);
            panel2.TabIndex = 1;
            //
            // label5
            //
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(700, 90);
            label5.TabIndex = 0;
            label5.Text = "Applicant Review";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlDetails (Name / Email / Phone / Address)
            //
            pnlDetails.BackColor = Color.Azure;
            pnlDetails.Controls.Add(label1);
            pnlDetails.Controls.Add(txtName);
            pnlDetails.Controls.Add(label2);
            pnlDetails.Controls.Add(txtEmail);
            pnlDetails.Controls.Add(label3);
            pnlDetails.Controls.Add(txtPhone);
            pnlDetails.Controls.Add(label4);
            pnlDetails.Controls.Add(txtAddress);
            pnlDetails.Dock = DockStyle.Top;
            pnlDetails.Location = new Point(0, 90);
            pnlDetails.Margin = new Padding(5, 4, 5, 4);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(700, 290);
            pnlDetails.TabIndex = 2;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(32, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            //
            // txtName
            //
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(229, 14);
            txtName.Margin = new Padding(5, 4, 5, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(437, 27);
            txtName.TabIndex = 6;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(32, 78);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            //
            // txtEmail
            //
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(229, 74);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(437, 27);
            txtEmail.TabIndex = 7;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(32, 138);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 31);
            label3.TabIndex = 4;
            label3.Text = "Phone number:";
            //
            // txtPhone
            //
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(229, 134);
            txtPhone.Margin = new Padding(5, 4, 5, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(437, 27);
            txtPhone.TabIndex = 8;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(32, 198);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 5;
            label4.Text = "Address:";
            //
            // txtAddress
            //
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(229, 194);
            txtAddress.Margin = new Padding(5, 4, 5, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(437, 61);
            txtAddress.TabIndex = 9;
            //
            // pnlActions (Refresh / Start Review / View Document - kept centered in code)
            //
            pnlActions.BackColor = Color.SteelBlue;
            pnlActions.Controls.Add(btnRefresh);
            pnlActions.Controls.Add(btnLockApplication);
            pnlActions.Controls.Add(btnViewDocument);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 847);
            pnlActions.Margin = new Padding(5, 4, 5, 4);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(700, 70);
            pnlActions.TabIndex = 3;
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.MidnightBlue;
            btnRefresh.Font = new Font("Segoe UI", 10.2F);
            btnRefresh.ForeColor = Color.Azure;
            btnRefresh.Location = new Point(60, 14);
            btnRefresh.Margin = new Padding(5, 4, 5, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 42);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            //
            // btnLockApplication
            //
            btnLockApplication.BackColor = Color.MidnightBlue;
            btnLockApplication.Font = new Font("Segoe UI", 10.2F);
            btnLockApplication.ForeColor = Color.Azure;
            btnLockApplication.Location = new Point(189, 10);
            btnLockApplication.Margin = new Padding(5, 4, 5, 4);
            btnLockApplication.Name = "btnLockApplication";
            btnLockApplication.Size = new Size(270, 49);
            btnLockApplication.TabIndex = 12;
            btnLockApplication.Text = "Start Review";
            btnLockApplication.UseVisualStyleBackColor = false;
            //
            // btnViewDocument
            //
            btnViewDocument.BackColor = Color.MidnightBlue;
            btnViewDocument.Font = new Font("Segoe UI", 10.2F);
            btnViewDocument.ForeColor = Color.Azure;
            btnViewDocument.Location = new Point(479, 14);
            btnViewDocument.Name = "btnViewDocument";
            btnViewDocument.Size = new Size(167, 42);
            btnViewDocument.TabIndex = 11;
            btnViewDocument.Text = "View Document";
            btnViewDocument.UseVisualStyleBackColor = false;
            btnViewDocument.Click += btnViewDocument_Click;
            //
            // panel3 (documents grid container)
            //
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(dgvDocuments);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 380);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(14, 12, 14, 12);
            panel3.Size = new Size(700, 467);
            panel3.TabIndex = 10;
            //
            // dgvDocuments
            //
            dgvDocuments.BackgroundColor = SystemColors.Window;
            dgvDocuments.BorderStyle = BorderStyle.None;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Dock = DockStyle.Fill;
            dgvDocuments.Location = new Point(14, 12);
            dgvDocuments.Margin = new Padding(5, 4, 5, 4);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.Size = new Size(672, 443);
            dgvDocuments.TabIndex = 0;
            //
            // ApplicantReviewForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1066, 987);
            Controls.Add(splitContainer1);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(900, 700);
            Name = "ApplicantReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicantReviewForm";
            Load += ApplicantReviewForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            panel2.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            pnlActions.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlActions;
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
        private Label label5;
    }
}