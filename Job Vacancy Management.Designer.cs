namespace Job_Vacancy_Management
{
    partial class Form1
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
            btnEdit = new Button();
            btnClose = new Button();
            btnReopen = new Button();
            btnCancelEdit = new Button();
            lblEditingLabel = new Label();
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
            lblTitle.Location = new Point(350, 9);
            lblTitle.Name = "lblTitle";
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
            pnlForm.Location = new Point(27, 62);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(974, 250);
            pnlForm.TabIndex = 1;

            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.Azure;
            lblPosition.Location = new Point(17, 18);
            lblPosition.Name = "lblPosition";
            lblPosition.Text = "Position";

            // 
            // cmbPosition
            // 
            cmbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbPosition.BackColor = Color.Azure;
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.ForeColor = Color.MidnightBlue;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(17, 44);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(220, 28);
            cmbPosition.TabIndex = 0;

            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartment.ForeColor = Color.Azure;
            lblDepartment.Location = new Point(255, 18);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Text = "Department";

            // 
            // cmbDepartment
            // 
            cmbDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbDepartment.BackColor = Color.Azure;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.ForeColor = Color.MidnightBlue;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(255, 44);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(220, 28);
            cmbDepartment.TabIndex = 1;

            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmploymentType.ForeColor = Color.Azure;
            lblEmploymentType.Location = new Point(493, 18);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Text = "Employment Type";

            // 
            // cmbEmploymentType
            // New dropdown — loads from EmploymentTypes table
            // 
            cmbEmploymentType.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbEmploymentType.BackColor = Color.Azure;
            cmbEmploymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmploymentType.ForeColor = Color.MidnightBlue;
            cmbEmploymentType.FormattingEnabled = true;
            cmbEmploymentType.Location = new Point(493, 44);
            cmbEmploymentType.Name = "cmbEmploymentType";
            cmbEmploymentType.Size = new Size(180, 28);
            cmbEmploymentType.TabIndex = 2;

            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Azure;
            lblStatus.Location = new Point(691, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "Status";

            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbStatus.BackColor = Color.Azure;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.ForeColor = Color.MidnightBlue;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Open", "Closed" });
            cmbStatus.Location = new Point(691, 44);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 28);
            cmbStatus.TabIndex = 3;

            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQualifications.ForeColor = Color.Azure;
            lblQualifications.Location = new Point(17, 90);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Text = "Qualifications";

            // 
            // txtQualifications
            // 
            txtQualifications.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQualifications.BackColor = Color.Azure;
            txtQualifications.BorderStyle = BorderStyle.FixedSingle;
            txtQualifications.ForeColor = Color.MidnightBlue;
            txtQualifications.Location = new Point(17, 116);
            txtQualifications.Multiline = true;
            txtQualifications.Name = "txtQualifications";
            txtQualifications.ScrollBars = ScrollBars.Vertical;
            txtQualifications.Size = new Size(500, 110);
            txtQualifications.TabIndex = 4;

            // 
            // lblRequiredDocs
            // 
            lblRequiredDocs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRequiredDocs.AutoSize = true;
            lblRequiredDocs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRequiredDocs.ForeColor = Color.Azure;
            lblRequiredDocs.Location = new Point(535, 90);
            lblRequiredDocs.Name = "lblRequiredDocs";
            lblRequiredDocs.Text = "Required Documents";

            // 
            // clbRequiredDocs
            // 
            clbRequiredDocs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clbRequiredDocs.BackColor = Color.Azure;
            clbRequiredDocs.BorderStyle = BorderStyle.FixedSingle;
            clbRequiredDocs.ForeColor = Color.MidnightBlue;
            clbRequiredDocs.Location = new Point(535, 116);
            clbRequiredDocs.Name = "clbRequiredDocs";
            clbRequiredDocs.Size = new Size(290, 110);
            clbRequiredDocs.TabIndex = 5;

            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(840, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 110);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Vacancy";
            btnSave.UseVisualStyleBackColor = false;

            // 
            // lblExistingVacancies
            // 
            lblExistingVacancies.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblExistingVacancies.AutoSize = true;
            lblExistingVacancies.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingVacancies.ForeColor = Color.MidnightBlue;
            lblExistingVacancies.Location = new Point(27, 328);
            lblExistingVacancies.Name = "lblExistingVacancies";
            lblExistingVacancies.Text = "Existing Vacancies — click a row to edit";

            // 
            // dgvVacancies
            // 
            dgvVacancies.AllowUserToAddRows = false;
            dgvVacancies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVacancies.BackgroundColor = Color.Azure;
            dgvVacancies.BorderStyle = BorderStyle.None;
            dgvVacancies.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvVacancies.ColumnHeadersHeight = 32;
            dgvVacancies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVacancies.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvVacancies.EnableHeadersVisualStyles = false;
            dgvVacancies.GridColor = Color.SteelBlue;
            dgvVacancies.Location = new Point(27, 356);
            dgvVacancies.Name = "dgvVacancies";
            dgvVacancies.ReadOnly = true;
            dgvVacancies.RowHeadersVisible = false;
            dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancies.Size = new Size(974, 180);
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
            pnlActions.Location = new Point(27, 548);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(974, 50);
            pnlActions.TabIndex = 3;
            pnlActions.Visible = false;

            // 
            // lblEditingLabel
            // 
            lblEditingLabel.AutoSize = true;
            lblEditingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEditingLabel.ForeColor = Color.Azure;
            lblEditingLabel.Location = new Point(14, 15);
            lblEditingLabel.Name = "lblEditingLabel";
            lblEditingLabel.Text = "Selected: —";

            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Azure;
            btnEdit.Location = new Point(500, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 28);
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
            btnClose.Location = new Point(622, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 28);
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
            btnReopen.Location = new Point(744, 10);
            btnReopen.Name = "btnReopen";
            btnReopen.Size = new Size(110, 28);
            btnReopen.TabIndex = 2;
            btnReopen.Text = "Reopen";
            btnReopen.UseVisualStyleBackColor = false;

            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelEdit.BackColor = Color.SteelBlue;
            btnCancelEdit.FlatAppearance.BorderColor = Color.Azure;
            btnCancelEdit.FlatAppearance.BorderSize = 1;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.ForeColor = Color.Azure;
            btnCancelEdit.Location = new Point(866, 10);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(90, 28);
            btnCancelEdit.TabIndex = 3;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1028, 610);
            Controls.Add(pnlActions);
            Controls.Add(lblExistingVacancies);
            Controls.Add(dgvVacancies);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "Form1";
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
    }
}
