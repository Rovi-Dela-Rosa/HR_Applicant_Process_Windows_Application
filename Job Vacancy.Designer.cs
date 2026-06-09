
using System.Drawing;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class JobVacancies
    {

        private System.ComponentModel.IContainer components = null;


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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            lblTitle = new Label();
            lblSearch = new Label();
            label3 = new Label();
            txtSearch = new TextBox();
            label9 = new Label();
            grpDetails = new GroupBox();
            lblPosition = new Label();
            lblDepartment = new Label();
            lblType = new Label();
            lblQualifications = new Label();
            lblDocuments = new Label();
            groupBox2 = new GroupBox();
            lblJobCount = new Label();
            dgvJobs = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            searchPanel = new Panel();
            btnSearch = new Button();
            btnApply = new Button();
            btnRefresh = new Button();
            btnExit = new Button();
            headerPanel.SuspendLayout();
            grpDetails.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.WhiteSmoke;
            headerPanel.BackgroundImageLayout = ImageLayout.None;
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(982, 100);
            headerPanel.TabIndex = 0;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Job Vacancies";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(20, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(71, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(6, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 0;
            label3.Text = "Open Job Positions";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(110, 22);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(20, 525);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 5;
            label9.Text = "Job Details";
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.White;
            grpDetails.Controls.Add(lblPosition);
            grpDetails.Controls.Add(lblDepartment);
            grpDetails.Controls.Add(lblType);
            grpDetails.Controls.Add(lblQualifications);
            grpDetails.Controls.Add(lblDocuments);
            grpDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDetails.ForeColor = Color.FromArgb(0, 102, 204);
            grpDetails.Location = new Point(20, 569);
            grpDetails.Margin = new Padding(3, 4, 3, 4);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(3, 4, 3, 4);
            grpDetails.Size = new Size(900, 225);
            grpDetails.TabIndex = 6;
            grpDetails.TabStop = false;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10F);
            lblPosition.Location = new Point(20, 38);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(0, 23);
            lblPosition.TabIndex = 0;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 10F);
            lblDepartment.Location = new Point(20, 75);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(0, 23);
            lblDepartment.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10F);
            lblType.Location = new Point(20, 112);
            lblType.Name = "lblType";
            lblType.Size = new Size(150, 23);
            lblType.TabIndex = 2;
            lblType.Text = "Employment Type:";
            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Font = new Font("Segoe UI", 10F);
            lblQualifications.Location = new Point(20, 150);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Size = new Size(117, 23);
            lblQualifications.TabIndex = 3;
            lblQualifications.Text = "Qualifications:";
            // 
            // lblDocuments
            // 
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 10F);
            lblDocuments.Location = new Point(20, 188);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(174, 23);
            lblDocuments.TabIndex = 4;
            lblDocuments.Text = "Required Documents:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblJobCount);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dgvJobs);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(0, 102, 204);
            groupBox2.Location = new Point(20, 194);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(900, 325);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // lblJobCount
            // 
            lblJobCount.Location = new Point(700, 12);
            lblJobCount.Name = "lblJobCount";
            lblJobCount.Size = new Size(100, 29);
            lblJobCount.TabIndex = 0;
            lblJobCount.Text = "Total Jobs: 15";
            // 
            // dgvJobs
            // 
            dgvJobs.BackgroundColor = Color.White;
            dgvJobs.BorderStyle = BorderStyle.None;
            dgvJobs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 118, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobs.ColumnHeadersHeight = 30;
            dgvJobs.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 102, 204);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvJobs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvJobs.EnableHeadersVisualStyles = false;
            dgvJobs.GridColor = Color.LightGray;
            dgvJobs.Location = new Point(15, 44);
            dgvJobs.Margin = new Padding(3, 4, 3, 4);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.RowTemplate.Height = 28;
            dgvJobs.Size = new Size(856, 175);
            dgvJobs.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Job ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Position";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Department";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Type";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.BorderStyle = BorderStyle.FixedSingle;
            searchPanel.Controls.Add(lblSearch);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Location = new Point(20, 106);
            searchPanel.Margin = new Padding(3, 4, 3, 4);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(900, 68);
            searchPanel.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 120, 215);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(310, 19);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(0, 120, 215);
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(20, 812);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(100, 44);
            btnApply.TabIndex = 7;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(30, 144, 255);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(140, 812);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 44);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(220, 53, 69);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(260, 812);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 44);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // JobVacancies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(982, 918);
            Controls.Add(searchPanel);
            Controls.Add(grpDetails);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(headerPanel);
            Controls.Add(btnApply);
            Controls.Add(btnRefresh);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "JobVacancies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Vacancies";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private Panel headerPanel;
        private Panel searchPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRefresh;
        private Label lblPosition;
        private Label lblDepartment;
        private Label lblJobCount;
        private Label lblType;
        private Label lblQualifications;
        private Label lblDocuments;
        private Button btnExit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

