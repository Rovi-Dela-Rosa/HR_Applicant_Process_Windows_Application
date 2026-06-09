namespace HR_Applicant_Process_Windows_System_MAIN
{ 
    partial class Report
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            tabReports = new TabControl();
            tabApplicants = new TabPage();
            dgvApplicants = new DataGridView();
            tabPending = new TabPage();
            dgvPending = new DataGridView();
            tabInterviews = new TabPage();
            dgvInterviews = new DataGridView();
            tabDecisions = new TabPage();
            dgvDecisions = new DataGridView();
            tabMissing = new TabPage();
            dgvMissing = new DataGridView();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            lblReportCount = new Label();
            tabReports.SuspendLayout();
            tabApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            tabPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            tabInterviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).BeginInit();
            tabDecisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDecisions).BeginInit();
            tabMissing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMissing).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(383, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports Module";
            lblTitle.Anchor = AnchorStyles.Top;

            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.SteelBlue;
            pnlToolbar.BorderStyle = BorderStyle.FixedSingle;
            pnlToolbar.Controls.Add(lblReportCount);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Location = new Point(27, 58);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(982, 44);
            pnlToolbar.TabIndex = 1;
            pnlToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.MidnightBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Azure;
            btnRefresh.Location = new Point(869, 7);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 28);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "↻  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // 
            // lblReportCount
            // 
            lblReportCount.AutoSize = true;
            lblReportCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReportCount.ForeColor = Color.Azure;
            lblReportCount.Location = new Point(10, 12);
            lblReportCount.Name = "lblReportCount";
            lblReportCount.Text = "Loading...";

            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabApplicants);
            tabReports.Controls.Add(tabPending);
            tabReports.Controls.Add(tabInterviews);
            tabReports.Controls.Add(tabDecisions);
            tabReports.Controls.Add(tabMissing);
            tabReports.Location = new Point(27, 112);
            tabReports.Name = "tabReports";
            tabReports.SelectedIndex = 0;
            tabReports.Size = new Size(982, 460);
            tabReports.TabIndex = 2;
            tabReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // 
            // tabApplicants
            // 
            tabApplicants.BackColor = Color.Azure;
            tabApplicants.Controls.Add(dgvApplicants);
            tabApplicants.Location = new Point(4, 29);
            tabApplicants.Name = "tabApplicants";
            tabApplicants.Padding = new Padding(6);
            tabApplicants.Size = new Size(974, 427);
            tabApplicants.TabIndex = 0;
            tabApplicants.Text = "Applicant List";

            // 
            // dgvApplicants
            // 
            dgvApplicants.AllowUserToAddRows = false;
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplicants.BackgroundColor = Color.Azure;
            dgvApplicants.BorderStyle = BorderStyle.None;
            dgvApplicants.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvApplicants.ColumnHeadersHeight = 32;
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvApplicants.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvApplicants.Dock = DockStyle.Fill;
            dgvApplicants.EnableHeadersVisualStyles = false;
            dgvApplicants.GridColor = Color.SteelBlue;
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.ReadOnly = true;
            dgvApplicants.RowHeadersVisible = false;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.TabIndex = 0;

            // 
            // tabPending
            // 
            tabPending.BackColor = Color.Azure;
            tabPending.Controls.Add(dgvPending);
            tabPending.Location = new Point(4, 29);
            tabPending.Name = "tabPending";
            tabPending.Padding = new Padding(6);
            tabPending.Size = new Size(974, 427);
            tabPending.TabIndex = 1;
            tabPending.Text = "   Pending Applications   ";

            // 
            // dgvPending
            // 
            dgvPending.AllowUserToAddRows = false;
            dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPending.BackgroundColor = Color.Azure;
            dgvPending.BorderStyle = BorderStyle.None;
            dgvPending.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvPending.ColumnHeadersHeight = 32;
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPending.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvPending.Dock = DockStyle.Fill;
            dgvPending.EnableHeadersVisualStyles = false;
            dgvPending.GridColor = Color.SteelBlue;
            dgvPending.Name = "dgvPending";
            dgvPending.ReadOnly = true;
            dgvPending.RowHeadersVisible = false;
            dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPending.TabIndex = 0;

            // 
            // tabInterviews
            // 
            tabInterviews.BackColor = Color.Azure;
            tabInterviews.Controls.Add(dgvInterviews);
            tabInterviews.Location = new Point(4, 29);
            tabInterviews.Name = "tabInterviews";
            tabInterviews.Padding = new Padding(6);
            tabInterviews.Size = new Size(974, 427);
            tabInterviews.TabIndex = 2;
            tabInterviews.Text = "   Interviews   ";

            // 
            // dgvInterviews
            // 
            dgvInterviews.AllowUserToAddRows = false;
            dgvInterviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInterviews.BackgroundColor = Color.Azure;
            dgvInterviews.BorderStyle = BorderStyle.None;
            dgvInterviews.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvInterviews.ColumnHeadersHeight = 32;
            dgvInterviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInterviews.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvInterviews.Dock = DockStyle.Fill;
            dgvInterviews.EnableHeadersVisualStyles = false;
            dgvInterviews.GridColor = Color.SteelBlue;
            dgvInterviews.Name = "dgvInterviews";
            dgvInterviews.ReadOnly = true;
            dgvInterviews.RowHeadersVisible = false;
            dgvInterviews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInterviews.TabIndex = 0;

            // 
            // tabDecisions
            // 
            tabDecisions.BackColor = Color.Azure;
            tabDecisions.Controls.Add(dgvDecisions);
            tabDecisions.Location = new Point(4, 29);
            tabDecisions.Name = "tabDecisions";
            tabDecisions.Padding = new Padding(6);
            tabDecisions.Size = new Size(974, 427);
            tabDecisions.TabIndex = 3;
            tabDecisions.Text = "   Accepted / Rejected   ";

            // 
            // dgvDecisions
            // 
            dgvDecisions.AllowUserToAddRows = false;
            dgvDecisions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDecisions.BackgroundColor = Color.Azure;
            dgvDecisions.BorderStyle = BorderStyle.None;
            dgvDecisions.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvDecisions.ColumnHeadersHeight = 32;
            dgvDecisions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDecisions.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvDecisions.Dock = DockStyle.Fill;
            dgvDecisions.EnableHeadersVisualStyles = false;
            dgvDecisions.GridColor = Color.SteelBlue;
            dgvDecisions.Name = "dgvDecisions";
            dgvDecisions.ReadOnly = true;
            dgvDecisions.RowHeadersVisible = false;
            dgvDecisions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDecisions.TabIndex = 0;

            // 
            // tabMissing
            // 
            tabMissing.BackColor = Color.Azure;
            tabMissing.Controls.Add(dgvMissing);
            tabMissing.Location = new Point(4, 29);
            tabMissing.Name = "tabMissing";
            tabMissing.Padding = new Padding(6);
            tabMissing.Size = new Size(974, 427);
            tabMissing.TabIndex = 4;
            tabMissing.Text = "   Missing Requirements   ";

            // 
            // dgvMissing
            // 
            dgvMissing.AllowUserToAddRows = false;
            dgvMissing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMissing.BackgroundColor = Color.Azure;
            dgvMissing.BorderStyle = BorderStyle.None;
            dgvMissing.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvMissing.ColumnHeadersHeight = 32;
            dgvMissing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMissing.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvMissing.Dock = DockStyle.Fill;
            dgvMissing.EnableHeadersVisualStyles = false;
            dgvMissing.GridColor = Color.SteelBlue;
            dgvMissing.Name = "dgvMissing";
            dgvMissing.ReadOnly = true;
            dgvMissing.RowHeadersVisible = false;
            dgvMissing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMissing.TabIndex = 0;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1036, 603);
            Controls.Add(tabReports);
            Controls.Add(pnlToolbar);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports Module";
            tabReports.ResumeLayout(false);
            tabApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            tabPending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            tabInterviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).EndInit();
            tabDecisions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDecisions).EndInit();
            tabMissing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMissing).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabReports;
        private TabPage tabApplicants;
        private DataGridView dgvApplicants;
        private TabPage tabPending;
        private DataGridView dgvPending;
        private TabPage tabInterviews;
        private DataGridView dgvInterviews;
        private TabPage tabDecisions;
        private DataGridView dgvDecisions;
        private TabPage tabMissing;
        private DataGridView dgvMissing;
        private Panel pnlToolbar;
        private Button btnRefresh;
        private Label lblReportCount;
    }
}
