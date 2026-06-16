namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class HireDecision
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblFinalHiringDecisionTitle = new Label();
            pnlForm = new Panel();
            lblApplication = new Label();
            cmbApplication = new ComboBox();
            lblDecisionStatus = new Label();
            cmbDecisionStatus = new ComboBox();
            lblDecisionBy = new Label();
            cmbDecisionBy = new ComboBox();
            lblDecisionDate = new Label();
            dtpDecisionDate = new DateTimePicker();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            btnSave = new Button();
            lblExistingDecisions = new Label();
            dgvDecisions = new DataGridView();
            linkLabel1 = new LinkLabel();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDecisions).BeginInit();
            SuspendLayout();
            // 
            // lblFinalHiringDecisionTitle
            // 
            lblFinalHiringDecisionTitle.Anchor = AnchorStyles.Top;
            lblFinalHiringDecisionTitle.AutoSize = true;
            lblFinalHiringDecisionTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalHiringDecisionTitle.ForeColor = Color.MidnightBlue;
            lblFinalHiringDecisionTitle.Location = new Point(331, 7);
            lblFinalHiringDecisionTitle.Name = "lblFinalHiringDecisionTitle";
            lblFinalHiringDecisionTitle.Size = new Size(225, 30);
            lblFinalHiringDecisionTitle.TabIndex = 0;
            lblFinalHiringDecisionTitle.Text = "Final Hiring Decision";
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.BackColor = Color.SteelBlue;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(lblApplication);
            pnlForm.Controls.Add(cmbApplication);
            pnlForm.Controls.Add(lblDecisionStatus);
            pnlForm.Controls.Add(cmbDecisionStatus);
            pnlForm.Controls.Add(lblDecisionBy);
            pnlForm.Controls.Add(cmbDecisionBy);
            pnlForm.Controls.Add(lblDecisionDate);
            pnlForm.Controls.Add(dtpDecisionDate);
            pnlForm.Controls.Add(lblRemarks);
            pnlForm.Controls.Add(txtRemarks);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Location = new Point(24, 46);
            pnlForm.Margin = new Padding(3, 2, 3, 2);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(860, 166);
            pnlForm.TabIndex = 1;
            // 
            // lblApplication
            // 
            lblApplication.AutoSize = true;
            lblApplication.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplication.ForeColor = Color.Azure;
            lblApplication.Location = new Point(15, 14);
            lblApplication.Name = "lblApplication";
            lblApplication.Size = new Size(66, 19);
            lblApplication.TabIndex = 0;
            lblApplication.Text = "Applicant";
            // 
            // cmbApplication
            // 
            cmbApplication.BackColor = Color.Azure;
            cmbApplication.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApplication.ForeColor = Color.MidnightBlue;
            cmbApplication.FormattingEnabled = true;
            cmbApplication.Location = new Point(15, 33);
            cmbApplication.Margin = new Padding(3, 2, 3, 2);
            cmbApplication.Name = "cmbApplication";
            cmbApplication.Size = new Size(280, 23);
            cmbApplication.TabIndex = 0;
            // 
            // lblDecisionStatus
            // 
            lblDecisionStatus.AutoSize = true;
            lblDecisionStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionStatus.ForeColor = Color.Azure;
            lblDecisionStatus.Location = new Point(312, 14);
            lblDecisionStatus.Name = "lblDecisionStatus";
            lblDecisionStatus.Size = new Size(102, 19);
            lblDecisionStatus.TabIndex = 1;
            lblDecisionStatus.Text = "Decision Status";
            // 
            // cmbDecisionStatus
            // 
            cmbDecisionStatus.BackColor = Color.Azure;
            cmbDecisionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDecisionStatus.ForeColor = Color.MidnightBlue;
            cmbDecisionStatus.FormattingEnabled = true;
            cmbDecisionStatus.Items.AddRange(new object[] { "-- Select Status --", "Hired", "Rejected", "On Hold", "Waitlisted" });
            cmbDecisionStatus.Location = new Point(312, 33);
            cmbDecisionStatus.Margin = new Padding(3, 2, 3, 2);
            cmbDecisionStatus.Name = "cmbDecisionStatus";
            cmbDecisionStatus.Size = new Size(158, 23);
            cmbDecisionStatus.TabIndex = 1;
            // 
            // lblDecisionBy
            // 
            lblDecisionBy.AutoSize = true;
            lblDecisionBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionBy.ForeColor = Color.Azure;
            lblDecisionBy.Location = new Point(484, 14);
            lblDecisionBy.Name = "lblDecisionBy";
            lblDecisionBy.Size = new Size(79, 19);
            lblDecisionBy.TabIndex = 2;
            lblDecisionBy.Text = "Decision By";
            // 
            // cmbDecisionBy
            // 
            cmbDecisionBy.BackColor = Color.Azure;
            cmbDecisionBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDecisionBy.ForeColor = Color.MidnightBlue;
            cmbDecisionBy.FormattingEnabled = true;
            cmbDecisionBy.Location = new Point(484, 33);
            cmbDecisionBy.Margin = new Padding(3, 2, 3, 2);
            cmbDecisionBy.Name = "cmbDecisionBy";
            cmbDecisionBy.Size = new Size(193, 23);
            cmbDecisionBy.TabIndex = 2;
            // 
            // lblDecisionDate
            // 
            lblDecisionDate.AutoSize = true;
            lblDecisionDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionDate.ForeColor = Color.Azure;
            lblDecisionDate.Location = new Point(690, 14);
            lblDecisionDate.Name = "lblDecisionDate";
            lblDecisionDate.Size = new Size(93, 19);
            lblDecisionDate.TabIndex = 3;
            lblDecisionDate.Text = "Decision Date";
            // 
            // dtpDecisionDate
            // 
            dtpDecisionDate.CalendarMonthBackground = Color.Azure;
            dtpDecisionDate.CalendarTitleBackColor = Color.MidnightBlue;
            dtpDecisionDate.CalendarTitleForeColor = Color.Azure;
            dtpDecisionDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpDecisionDate.Format = DateTimePickerFormat.Custom;
            dtpDecisionDate.Location = new Point(690, 33);
            dtpDecisionDate.Margin = new Padding(3, 2, 3, 2);
            dtpDecisionDate.Name = "dtpDecisionDate";
            dtpDecisionDate.ShowUpDown = true;
            dtpDecisionDate.Size = new Size(156, 23);
            dtpDecisionDate.TabIndex = 3;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = Color.Azure;
            lblRemarks.Location = new Point(15, 68);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(61, 19);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRemarks.BackColor = Color.Azure;
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.ForeColor = Color.MidnightBlue;
            txtRemarks.Location = new Point(15, 87);
            txtRemarks.Margin = new Padding(3, 2, 3, 2);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.ScrollBars = ScrollBars.Vertical;
            txtRemarks.Size = new Size(718, 60);
            txtRemarks.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(746, 87);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 60);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Decision";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblExistingDecisions
            // 
            lblExistingDecisions.AutoSize = true;
            lblExistingDecisions.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingDecisions.ForeColor = Color.MidnightBlue;
            lblExistingDecisions.Location = new Point(24, 225);
            lblExistingDecisions.Name = "lblExistingDecisions";
            lblExistingDecisions.Size = new Size(126, 19);
            lblExistingDecisions.TabIndex = 0;
            lblExistingDecisions.Text = "Existing Decisions";
            // 
            // dgvDecisions
            // 
            dgvDecisions.AllowUserToAddRows = false;
            dgvDecisions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDecisions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDecisions.BackgroundColor = Color.Azure;
            dgvDecisions.BorderStyle = BorderStyle.None;
            dgvDecisions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDecisions.ColumnHeadersHeight = 32;
            dgvDecisions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDecisions.EnableHeadersVisualStyles = false;
            dgvDecisions.GridColor = Color.SteelBlue;
            dgvDecisions.Location = new Point(24, 246);
            dgvDecisions.Margin = new Padding(3, 2, 3, 2);
            dgvDecisions.Name = "dgvDecisions";
            dgvDecisions.ReadOnly = true;
            dgvDecisions.RowHeadersVisible = false;
            dgvDecisions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDecisions.Size = new Size(859, 172);
            dgvDecisions.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(34, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += Back;
            // 
            // HireDecision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(906, 440);
            Controls.Add(linkLabel1);
            Controls.Add(lblExistingDecisions);
            Controls.Add(dgvDecisions);
            Controls.Add(pnlForm);
            Controls.Add(lblFinalHiringDecisionTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HireDecision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Final Hiring Decision";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDecisions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFinalHiringDecisionTitle;
        private Panel pnlForm;
        private Label lblApplication;
        private ComboBox cmbApplication;
        private Label lblDecisionStatus;
        private ComboBox cmbDecisionStatus;
        private Label lblDecisionBy;
        private ComboBox cmbDecisionBy;
        private Label lblDecisionDate;
        private DateTimePicker dtpDecisionDate;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Button btnSave;
        private Label lblExistingDecisions;
        private DataGridView dgvDecisions;
        private LinkLabel linkLabel1;
    }
}
