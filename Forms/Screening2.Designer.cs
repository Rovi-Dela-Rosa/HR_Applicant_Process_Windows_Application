namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class Screening2
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
            dgvScreening = new DataGridView();
            btnSave = new Button();
            cboStatus = new ComboBox();
            txtRemarks = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxScreening = new GroupBox();
            linkLabel1 = new LinkLabel();
            mySqlCommandBuilder1 = new MySql.Data.MySqlClient.MySqlCommandBuilder();
            cmbApplicant2 = new ComboBox();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgvScreening).BeginInit();
            groupBoxScreening.SuspendLayout();
            SuspendLayout();
            // 
            // dgvScreening
            // 
            dgvScreening.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvScreening.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScreening.Location = new Point(-3, 427);
            dgvScreening.Margin = new Padding(5, 4, 5, 4);
            dgvScreening.MultiSelect = false;
            dgvScreening.Name = "dgvScreening";
            dgvScreening.RowHeadersWidth = 51;
            dgvScreening.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScreening.Size = new Size(1065, 231);
            dgvScreening.TabIndex = 22;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(446, 302);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 44);
            btnSave.TabIndex = 20;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSubmit_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Qualified", "NotQualified" });
            cboStatus.Location = new Point(208, 163);
            cboStatus.Margin = new Padding(5, 4, 5, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(199, 28);
            cboStatus.TabIndex = 19;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // txtRemarks
            // 
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.Location = new Point(208, 217);
            txtRemarks.Margin = new Padding(5, 4, 5, 4);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(351, 64);
            txtRemarks.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(29, 228);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 17;
            label3.Text = "Remarks:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(29, 163);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 16;
            label2.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(29, 104);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 15;
            label1.Text = "Applicant Username:";
            // 
            // groupBoxScreening
            // 
            groupBoxScreening.BackColor = Color.MidnightBlue;
            groupBoxScreening.Controls.Add(linkLabel1);
            groupBoxScreening.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxScreening.ForeColor = Color.Azure;
            groupBoxScreening.Location = new Point(-3, 3);
            groupBoxScreening.Margin = new Padding(5, 4, 5, 4);
            groupBoxScreening.Name = "groupBoxScreening";
            groupBoxScreening.Padding = new Padding(5, 4, 5, 4);
            groupBoxScreening.Size = new Size(1065, 68);
            groupBoxScreening.TabIndex = 14;
            groupBoxScreening.TabStop = false;
            groupBoxScreening.Text = "Screening Evaluation";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.SteelBlue;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.SteelBlue;
            linkLabel1.Location = new Point(8, 43);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 20);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += Back;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // cmbApplicant2
            // 
            cmbApplicant2.FormattingEnabled = true;
            cmbApplicant2.Location = new Point(208, 103);
            cmbApplicant2.Margin = new Padding(3, 4, 3, 4);
            cmbApplicant2.Name = "cmbApplicant2";
            cmbApplicant2.Size = new Size(199, 28);
            cmbApplicant2.TabIndex = 25;
            // 
            // Screening2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1061, 660);
            Controls.Add(dgvScreening);
            Controls.Add(btnSave);
            Controls.Add(cboStatus);
            Controls.Add(txtRemarks);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBoxScreening);
            Controls.Add(cmbApplicant2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Screening2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screening";
            ((System.ComponentModel.ISupportInitialize)dgvScreening).EndInit();
            groupBoxScreening.ResumeLayout(false);
            groupBoxScreening.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvScreening;
        private Button btnSave;
        private ComboBox cboStatus;
        private TextBox txtRemarks;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxScreening;
        private MySql.Data.MySqlClient.MySqlCommandBuilder mySqlCommandBuilder1;
        private ComboBox cmbApplicant2;
        private ColorDialog colorDialog1;
        private LinkLabel linkLabel1;
    }
}