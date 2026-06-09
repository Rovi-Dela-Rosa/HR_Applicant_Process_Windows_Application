namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class ApplicantProfileForm
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
            lblTitle = new Label();
            grpPersonalInfo = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            grpContact = new GroupBox();
            txtAddress = new TextBox();
            label7 = new Label();
            txtContactNumber = new TextBox();
            label4 = new Label();
            grpEducation = new GroupBox();
            groupBox1 = new GroupBox();
            txtEducation = new TextBox();
            label5 = new Label();
            grpSkills = new GroupBox();
            txtWrkExp = new TextBox();
            label13 = new Label();
            txtSkills = new TextBox();
            label12 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            grpPersonalInfo.SuspendLayout();
            grpContact.SuspendLayout();
            grpEducation.SuspendLayout();
            grpSkills.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(393, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Profile";
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(dtpDateOfBirth);
            grpPersonalInfo.Controls.Add(label3);
            grpPersonalInfo.Controls.Add(txtLastName);
            grpPersonalInfo.Controls.Add(label2);
            grpPersonalInfo.Controls.Add(txtFirstName);
            grpPersonalInfo.Controls.Add(label1);
            grpPersonalInfo.Location = new Point(58, 76);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(850, 122);
            grpPersonalInfo.TabIndex = 1;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Personal Information";
            grpPersonalInfo.Enter += grpPersonalInfo_Enter;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(582, 72);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 5;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 49);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(213, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 27);
            txtLastName.TabIndex = 3;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 49);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(17, 74);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // grpContact
            // 
            grpContact.Controls.Add(txtAddress);
            grpContact.Controls.Add(label7);
            grpContact.Controls.Add(txtContactNumber);
            grpContact.Controls.Add(label4);
            grpContact.Location = new Point(58, 204);
            grpContact.Name = "grpContact";
            grpContact.Size = new Size(850, 117);
            grpContact.TabIndex = 2;
            grpContact.TabStop = false;
            grpContact.Text = "Contact Information";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(213, 71);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(619, 27);
            txtAddress.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 48);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 4;
            label7.Text = "Address:";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(17, 71);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(150, 27);
            txtContactNumber.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 48);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 0;
            label4.Text = "Contact Number:";
            // 
            // grpEducation
            // 
            grpEducation.Controls.Add(groupBox1);
            grpEducation.Controls.Add(txtEducation);
            grpEducation.Controls.Add(label5);
            grpEducation.Location = new Point(58, 327);
            grpEducation.Name = "grpEducation";
            grpEducation.Size = new Size(443, 110);
            grpEducation.TabIndex = 3;
            grpEducation.TabStop = false;
            grpEducation.Text = "Education";
            grpEducation.Enter += grpEducation_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(262, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtEducation
            // 
            txtEducation.Location = new Point(17, 65);
            txtEducation.Name = "txtEducation";
            txtEducation.Size = new Size(407, 27);
            txtEducation.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 42);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 0;
            label5.Text = "Highest Education:";
            // 
            // grpSkills
            // 
            grpSkills.Controls.Add(txtWrkExp);
            grpSkills.Controls.Add(label13);
            grpSkills.Location = new Point(521, 327);
            grpSkills.Name = "grpSkills";
            grpSkills.Size = new Size(387, 245);
            grpSkills.TabIndex = 4;
            grpSkills.TabStop = false;
            grpSkills.Text = "Work Experience";
            // 
            // txtWrkExp
            // 
            txtWrkExp.Location = new Point(15, 74);
            txtWrkExp.Multiline = true;
            txtWrkExp.Name = "txtWrkExp";
            txtWrkExp.Size = new Size(354, 153);
            txtWrkExp.TabIndex = 3;
            txtWrkExp.TextChanged += txtWrkExp_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 42);
            label13.Name = "label13";
            label13.Size = new Size(122, 20);
            label13.TabIndex = 2;
            label13.Text = "Work Experience:";
            // 
            // txtSkills
            // 
            txtSkills.Location = new Point(14, 55);
            txtSkills.Multiline = true;
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(412, 52);
            txtSkills.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 32);
            label12.Name = "label12";
            label12.Size = new Size(45, 20);
            label12.TabIndex = 0;
            label12.Text = "Skills:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Location = new Point(814, 595);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Honeydew;
            btnUpdate.Location = new Point(705, 595);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSkills);
            groupBox2.Location = new Point(56, 447);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Skills";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Azure;
            btnBack.Location = new Point(58, 595);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ApplicantProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(982, 653);
            Controls.Add(btnBack);
            Controls.Add(groupBox2);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(grpSkills);
            Controls.Add(grpEducation);
            Controls.Add(grpContact);
            Controls.Add(grpPersonalInfo);
            Controls.Add(lblTitle);
            Name = "ApplicantProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Profile";
            Load += ApplicantProfileForm_Load;
            Click += ApplicantProfileForm_Click;
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpContact.ResumeLayout(false);
            grpContact.PerformLayout();
            grpEducation.ResumeLayout(false);
            grpEducation.PerformLayout();
            grpSkills.ResumeLayout(false);
            grpSkills.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpPersonalInfo;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private GroupBox grpContact;
        private TextBox txtContactNumber;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtMiddleName;
        private Label label6;
        private Label label7;
        private TextBox txtAddress;
        private GroupBox grpEducation;
        private Label label8;
        private GroupBox grpSkills;
        private TextBox txtYearGraduated;
        private Label label10;
        private TextBox txtDegree;
        private Label label9;
        private TextBox txtSchoolName;
        private TextBox txtAwards;
        private Label label11;
        private TextBox txtWrkExp;
        private Label label13;
        private TextBox txtSkills;
        private Label label12;
        private Button btnSave;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private TextBox txtEducation;
        private GroupBox groupBox2;
        private Button btnBack;
    }
}