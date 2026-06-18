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
            lblFinalHiringDecisionTitle.Location = new Point(378, 9);
            lblFinalHiringDecisionTitle.Name = "lblFinalHiringDecisionTitle";
            lblFinalHiringDecisionTitle.Size = new Size(289, 38);
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
            pnlForm.Location = new Point(27, 61);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(983, 221);
            pnlForm.TabIndex = 1;
            // 
            // lblApplication
            // 
            lblApplication.AutoSize = true;
            lblApplication.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplication.ForeColor = Color.Azure;
            lblApplication.Location = new Point(17, 19);
            lblApplication.Name = "lblApplication";
            lblApplication.Size = new Size(82, 23);
            lblApplication.TabIndex = 0;
            lblApplication.Text = "Applicant";
            // 
            // cmbApplication
            // 
            cmbApplication.BackColor = Color.Azure;
            cmbApplication.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApplication.ForeColor = Color.MidnightBlue;
            cmbApplication.FormattingEnabled = true;
            cmbApplication.Location = new Point(17, 44);
            cmbApplication.Name = "cmbApplication";
            cmbApplication.Size = new Size(319, 28);
            cmbApplication.TabIndex = 0;
            // 
            // lblDecisionStatus
            // 
            lblDecisionStatus.AutoSize = true;
            lblDecisionStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionStatus.ForeColor = Color.Azure;
            lblDecisionStatus.Location = new Point(357, 19);
            lblDecisionStatus.Name = "lblDecisionStatus";
            lblDecisionStatus.Size = new Size(125, 23);
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
            cmbDecisionStatus.Location = new Point(357, 44);
            cmbDecisionStatus.Name = "cmbDecisionStatus";
            cmbDecisionStatus.Size = new Size(180, 28);
            cmbDecisionStatus.TabIndex = 1;
            // 
            // lblDecisionBy
            // 
            lblDecisionBy.AutoSize = true;
            lblDecisionBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionBy.ForeColor = Color.Azure;
            lblDecisionBy.Location = new Point(553, 19);
            lblDecisionBy.Name = "lblDecisionBy";
            lblDecisionBy.Size = new Size(97, 23);
            lblDecisionBy.TabIndex = 2;
            lblDecisionBy.Text = "Decision By";
            // 
            // cmbDecisionBy
            // 
            cmbDecisionBy.BackColor = Color.Azure;
            cmbDecisionBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDecisionBy.ForeColor = Color.MidnightBlue;
            cmbDecisionBy.FormattingEnabled = true;
            cmbDecisionBy.Location = new Point(553, 44);
            cmbDecisionBy.Name = "cmbDecisionBy";
            cmbDecisionBy.Size = new Size(220, 28);
            cmbDecisionBy.TabIndex = 2;
            // 
            // lblDecisionDate
            // 
            lblDecisionDate.AutoSize = true;
            lblDecisionDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionDate.ForeColor = Color.Azure;
            lblDecisionDate.Location = new Point(789, 19);
            lblDecisionDate.Name = "lblDecisionDate";
            lblDecisionDate.Size = new Size(115, 23);
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
            dtpDecisionDate.Location = new Point(789, 44);
            dtpDecisionDate.Name = "dtpDecisionDate";
            dtpDecisionDate.ShowUpDown = true;
            dtpDecisionDate.Size = new Size(178, 27);
            dtpDecisionDate.TabIndex = 3;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = Color.Azure;
            lblRemarks.Location = new Point(17, 91);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(74, 23);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRemarks.BackColor = Color.Azure;
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.ForeColor = Color.MidnightBlue;
            txtRemarks.Location = new Point(17, 116);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.ScrollBars = ScrollBars.Vertical;
            txtRemarks.Size = new Size(820, 79);
            txtRemarks.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(853, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 80);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Decision";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblExistingDecisions
            // 
            lblExistingDecisions.AutoSize = true;
            lblExistingDecisions.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingDecisions.ForeColor = Color.MidnightBlue;
            lblExistingDecisions.Location = new Point(27, 300);
            lblExistingDecisions.Name = "lblExistingDecisions";
            lblExistingDecisions.Size = new Size(152, 23);
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
            dgvDecisions.Location = new Point(27, 328);
            dgvDecisions.Name = "dgvDecisions";
            dgvDecisions.ReadOnly = true;
            dgvDecisions.RowHeadersVisible = false;
            dgvDecisions.RowHeadersWidth = 51;
            dgvDecisions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDecisions.Size = new Size(982, 229);
            dgvDecisions.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(39, 21);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += Back;
            // 
            // HireDecision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1035, 587);
            Controls.Add(linkLabel1);
            Controls.Add(lblExistingDecisions);
            Controls.Add(dgvDecisions);
            Controls.Add(pnlForm);
            Controls.Add(lblFinalHiringDecisionTitle);
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
