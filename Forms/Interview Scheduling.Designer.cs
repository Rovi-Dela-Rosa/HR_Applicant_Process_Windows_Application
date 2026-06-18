namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class InterviewSchedulingForm
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
            lblInterviewSchedulingTitle = new Label();
            pnlInterviewSchedulingBg = new Panel();
            cmbInterviewer = new ComboBox();
            cmbInterviewType = new ComboBox();
            lblInterviewType = new Label();
            btnSave = new Button();
            label2 = new Label();
            cmbStatus = new ComboBox();
            txtLocation = new TextBox();
            lblLocation = new Label();
            lblInterviewerID = new Label();
            dtpInterviewDate = new DateTimePicker();
            label1 = new Label();
            cmbApplicant = new ComboBox();
            lblApplicationID = new Label();
            dgvSchedules = new DataGridView();
            pnlUpdate = new Panel();
            lblSelectedSchedule = new Label();
            lblUpdateDate = new Label();
            dtpUpdateDate = new DateTimePicker();
            lblUpdateTime = new Label();
            dtpUpdateTime = new DateTimePicker();
            lblUpdateLocation = new Label();
            txtUpdateLocation = new TextBox();
            lblUpdateInterviewer = new Label();
            cmbUpdateInterviewer = new ComboBox();
            lblUpdateStatus = new Label();
            cmbUpdateStatus = new ComboBox();
            btnUpdate = new Button();
            btnCancelUpdate = new Button();
            lblExistingSchedules = new Label();
            linkLabel1 = new LinkLabel();
            pnlInterviewSchedulingBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            pnlUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // lblInterviewSchedulingTitle
            // 
            lblInterviewSchedulingTitle.Anchor = AnchorStyles.Top;
            lblInterviewSchedulingTitle.AutoSize = true;
            lblInterviewSchedulingTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInterviewSchedulingTitle.ForeColor = Color.MidnightBlue;
            lblInterviewSchedulingTitle.Location = new Point(346, 9);
            lblInterviewSchedulingTitle.Name = "lblInterviewSchedulingTitle";
            lblInterviewSchedulingTitle.Size = new Size(294, 38);
            lblInterviewSchedulingTitle.TabIndex = 0;
            lblInterviewSchedulingTitle.Text = "Interview Scheduling";
            // 
            // pnlInterviewSchedulingBg
            // 
            pnlInterviewSchedulingBg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInterviewSchedulingBg.BackColor = Color.SteelBlue;
            pnlInterviewSchedulingBg.BorderStyle = BorderStyle.FixedSingle;
            pnlInterviewSchedulingBg.Controls.Add(cmbInterviewer);
            pnlInterviewSchedulingBg.Controls.Add(cmbInterviewType);
            pnlInterviewSchedulingBg.Controls.Add(lblInterviewType);
            pnlInterviewSchedulingBg.Controls.Add(btnSave);
            pnlInterviewSchedulingBg.Controls.Add(label2);
            pnlInterviewSchedulingBg.Controls.Add(cmbStatus);
            pnlInterviewSchedulingBg.Controls.Add(txtLocation);
            pnlInterviewSchedulingBg.Controls.Add(lblLocation);
            pnlInterviewSchedulingBg.Controls.Add(lblInterviewerID);
            pnlInterviewSchedulingBg.Controls.Add(dtpInterviewDate);
            pnlInterviewSchedulingBg.Controls.Add(label1);
            pnlInterviewSchedulingBg.Controls.Add(cmbApplicant);
            pnlInterviewSchedulingBg.Controls.Add(lblApplicationID);
            pnlInterviewSchedulingBg.Location = new Point(27, 62);
            pnlInterviewSchedulingBg.Name = "pnlInterviewSchedulingBg";
            pnlInterviewSchedulingBg.Size = new Size(948, 191);
            pnlInterviewSchedulingBg.TabIndex = 1;
            // 
            // cmbInterviewer
            // 
            cmbInterviewer.BackColor = Color.Azure;
            cmbInterviewer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterviewer.ForeColor = Color.MidnightBlue;
            cmbInterviewer.FormattingEnabled = true;
            cmbInterviewer.Location = new Point(17, 128);
            cmbInterviewer.Name = "cmbInterviewer";
            cmbInterviewer.Size = new Size(192, 28);
            cmbInterviewer.TabIndex = 11;
            // 
            // cmbInterviewType
            // 
            cmbInterviewType.BackColor = Color.Azure;
            cmbInterviewType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterviewType.ForeColor = Color.MidnightBlue;
            cmbInterviewType.FormattingEnabled = true;
            cmbInterviewType.Location = new Point(241, 44);
            cmbInterviewType.Name = "cmbInterviewType";
            cmbInterviewType.Size = new Size(217, 28);
            cmbInterviewType.TabIndex = 13;
            // 
            // lblInterviewType
            // 
            lblInterviewType.AutoSize = true;
            lblInterviewType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterviewType.ForeColor = Color.Azure;
            lblInterviewType.Location = new Point(241, 18);
            lblInterviewType.Name = "lblInterviewType";
            lblInterviewType.Size = new Size(119, 23);
            lblInterviewType.TabIndex = 12;
            lblInterviewType.Text = "Interview Type";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(659, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(184, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(472, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 9;
            label2.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.Azure;
            cmbStatus.ForeColor = Color.MidnightBlue;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "Cancelled" });
            cmbStatus.Location = new Point(472, 129);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 8;
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocation.BackColor = Color.Azure;
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.ForeColor = Color.MidnightBlue;
            txtLocation.Location = new Point(486, 45);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(434, 27);
            txtLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.Azure;
            lblLocation.Location = new Point(486, 19);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(75, 23);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location";
            // 
            // lblInterviewerID
            // 
            lblInterviewerID.AutoSize = true;
            lblInterviewerID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterviewerID.ForeColor = Color.Azure;
            lblInterviewerID.Location = new Point(17, 102);
            lblInterviewerID.Name = "lblInterviewerID";
            lblInterviewerID.Size = new Size(94, 23);
            lblInterviewerID.TabIndex = 4;
            lblInterviewerID.Text = "Interviewer";
            // 
            // dtpInterviewDate
            // 
            dtpInterviewDate.CalendarMonthBackground = Color.Azure;
            dtpInterviewDate.CalendarTitleBackColor = Color.MidnightBlue;
            dtpInterviewDate.CalendarTitleForeColor = Color.Azure;
            dtpInterviewDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpInterviewDate.Format = DateTimePickerFormat.Custom;
            dtpInterviewDate.Location = new Point(241, 130);
            dtpInterviewDate.Name = "dtpInterviewDate";
            dtpInterviewDate.ShowUpDown = true;
            dtpInterviewDate.Size = new Size(198, 27);
            dtpInterviewDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(250, 102);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 2;
            label1.Text = "Interview Date";
            // 
            // cmbApplicant
            // 
            cmbApplicant.BackColor = Color.Azure;
            cmbApplicant.ForeColor = Color.MidnightBlue;
            cmbApplicant.FormattingEnabled = true;
            cmbApplicant.Location = new Point(17, 44);
            cmbApplicant.Name = "cmbApplicant";
            cmbApplicant.Size = new Size(192, 28);
            cmbApplicant.TabIndex = 1;
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationID.ForeColor = Color.Azure;
            lblApplicationID.Location = new Point(17, 18);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(82, 23);
            lblApplicationID.TabIndex = 0;
            lblApplicationID.Text = "Applicant";
            // 
            // dgvSchedules
            // 
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.BackgroundColor = Color.Azure;
            dgvSchedules.BorderStyle = BorderStyle.None;
            dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSchedules.ColumnHeadersHeight = 32;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSchedules.GridColor = Color.SteelBlue;
            dgvSchedules.Location = new Point(27, 295);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(948, 200);
            dgvSchedules.TabIndex = 2;
            // 
            // pnlUpdate
            // 
            pnlUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUpdate.BackColor = Color.SteelBlue;
            pnlUpdate.BorderStyle = BorderStyle.FixedSingle;
            pnlUpdate.Controls.Add(lblSelectedSchedule);
            pnlUpdate.Controls.Add(lblUpdateDate);
            pnlUpdate.Controls.Add(dtpUpdateDate);
            pnlUpdate.Controls.Add(lblUpdateTime);
            pnlUpdate.Controls.Add(dtpUpdateTime);
            pnlUpdate.Controls.Add(lblUpdateLocation);
            pnlUpdate.Controls.Add(txtUpdateLocation);
            pnlUpdate.Controls.Add(lblUpdateInterviewer);
            pnlUpdate.Controls.Add(cmbUpdateInterviewer);
            pnlUpdate.Controls.Add(lblUpdateStatus);
            pnlUpdate.Controls.Add(cmbUpdateStatus);
            pnlUpdate.Controls.Add(btnUpdate);
            pnlUpdate.Controls.Add(btnCancelUpdate);
            pnlUpdate.Location = new Point(27, 510);
            pnlUpdate.Name = "pnlUpdate";
            pnlUpdate.Size = new Size(948, 130);
            pnlUpdate.TabIndex = 3;
            pnlUpdate.Visible = false;
            // 
            // lblSelectedSchedule
            // 
            lblSelectedSchedule.AutoSize = true;
            lblSelectedSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSelectedSchedule.ForeColor = Color.Azure;
            lblSelectedSchedule.Location = new Point(14, 10);
            lblSelectedSchedule.Name = "lblSelectedSchedule";
            lblSelectedSchedule.Size = new Size(75, 20);
            lblSelectedSchedule.TabIndex = 0;
            lblSelectedSchedule.Text = "Editing: —";
            // 
            // lblUpdateDate
            // 
            lblUpdateDate.AutoSize = true;
            lblUpdateDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateDate.ForeColor = Color.Azure;
            lblUpdateDate.Location = new Point(14, 38);
            lblUpdateDate.Name = "lblUpdateDate";
            lblUpdateDate.Size = new Size(85, 23);
            lblUpdateDate.TabIndex = 1;
            lblUpdateDate.Text = "New Date";
            // 
            // dtpUpdateDate
            // 
            dtpUpdateDate.CalendarMonthBackground = Color.Azure;
            dtpUpdateDate.CalendarTitleBackColor = Color.MidnightBlue;
            dtpUpdateDate.CalendarTitleForeColor = Color.Azure;
            dtpUpdateDate.Format = DateTimePickerFormat.Short;
            dtpUpdateDate.Location = new Point(14, 62);
            dtpUpdateDate.Name = "dtpUpdateDate";
            dtpUpdateDate.Size = new Size(150, 27);
            dtpUpdateDate.TabIndex = 20;
            // 
            // lblUpdateTime
            // 
            lblUpdateTime.AutoSize = true;
            lblUpdateTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateTime.ForeColor = Color.Azure;
            lblUpdateTime.Location = new Point(178, 38);
            lblUpdateTime.Name = "lblUpdateTime";
            lblUpdateTime.Size = new Size(86, 23);
            lblUpdateTime.TabIndex = 21;
            lblUpdateTime.Text = "New Time";
            // 
            // dtpUpdateTime
            // 
            dtpUpdateTime.CalendarMonthBackground = Color.Azure;
            dtpUpdateTime.CalendarTitleBackColor = Color.MidnightBlue;
            dtpUpdateTime.CalendarTitleForeColor = Color.Azure;
            dtpUpdateTime.CustomFormat = "hh:mm tt";
            dtpUpdateTime.Format = DateTimePickerFormat.Custom;
            dtpUpdateTime.Location = new Point(178, 62);
            dtpUpdateTime.Name = "dtpUpdateTime";
            dtpUpdateTime.ShowUpDown = true;
            dtpUpdateTime.Size = new Size(130, 27);
            dtpUpdateTime.TabIndex = 21;
            // 
            // lblUpdateLocation
            // 
            lblUpdateLocation.AutoSize = true;
            lblUpdateLocation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateLocation.ForeColor = Color.Azure;
            lblUpdateLocation.Location = new Point(325, 38);
            lblUpdateLocation.Name = "lblUpdateLocation";
            lblUpdateLocation.Size = new Size(75, 23);
            lblUpdateLocation.TabIndex = 22;
            lblUpdateLocation.Text = "Location";
            // 
            // txtUpdateLocation
            // 
            txtUpdateLocation.BackColor = Color.Azure;
            txtUpdateLocation.BorderStyle = BorderStyle.FixedSingle;
            txtUpdateLocation.ForeColor = Color.MidnightBlue;
            txtUpdateLocation.Location = new Point(325, 62);
            txtUpdateLocation.Name = "txtUpdateLocation";
            txtUpdateLocation.Size = new Size(180, 27);
            txtUpdateLocation.TabIndex = 22;
            // 
            // lblUpdateInterviewer
            // 
            lblUpdateInterviewer.AutoSize = true;
            lblUpdateInterviewer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateInterviewer.ForeColor = Color.Azure;
            lblUpdateInterviewer.Location = new Point(521, 38);
            lblUpdateInterviewer.Name = "lblUpdateInterviewer";
            lblUpdateInterviewer.Size = new Size(94, 23);
            lblUpdateInterviewer.TabIndex = 23;
            lblUpdateInterviewer.Text = "Interviewer";
            // 
            // cmbUpdateInterviewer
            // 
            cmbUpdateInterviewer.BackColor = Color.Azure;
            cmbUpdateInterviewer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateInterviewer.ForeColor = Color.MidnightBlue;
            cmbUpdateInterviewer.FormattingEnabled = true;
            cmbUpdateInterviewer.Location = new Point(521, 62);
            cmbUpdateInterviewer.Name = "cmbUpdateInterviewer";
            cmbUpdateInterviewer.Size = new Size(170, 28);
            cmbUpdateInterviewer.TabIndex = 23;
            // 
            // lblUpdateStatus
            // 
            lblUpdateStatus.AutoSize = true;
            lblUpdateStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateStatus.ForeColor = Color.Azure;
            lblUpdateStatus.Location = new Point(707, 38);
            lblUpdateStatus.Name = "lblUpdateStatus";
            lblUpdateStatus.Size = new Size(56, 23);
            lblUpdateStatus.TabIndex = 24;
            lblUpdateStatus.Text = "Status";
            // 
            // cmbUpdateStatus
            // 
            cmbUpdateStatus.BackColor = Color.Azure;
            cmbUpdateStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateStatus.ForeColor = Color.MidnightBlue;
            cmbUpdateStatus.FormattingEnabled = true;
            cmbUpdateStatus.Items.AddRange(new object[] { "Rescheduled", "Cancelled" });
            cmbUpdateStatus.Location = new Point(707, 62);
            cmbUpdateStatus.Name = "cmbUpdateStatus";
            cmbUpdateStatus.Size = new Size(140, 28);
            cmbUpdateStatus.TabIndex = 24;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.MidnightBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Azure;
            btnUpdate.Location = new Point(709, 97);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 28);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update Schedule";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancelUpdate
            // 
            btnCancelUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelUpdate.BackColor = Color.SteelBlue;
            btnCancelUpdate.FlatAppearance.BorderColor = Color.Azure;
            btnCancelUpdate.FlatStyle = FlatStyle.Flat;
            btnCancelUpdate.ForeColor = Color.Azure;
            btnCancelUpdate.Location = new Point(523, 97);
            btnCancelUpdate.Name = "btnCancelUpdate";
            btnCancelUpdate.Size = new Size(120, 28);
            btnCancelUpdate.TabIndex = 26;
            btnCancelUpdate.Text = "Cancel";
            btnCancelUpdate.UseVisualStyleBackColor = false;
            // 
            // lblExistingSchedules
            // 
            lblExistingSchedules.AutoSize = true;
            lblExistingSchedules.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingSchedules.ForeColor = Color.MidnightBlue;
            lblExistingSchedules.Location = new Point(27, 268);
            lblExistingSchedules.Name = "lblExistingSchedules";
            lblExistingSchedules.Size = new Size(329, 23);
            lblExistingSchedules.TabIndex = 0;
            lblExistingSchedules.Text = "Existing Schedules — click a row to edit";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(27, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // InterviewSchedulingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(983, 649);
            Controls.Add(linkLabel1);
            Controls.Add(lblExistingSchedules);
            Controls.Add(dgvSchedules);
            Controls.Add(pnlUpdate);
            Controls.Add(pnlInterviewSchedulingBg);
            Controls.Add(lblInterviewSchedulingTitle);
            Name = "InterviewSchedulingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interview Scheduling";
            pnlInterviewSchedulingBg.ResumeLayout(false);
            pnlInterviewSchedulingBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            pnlUpdate.ResumeLayout(false);
            pnlUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInterviewSchedulingTitle;
        private Panel pnlInterviewSchedulingBg;
        private Label lblApplicationID;
        private ComboBox cmbApplicant;
        private Label label1;
        private DateTimePicker dtpInterviewDate;
        private Label lblInterviewerID;
        private Label label2;
        private ComboBox cmbStatus;
        private TextBox txtLocation;
        private Label lblLocation;
        private Button btnSave;
        private ComboBox cmbInterviewer;
        private Label lblInterviewType;
        private ComboBox cmbInterviewType;
        private Label lblExistingSchedules;
        private DataGridView dgvSchedules;
        private Panel pnlUpdate;
        private Label lblSelectedSchedule;
        private Label lblUpdateDate;
        private DateTimePicker dtpUpdateDate;
        private Label lblUpdateTime;
        private DateTimePicker dtpUpdateTime;
        private Label lblUpdateLocation;
        private TextBox txtUpdateLocation;
        private Label lblUpdateInterviewer;
        private ComboBox cmbUpdateInterviewer;
        private Label lblUpdateStatus;
        private ComboBox cmbUpdateStatus;
        private Button btnUpdate;
        private Button btnCancelUpdate;
        private LinkLabel linkLabel1;
    }
}
