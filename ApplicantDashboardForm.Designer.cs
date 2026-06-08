namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class ApplicantDashboardForm
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
            lvlWelcome = new Label();
            grpStatus = new GroupBox();
            lblDateApplied = new Label();
            label3 = new Label();
            lblStatus = new Label();
            label2 = new Label();
            lblJobTitle = new Label();
            label1 = new Label();
            btnGoToProfile = new Button();
            grpRequirements = new GroupBox();
            button1 = new Button();
            lblMissingDocsCount = new Label();
            label5 = new Label();
            lblMissingDocsStatus = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            lblInterviewLocation = new Label();
            label8 = new Label();
            lblInterviewerName = new Label();
            label7 = new Label();
            lblInterviewDateTime = new Label();
            label6 = new Label();
            grpStatus.SuspendLayout();
            grpRequirements.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvlWelcome
            // 
            lvlWelcome.AutoSize = true;
            lvlWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lvlWelcome.Location = new Point(75, 50);
            lvlWelcome.Name = "lvlWelcome";
            lvlWelcome.Size = new Size(289, 38);
            lvlWelcome.TabIndex = 0;
            lvlWelcome.Text = "Welcome, Applicant!";
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(lblDateApplied);
            grpStatus.Controls.Add(label3);
            grpStatus.Controls.Add(lblStatus);
            grpStatus.Controls.Add(label2);
            grpStatus.Controls.Add(lblJobTitle);
            grpStatus.Controls.Add(label1);
            grpStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            grpStatus.Location = new Point(75, 139);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(500, 244);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Your Application Status";
            // 
            // lblDateApplied
            // 
            lblDateApplied.AutoSize = true;
            lblDateApplied.Font = new Font("Segoe UI", 9F);
            lblDateApplied.Location = new Point(19, 181);
            lblDateApplied.Name = "lblDateApplied";
            lblDateApplied.Size = new Size(86, 20);
            lblDateApplied.TabIndex = 5;
            lblDateApplied.Text = "[Loading... ]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(19, 158);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 4;
            label3.Text = "Date Submitted:";
            label3.Click += label3_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(19, 129);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "[Loading... ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(19, 106);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 2;
            label2.Text = "Application Status:";
            label2.Click += label2_Click;
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 9F);
            lblJobTitle.Location = new Point(19, 67);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(86, 20);
            lblJobTitle.TabIndex = 1;
            lblJobTitle.Text = "[Loading... ]";
            lblJobTitle.Click += lblJobTitle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(16, 44);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "Position Applied:";
            // 
            // btnGoToProfile
            // 
            btnGoToProfile.FlatStyle = FlatStyle.Flat;
            btnGoToProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToProfile.Location = new Point(911, 82);
            btnGoToProfile.Name = "btnGoToProfile";
            btnGoToProfile.Size = new Size(210, 34);
            btnGoToProfile.TabIndex = 3;
            btnGoToProfile.Text = "VIEW / EDIT PROFILE";
            btnGoToProfile.UseVisualStyleBackColor = true;
            btnGoToProfile.Click += btnGoToProfile_Click_1;
            // 
            // grpRequirements
            // 
            grpRequirements.Controls.Add(button1);
            grpRequirements.Controls.Add(lblMissingDocsCount);
            grpRequirements.Controls.Add(label5);
            grpRequirements.Controls.Add(lblMissingDocsStatus);
            grpRequirements.Controls.Add(label4);
            grpRequirements.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            grpRequirements.Location = new Point(620, 139);
            grpRequirements.Name = "grpRequirements";
            grpRequirements.Size = new Size(501, 244);
            grpRequirements.TabIndex = 2;
            grpRequirements.TabStop = false;
            grpRequirements.Text = "Requirements Summary";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(24, 181);
            button1.Name = "button1";
            button1.Size = new Size(252, 30);
            button1.TabIndex = 4;
            button1.Text = "GO TO MY DOCUMENTS PAGE";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblMissingDocsCount
            // 
            lblMissingDocsCount.AutoSize = true;
            lblMissingDocsCount.Font = new Font("Segoe UI", 9F);
            lblMissingDocsCount.Location = new Point(24, 129);
            lblMissingDocsCount.Name = "lblMissingDocsCount";
            lblMissingDocsCount.Size = new Size(86, 20);
            lblMissingDocsCount.TabIndex = 3;
            lblMissingDocsCount.Text = "[Loading... ]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(24, 106);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 2;
            label5.Text = "Actions Needed:";
            // 
            // lblMissingDocsStatus
            // 
            lblMissingDocsStatus.AutoSize = true;
            lblMissingDocsStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMissingDocsStatus.Location = new Point(24, 67);
            lblMissingDocsStatus.Name = "lblMissingDocsStatus";
            lblMissingDocsStatus.Size = new Size(86, 20);
            lblMissingDocsStatus.TabIndex = 1;
            lblMissingDocsStatus.Text = "[Loading... ]";
            lblMissingDocsStatus.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(24, 44);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 0;
            label4.Text = "Status:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblInterviewLocation);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblInterviewerName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblInterviewDateTime);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(75, 404);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 230);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "UPCOMING INTERVIEW SCHEDULE";
            // 
            // lblInterviewLocation
            // 
            lblInterviewLocation.AutoSize = true;
            lblInterviewLocation.Font = new Font("Segoe UI", 9F);
            lblInterviewLocation.Location = new Point(29, 198);
            lblInterviewLocation.Name = "lblInterviewLocation";
            lblInterviewLocation.Size = new Size(36, 20);
            lblInterviewLocation.TabIndex = 5;
            lblInterviewLocation.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(23, 165);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 4;
            label8.Text = "Mode / Location:";
            // 
            // lblInterviewerName
            // 
            lblInterviewerName.AutoSize = true;
            lblInterviewerName.Font = new Font("Segoe UI", 9F);
            lblInterviewerName.Location = new Point(29, 136);
            lblInterviewerName.Name = "lblInterviewerName";
            lblInterviewerName.Size = new Size(36, 20);
            lblInterviewerName.TabIndex = 3;
            lblInterviewerName.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(23, 101);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 2;
            label7.Text = "Interviewer:";
            // 
            // lblInterviewDateTime
            // 
            lblInterviewDateTime.AutoSize = true;
            lblInterviewDateTime.Font = new Font("Segoe UI", 9F);
            lblInterviewDateTime.Location = new Point(23, 68);
            lblInterviewDateTime.Name = "lblInterviewDateTime";
            lblInterviewDateTime.Size = new Size(208, 20);
            lblInterviewDateTime.TabIndex = 1;
            lblInterviewDateTime.Text = "[ No Interview Scheduled Yet ]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(23, 35);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 0;
            label6.Text = "Date + Time:";
            label6.Click += label6_Click;
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(groupBox1);
            Controls.Add(btnGoToProfile);
            Controls.Add(grpRequirements);
            Controls.Add(grpStatus);
            Controls.Add(lvlWelcome);
            Name = "ApplicantDashboardForm";
            Text = "Applicant Dashboard";
            Load += ApplicantDashboardForm_Load_1;
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            grpRequirements.ResumeLayout(false);
            grpRequirements.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lvlWelcome;
        private GroupBox grpStatus;
        private Button btnGoToProfile;
        private Label label1;
        private Label lblStatus;
        private Label label2;
        private Label lblJobTitle;
        private Label lblDateApplied;
        private Label label3;
        private GroupBox grpRequirements;
        private GroupBox groupBox1;
        private Label lblMissingDocsStatus;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label lblMissingDocsCount;
        private Label label6;
        private Label lblInterviewDateTime;
        private Label lblInterviewLocation;
        private Label label8;
        private Label lblInterviewerName;
        private Label label7;
    }
}