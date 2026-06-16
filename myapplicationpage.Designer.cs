using System;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class MyApplicationPage
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
            openFileDialog1 = new OpenFileDialog();
            panelHeader = new Panel();
            lblTiltle = new Label();
            panelWorkspace = new Panel();
            btnBack = new Button();
            groupBox2 = new GroupBox();
            lblTranscriptPath = new Label();
            btnBrowseTranscript = new Button();
            lblResumePath = new Label();
            btnBrowseResume = new Button();
            lblResume = new Label();
            txtApplicantName = new TextBox();
            lblApplicantName = new Label();
            groupBox1 = new GroupBox();
            lblStatus = new Label();
            lblStatusLabel = new Label();
            lblJobTitle = new Label();
            lblJobTitleLabel = new Label();
            btnEdit = new Button();
            btnSubmit = new Button();
            btnSaveDraft = new Button();
            btnWithdraw = new Button();
            panelHeader.SuspendLayout();
            panelWorkspace.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.MidnightBlue;
            panelHeader.Controls.Add(lblTiltle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(953, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTiltle
            // 
            lblTiltle.AutoSize = true;
            lblTiltle.BackColor = Color.MidnightBlue;
            lblTiltle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiltle.ForeColor = SystemColors.ButtonHighlight;
            lblTiltle.Location = new Point(378, 27);
            lblTiltle.Name = "lblTiltle";
            lblTiltle.Size = new Size(242, 37);
            lblTiltle.TabIndex = 0;
            lblTiltle.Text = "MY APPLICATION";
            // 
            // panelWorkspace
            // 
            panelWorkspace.Controls.Add(btnWithdraw);
            panelWorkspace.Controls.Add(btnBack);
            panelWorkspace.Controls.Add(groupBox2);
            panelWorkspace.Controls.Add(groupBox1);
            panelWorkspace.Controls.Add(btnEdit);
            panelWorkspace.Controls.Add(btnSubmit);
            panelWorkspace.Controls.Add(btnSaveDraft);
            panelWorkspace.Dock = DockStyle.Fill;
            panelWorkspace.Location = new Point(0, 80);
            panelWorkspace.Margin = new Padding(3, 4, 3, 4);
            panelWorkspace.Name = "panelWorkspace";
            panelWorkspace.Size = new Size(953, 733);
            panelWorkspace.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MidnightBlue;
            btnBack.Font = new Font("Segoe UI", 7.5F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(263, 609);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 26);
            btnBack.TabIndex = 6;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTranscriptPath);
            groupBox2.Controls.Add(btnBrowseTranscript);
            groupBox2.Controls.Add(lblResumePath);
            groupBox2.Controls.Add(btnBrowseResume);
            groupBox2.Controls.Add(lblResume);
            groupBox2.Controls.Add(txtApplicantName);
            groupBox2.Controls.Add(lblApplicantName);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.SteelBlue;
            groupBox2.Location = new Point(29, 240);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(891, 347);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Application Form & Documents";
            // 
            // lblTranscriptPath
            // 
            lblTranscriptPath.AutoSize = true;
            lblTranscriptPath.BackColor = Color.Transparent;
            lblTranscriptPath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTranscriptPath.ForeColor = Color.DimGray;
            lblTranscriptPath.Location = new Point(434, 227);
            lblTranscriptPath.Name = "lblTranscriptPath";
            lblTranscriptPath.Size = new Size(106, 20);
            lblTranscriptPath.TabIndex = 6;
            lblTranscriptPath.Text = "No file selected";
            // 
            // btnBrowseTranscript
            // 
            btnBrowseTranscript.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowseTranscript.Location = new Point(263, 220);
            btnBrowseTranscript.Margin = new Padding(3, 4, 3, 4);
            btnBrowseTranscript.Name = "btnBrowseTranscript";
            btnBrowseTranscript.Size = new Size(149, 37);
            btnBrowseTranscript.TabIndex = 5;
            btnBrowseTranscript.Text = "Browse Transcript...";
            btnBrowseTranscript.UseVisualStyleBackColor = true;
            btnBrowseTranscript.Click += btnBrowseTranscript_Click;
            // 
            // lblResumePath
            // 
            lblResumePath.AutoSize = true;
            lblResumePath.BackColor = Color.Transparent;
            lblResumePath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResumePath.ForeColor = Color.DimGray;
            lblResumePath.Location = new Point(434, 147);
            lblResumePath.Name = "lblResumePath";
            lblResumePath.Size = new Size(106, 20);
            lblResumePath.TabIndex = 4;
            lblResumePath.Text = "No file selected";
            // 
            // btnBrowseResume
            // 
            btnBrowseResume.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowseResume.Location = new Point(263, 141);
            btnBrowseResume.Margin = new Padding(3, 4, 3, 4);
            btnBrowseResume.Name = "btnBrowseResume";
            btnBrowseResume.Size = new Size(149, 37);
            btnBrowseResume.TabIndex = 3;
            btnBrowseResume.Text = "Browse Resume...";
            btnBrowseResume.UseVisualStyleBackColor = true;
            btnBrowseResume.Click += btnBrowseResume_Click;
            // 
            // lblResume
            // 
            lblResume.AutoSize = true;
            lblResume.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResume.Location = new Point(23, 147);
            lblResume.Name = "lblResume";
            lblResume.Size = new Size(247, 25);
            lblResume.TabIndex = 2;
            lblResume.Text = "Attach Resume (PDF/DOCX):";
            // 
            // txtApplicantName
            // 
            txtApplicantName.Location = new Point(263, 60);
            txtApplicantName.Margin = new Padding(3, 4, 3, 4);
            txtApplicantName.Name = "txtApplicantName";
            txtApplicantName.Size = new Size(285, 30);
            txtApplicantName.TabIndex = 1;
            // 
            // lblApplicantName
            // 
            lblApplicantName.AutoSize = true;
            lblApplicantName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicantName.Location = new Point(23, 60);
            lblApplicantName.Name = "lblApplicantName";
            lblApplicantName.Size = new Size(101, 25);
            lblApplicantName.TabIndex = 0;
            lblApplicantName.Text = "Full Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(lblStatusLabel);
            groupBox1.Controls.Add(lblJobTitle);
            groupBox1.Controls.Add(lblJobTitleLabel);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(29, 27);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(891, 187);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current Job Application Details";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkOrange;
            lblStatus.Location = new Point(186, 113);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(217, 25);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "No Application Started";
            // 
            // lblStatusLabel
            // 
            lblStatusLabel.AutoSize = true;
            lblStatusLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusLabel.Location = new Point(23, 113);
            lblStatusLabel.Name = "lblStatusLabel";
            lblStatusLabel.Size = new Size(167, 25);
            lblStatusLabel.TabIndex = 2;
            lblStatusLabel.Text = "Application Status:";
            // 
            // lblJobTitle
            // 
            lblJobTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblJobTitle.ForeColor = Color.SteelBlue;
            lblJobTitle.Location = new Point(186, 53);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(175, 31);
            lblJobTitle.TabIndex = 4;
            lblJobTitle.Text = "(No Job Selected)";
            // 
            // lblJobTitleLabel
            // 
            lblJobTitleLabel.Font = new Font("Segoe UI", 10F);
            lblJobTitleLabel.ForeColor = Color.Black;
            lblJobTitleLabel.Location = new Point(33, 55);
            lblJobTitleLabel.Name = "lblJobTitleLabel";
            lblJobTitleLabel.Size = new Size(157, 31);
            lblJobTitleLabel.TabIndex = 5;
            lblJobTitleLabel.Text = "Target Position:";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(524, 653);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(153, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Application";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.ForestGreen;
            btnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(348, 595);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(206, 51);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit Application";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSaveDraft
            // 
            btnSaveDraft.BackColor = Color.White;
            btnSaveDraft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveDraft.Location = new Point(390, 654);
            btnSaveDraft.Margin = new Padding(3, 4, 3, 4);
            btnSaveDraft.Name = "btnSaveDraft";
            btnSaveDraft.Size = new Size(117, 39);
            btnSaveDraft.TabIndex = 3;
            btnSaveDraft.Text = "Save Draft";
            btnSaveDraft.UseVisualStyleBackColor = false;
            btnSaveDraft.Click += btnSaveDraft_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 9.75F);
            btnWithdraw.Location = new Point(215, 653);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(153, 40);
            btnWithdraw.TabIndex = 7;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // MyApplicationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(953, 813);
            Controls.Add(panelWorkspace);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyApplicationPage";
            Text = "My Application Page";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelWorkspace.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Panel panelHeader;
        private Label lblTiltle;
        private Panel panelWorkspace;
        private Button btnSaveDraft;
        private Button btnSubmit;
        private Button btnEdit;
        private GroupBox groupBox1;
        private Label lblStatus;
        private Label lblStatusLabel;
        private Label lblJobTitle;
        private Label lblJobTitleLabel;
        private GroupBox groupBox2;
        private Button btnBrowseResume;
        private Label lblResume;
        private TextBox txtApplicantName;
        private Label lblApplicantName;
        private Label lblResumePath;
        private Button btnBrowseTranscript;
        private Label lblTranscriptPath;
        private Button btnBack;
        private Button btnWithdraw;
    }
}