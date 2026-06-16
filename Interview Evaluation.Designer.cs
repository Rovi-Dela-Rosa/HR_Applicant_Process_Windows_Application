namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class InterviewEvaluationForm : Form
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
            lblInterviewEvalutionTitle = new Label();
            pnlForm = new Panel();
            lblInterview = new Label();
            cmbInterview = new ComboBox();
            lblScore = new Label();
            txtScore = new TextBox();
            lblResult = new Label();
            cmbResult = new ComboBox();
            lblEvaluatedBy = new Label();
            cmbEvaluatedBy = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            btnSave = new Button();
            lblExistingEvaluations = new Label();
            dgvEvaluations = new DataGridView();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluations).BeginInit();
            SuspendLayout();

            // 
            // lblInterviewEvalutionTitle
            // 
            lblInterviewEvalutionTitle.Anchor = AnchorStyles.Top;
            lblInterviewEvalutionTitle.AutoSize = true;
            lblInterviewEvalutionTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInterviewEvalutionTitle.ForeColor = Color.MidnightBlue;
            lblInterviewEvalutionTitle.Location = new Point(383, 9);
            lblInterviewEvalutionTitle.Name = "lblInterviewEvalutionTitle";
            lblInterviewEvalutionTitle.Size = new Size(287, 38);
            lblInterviewEvalutionTitle.TabIndex = 0;
            lblInterviewEvalutionTitle.Text = "Interview Evaluation";

            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.BackColor = Color.SteelBlue;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(lblInterview);
            pnlForm.Controls.Add(cmbInterview);
            pnlForm.Controls.Add(lblScore);
            pnlForm.Controls.Add(txtScore);
            pnlForm.Controls.Add(lblResult);
            pnlForm.Controls.Add(cmbResult);
            pnlForm.Controls.Add(lblEvaluatedBy);
            pnlForm.Controls.Add(cmbEvaluatedBy);
            pnlForm.Controls.Add(lblRemarks);
            pnlForm.Controls.Add(txtRemarks);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Location = new Point(27, 62);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(986, 220);
            pnlForm.TabIndex = 1;

            // 
            // lblInterview
            // 
            lblInterview.AutoSize = true;
            lblInterview.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterview.ForeColor = Color.Azure;
            lblInterview.Location = new Point(17, 18);
            lblInterview.Name = "lblInterview";
            lblInterview.Size = new Size(166, 23);
            lblInterview.TabIndex = 0;
            lblInterview.Text = "Interview (Applicant)";

            // 
            // cmbInterview
            // 
            cmbInterview.BackColor = Color.Azure;
            cmbInterview.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterview.ForeColor = Color.MidnightBlue;
            cmbInterview.FormattingEnabled = true;
            cmbInterview.Location = new Point(17, 44);
            cmbInterview.Name = "cmbInterview";
            cmbInterview.Size = new Size(350, 28);
            cmbInterview.TabIndex = 0;

            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Azure;
            lblScore.Location = new Point(390, 18);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(52, 23);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score";

            // 
            // txtScore
            // 
            txtScore.BackColor = Color.Azure;
            txtScore.BorderStyle = BorderStyle.FixedSingle;
            txtScore.ForeColor = Color.MidnightBlue;
            txtScore.Location = new Point(390, 44);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(120, 27);
            txtScore.TabIndex = 1;

            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Azure;
            lblResult.Location = new Point(530, 18);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 23);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";

            // 
            // cmbResult
            // 
            cmbResult.BackColor = Color.Azure;
            cmbResult.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResult.ForeColor = Color.MidnightBlue;
            cmbResult.FormattingEnabled = true;
            cmbResult.Items.AddRange(new object[] { "Passed", "Failed" });
            cmbResult.Location = new Point(530, 44);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(160, 28);
            cmbResult.TabIndex = 2;

            // 
            // lblEvaluatedBy
            // 
            lblEvaluatedBy.AutoSize = true;
            lblEvaluatedBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEvaluatedBy.ForeColor = Color.Azure;
            lblEvaluatedBy.Location = new Point(710, 18);
            lblEvaluatedBy.Name = "lblEvaluatedBy";
            lblEvaluatedBy.Size = new Size(104, 23);
            lblEvaluatedBy.TabIndex = 5;
            lblEvaluatedBy.Text = "Evaluated By";

            // 
            // cmbEvaluatedBy
            // 
            cmbEvaluatedBy.BackColor = Color.Azure;
            cmbEvaluatedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvaluatedBy.ForeColor = Color.MidnightBlue;
            cmbEvaluatedBy.FormattingEnabled = true;
            cmbEvaluatedBy.Location = new Point(710, 44);
            cmbEvaluatedBy.Name = "cmbEvaluatedBy";
            cmbEvaluatedBy.Size = new Size(260, 28);
            cmbEvaluatedBy.TabIndex = 3;

            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = Color.Azure;
            lblRemarks.Location = new Point(17, 90);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(74, 23);
            lblRemarks.TabIndex = 3;
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
            txtRemarks.Size = new Size(820, 80);
            txtRemarks.TabIndex = 3;

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
            btnSave.Size = new Size(120, 80);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Evaluation";
            btnSave.UseVisualStyleBackColor = false;

            // 
            // lblExistingEvaluations
            // 
            lblExistingEvaluations.AutoSize = true;
            lblExistingEvaluations.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingEvaluations.ForeColor = Color.MidnightBlue;
            lblExistingEvaluations.Location = new Point(27, 300);
            lblExistingEvaluations.Name = "lblExistingEvaluations";
            lblExistingEvaluations.Size = new Size(168, 23);
            lblExistingEvaluations.TabIndex = 0;
            lblExistingEvaluations.Text = "Existing Evaluations";

            // 
            // dgvEvaluations
            // 
            dgvEvaluations.AllowUserToAddRows = false;
            dgvEvaluations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEvaluations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvaluations.BackgroundColor = Color.Azure;
            dgvEvaluations.BorderStyle = BorderStyle.None;
            dgvEvaluations.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgvEvaluations.ColumnHeadersHeight = 32;
            dgvEvaluations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEvaluations.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgvEvaluations.EnableHeadersVisualStyles = false;
            dgvEvaluations.GridColor = Color.SteelBlue;
            dgvEvaluations.Location = new Point(27, 328);
            dgvEvaluations.Name = "dgvEvaluations";
            dgvEvaluations.ReadOnly = true;
            dgvEvaluations.RowHeadersVisible = false;
            dgvEvaluations.RowHeadersWidth = 51;
            dgvEvaluations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluations.Size = new Size(986, 230);
            dgvEvaluations.TabIndex = 2;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1040, 588);
            Controls.Add(lblExistingEvaluations);
            Controls.Add(dgvEvaluations);
            Controls.Add(pnlForm);
            Controls.Add(lblInterviewEvalutionTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interview Evaluation";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInterviewEvalutionTitle;
        private Panel pnlForm;
        private Label lblInterview;
        private ComboBox cmbInterview;
        private Label lblScore;
        private TextBox txtScore;
        private Label lblResult;
        private ComboBox cmbResult;
        private Label lblEvaluatedBy;
        private ComboBox cmbEvaluatedBy;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Button btnSave;
        private Label lblExistingEvaluations;
        private DataGridView dgvEvaluations;
    }
}
