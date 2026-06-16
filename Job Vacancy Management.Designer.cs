namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class JobVacancyManagement
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
            lblTitle = new Label();
            pnlForm = new Panel();
            lblPosition = new Label();
            cmbPosition = new ComboBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblEmploymentType = new Label();
            cmbEmploymentType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblQualifications = new Label();
            txtQualifications = new TextBox();
            lblRequiredDocs = new Label();
            clbRequiredDocs = new CheckedListBox();
            btnSave = new Button();
            lblExistingVacancies = new Label();
            dgvVacancies = new DataGridView();
            pnlActions = new Panel();
            lblEditingLabel = new Label();
            btnEdit = new Button();
            btnClose = new Button();
            btnReopen = new Button();
            btnCancelEdit = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            linkLabel1 = new LinkLabel();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacancies).BeginInit();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(306, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Job Vacancy Management";
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.BackColor = Color.SteelBlue;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(lblPosition);
            pnlForm.Controls.Add(cmbPosition);
            pnlForm.Controls.Add(lblDepartment);
            pnlForm.Controls.Add(cmbDepartment);
            pnlForm.Controls.Add(lblEmploymentType);
            pnlForm.Controls.Add(cmbEmploymentType);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(cmbStatus);
            pnlForm.Controls.Add(lblQualifications);
            pnlForm.Controls.Add(txtQualifications);
            pnlForm.Controls.Add(lblRequiredDocs);
            pnlForm.Controls.Add(clbRequiredDocs);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Location = new Point(24, 46);
            pnlForm.Margin = new Padding(3, 2, 3, 2);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(852, 188);
            pnlForm.TabIndex = 1;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.Azure;
            lblPosition.Location = new Point(15, 14);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 19);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = Color.Azure;
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.ForeColor = Color.MidnightBlue;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(15, 33);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(193, 23);
            cmbPosition.TabIndex = 0;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartment.ForeColor = Color.Azure;
            lblDepartment.Location = new Point(223, 14);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(83, 19);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = Color.Azure;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.ForeColor = Color.MidnightBlue;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(223, 33);
            cmbDepartment.Margin = new Padding(3, 2, 3, 2);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(193, 23);
            cmbDepartment.TabIndex = 1;
            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmploymentType.ForeColor = Color.Azure;
            lblEmploymentType.Location = new Point(431, 14);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Size = new Size(118, 19);
            lblEmploymentType.TabIndex = 2;
            lblEmploymentType.Text = "Employment Type";
            // 
            // cmbEmploymentType
            // 
            cmbEmploymentType.BackColor = Color.Azure;
            cmbEmploymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmploymentType.ForeColor = Color.MidnightBlue;
            cmbEmploymentType.FormattingEnabled = true;
            cmbEmploymentType.Location = new Point(431, 33);
            cmbEmploymentType.Margin = new Padding(3, 2, 3, 2);
            cmbEmploymentType.Name = "cmbEmploymentType";
            cmbEmploymentType.Size = new Size(158, 23);
            cmbEmploymentType.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Azure;
            lblStatus.Location = new Point(605, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 19);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.Azure;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.ForeColor = Color.MidnightBlue;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Open", "Closed" });
            cmbStatus.Location = new Point(605, 33);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(132, 23);
            cmbStatus.TabIndex = 3;
            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQualifications.ForeColor = Color.Azure;
            lblQualifications.Location = new Point(15, 68);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Size = new Size(91, 19);
            lblQualifications.TabIndex = 4;
            lblQualifications.Text = "Qualifications";
            // 
            // txtQualifications
            // 
            txtQualifications.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQualifications.BackColor = Color.Azure;
            txtQualifications.BorderStyle = BorderStyle.FixedSingle;
            txtQualifications.ForeColor = Color.MidnightBlue;
            txtQualifications.Location = new Point(15, 87);
            txtQualifications.Margin = new Padding(3, 2, 3, 2);
            txtQualifications.Multiline = true;
            txtQualifications.Name = "txtQualifications";
            txtQualifications.ScrollBars = ScrollBars.Vertical;
            txtQualifications.Size = new Size(438, 83);
            txtQualifications.TabIndex = 4;
            // 
            // lblRequiredDocs
            // 
            lblRequiredDocs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRequiredDocs.AutoSize = true;
            lblRequiredDocs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRequiredDocs.ForeColor = Color.Azure;
            lblRequiredDocs.Location = new Point(468, 68);
            lblRequiredDocs.Name = "lblRequiredDocs";
            lblRequiredDocs.Size = new Size(137, 19);
            lblRequiredDocs.TabIndex = 5;
            lblRequiredDocs.Text = "Required Documents";
            // 
            // clbRequiredDocs
            // 
            clbRequiredDocs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clbRequiredDocs.BackColor = Color.Azure;
            clbRequiredDocs.BorderStyle = BorderStyle.FixedSingle;
            clbRequiredDocs.ForeColor = Color.MidnightBlue;
            clbRequiredDocs.Location = new Point(468, 87);
            clbRequiredDocs.Margin = new Padding(3, 2, 3, 2);
            clbRequiredDocs.Name = "clbRequiredDocs";
            clbRequiredDocs.Size = new Size(254, 74);
            clbRequiredDocs.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(735, 87);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 82);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Vacancy";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblExistingVacancies
            // 
            lblExistingVacancies.AutoSize = true;
            lblExistingVacancies.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingVacancies.ForeColor = Color.MidnightBlue;
            lblExistingVacancies.Location = new Point(24, 246);
            lblExistingVacancies.Name = "lblExistingVacancies";
            lblExistingVacancies.Size = new Size(270, 19);
            lblExistingVacancies.TabIndex = 4;
            lblExistingVacancies.Text = "Existing Vacancies — click a row to edit";
            // 
            // dgvVacancies
            // 
            dgvVacancies.AllowUserToAddRows = false;
            dgvVacancies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVacancies.BackgroundColor = Color.Azure;
            dgvVacancies.BorderStyle = BorderStyle.None;
            dgvVacancies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVacancies.ColumnHeadersHeight = 32;
            dgvVacancies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVacancies.EnableHeadersVisualStyles = false;
            dgvVacancies.GridColor = Color.SteelBlue;
            dgvVacancies.Location = new Point(24, 267);
            dgvVacancies.Margin = new Padding(3, 2, 3, 2);
            dgvVacancies.Name = "dgvVacancies";
            dgvVacancies.ReadOnly = true;
            dgvVacancies.RowHeadersVisible = false;
            dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancies.Size = new Size(852, 135);
            dgvVacancies.TabIndex = 2;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.BackColor = Color.SteelBlue;
            pnlActions.BorderStyle = BorderStyle.FixedSingle;
            pnlActions.Controls.Add(lblEditingLabel);
            pnlActions.Controls.Add(btnEdit);
            pnlActions.Controls.Add(btnClose);
            pnlActions.Controls.Add(btnReopen);
            pnlActions.Controls.Add(btnCancelEdit);
            pnlActions.Location = new Point(24, 411);
            pnlActions.Margin = new Padding(3, 2, 3, 2);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(852, 38);
            pnlActions.TabIndex = 3;
            pnlActions.Visible = false;
            // 
            // lblEditingLabel
            // 
            lblEditingLabel.AutoSize = true;
            lblEditingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEditingLabel.ForeColor = Color.Azure;
            lblEditingLabel.Location = new Point(12, 11);
            lblEditingLabel.Name = "lblEditingLabel";
            lblEditingLabel.Size = new Size(68, 15);
            lblEditingLabel.TabIndex = 0;
            lblEditingLabel.Text = "Selected: —";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Azure;
            btnEdit.Location = new Point(438, 8);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 21);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(180, 40, 40);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Azure;
            btnClose.Location = new Point(544, 8);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 21);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnReopen
            // 
            btnReopen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReopen.BackColor = Color.FromArgb(40, 130, 60);
            btnReopen.FlatAppearance.BorderSize = 0;
            btnReopen.FlatStyle = FlatStyle.Flat;
            btnReopen.ForeColor = Color.Azure;
            btnReopen.Location = new Point(651, 8);
            btnReopen.Margin = new Padding(3, 2, 3, 2);
            btnReopen.Name = "btnReopen";
            btnReopen.Size = new Size(96, 21);
            btnReopen.TabIndex = 2;
            btnReopen.Text = "Reopen";
            btnReopen.UseVisualStyleBackColor = false;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelEdit.BackColor = Color.SteelBlue;
            btnCancelEdit.FlatAppearance.BorderColor = Color.Azure;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.ForeColor = Color.Azure;
            btnCancelEdit.Location = new Point(758, 8);
            btnCancelEdit.Margin = new Padding(3, 2, 3, 2);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(79, 21);
            btnCancelEdit.TabIndex = 3;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(24, 7);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += Back;
            // 
            // JobVacancyManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(900, 458);
            Controls.Add(linkLabel1);
            Controls.Add(pnlActions);
            Controls.Add(lblExistingVacancies);
            Controls.Add(dgvVacancies);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JobVacancyManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Vacancy Management";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacancies).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel pnlForm;
        private Label lblPosition;
        private ComboBox cmbPosition;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblEmploymentType;
        private ComboBox cmbEmploymentType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblQualifications;
        private TextBox txtQualifications;
        private Label lblRequiredDocs;
        private CheckedListBox clbRequiredDocs;
        private Button btnSave;
        private Label lblExistingVacancies;
        private DataGridView dgvVacancies;
        private Panel pnlActions;
        private Label lblEditingLabel;
        private Button btnEdit;
        private Button btnClose;
        private Button btnReopen;
        private Button btnCancelEdit;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private LinkLabel linkLabel1;
    }
}
