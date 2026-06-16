using HR_Applicant_Process_Windows_System_MAIN.Database;
using HR_Applicant_Process_Windows_System_MAIN.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class ApplicantDashboardForm : Form
    {
        private int loggedInAccountID;
        private int realApplicantID;
        public ApplicantDashboardForm(int accountID)
        {
            InitializeComponent();
            this.loggedInAccountID = accountID;

            // ACTIVE BUTTON
            btnDashboard.BackColor = Color.SteelBlue;
            btnDashboard.ForeColor = Color.White;

            // INACTIVE BUTTON
            btnProfile.BackColor = Color.MidnightBlue;
            btnProfile.ForeColor = Color.White;

            // Logout
            btnProfile.BackColor = Color.FromArgb(25, 25, 112);
            btnLogout.BackColor = Color.FromArgb(25, 25, 112);

            pnlStatusCard.BackColor = Color.White;
            pnlDocsCard.BackColor = Color.White;
            pnlInterview.BackColor = Color.White;
            pnlUpdates.BackColor = Color.White;

            RoundButton(btnProfile, 15);
            RoundButton(btnLogout, 15);
            RoundButton(btnDashboard, 15);

            RoundPanel(pnlStatusCard, 25);
            RoundPanel(pnlDocsCard, 25);
            RoundPanel(pnlInterview, 25);
            RoundPanel(pnlUpdates, 25);
        }
        private void LoadApplicantProfileAndSummary()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string profileQuery = @"SELECT ApplicantID, FirstName, LastName FROM Applicants WHERE AccountID = @AccountID";
                    using (MySqlCommand cmd = new MySqlCommand(profileQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", this.loggedInAccountID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.realApplicantID = Convert.ToInt32(reader["ApplicantID"]);
                                string firstName = reader["FirstName"].ToString();
                                lblWelcome.Text = $"Welcome Back, {firstName}!";

                                btnJobVacancy.Enabled = true;
                                btnMyApplication.Enabled = true;
                                btnMyDocuments.Enabled = true;
                                btnApplicationStatus.Enabled = true;
                            }
                            else
                            {
                                this.realApplicantID = 0;
                                lblWelcome.Text = "Welcome, New Applicant!";

                                btnJobVacancy.Enabled = false;
                                btnMyApplication.Enabled = false;
                                btnMyDocuments.Enabled = false;
                                btnApplicationStatus.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error loading profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnApplicationStatus = new Button();
            btnMyDocuments = new Button();
            btnMyApplication = new Button();
            btnJobVacancy = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            btnProfile = new Button();
            panel2 = new Panel();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlUpdates = new Panel();
            lstRecentUpdates = new ListBox();
            label4 = new Label();
            pnlInterview = new Panel();
            lblInterviewLocation = new Label();
            lblInterviewTime = new Label();
            lblInterviewDate = new Label();
            label2 = new Label();
            pnlDocsCard = new Panel();
            lstMissingDocuments = new ListBox();
            label3 = new Label();
            pnlStatusCard = new Panel();
            lblCurrentStatus = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mySqlCommand1 = new MySqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlUpdates.SuspendLayout();
            pnlInterview.SuspendLayout();
            pnlDocsCard.SuspendLayout();
            pnlStatusCard.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 0;
            label1.Text = "Applicant Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnApplicationStatus);
            panel1.Controls.Add(btnMyDocuments);
            panel1.Controls.Add(btnMyApplication);
            panel1.Controls.Add(btnJobVacancy);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 753);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // btnApplicationStatus
            // 
            btnApplicationStatus.ForeColor = Color.White;
            btnApplicationStatus.Location = new Point(30, 365);
            btnApplicationStatus.Name = "btnApplicationStatus";
            btnApplicationStatus.Size = new Size(183, 33);
            btnApplicationStatus.TabIndex = 7;
            btnApplicationStatus.Text = "Application Status";
            btnApplicationStatus.UseVisualStyleBackColor = false;
            btnApplicationStatus.Click += btnApplicationStatus_Click;
            // 
            // btnMyDocuments
            // 
            btnMyDocuments.ForeColor = Color.White;
            btnMyDocuments.Location = new Point(31, 313);
            btnMyDocuments.Name = "btnMyDocuments";
            btnMyDocuments.Size = new Size(182, 33);
            btnMyDocuments.TabIndex = 6;
            btnMyDocuments.Text = "My Documents";
            btnMyDocuments.UseVisualStyleBackColor = false;
            btnMyDocuments.Click += btnMyDocuments_Click;
            // 
            // btnMyApplication
            // 
            btnMyApplication.ForeColor = Color.White;
            btnMyApplication.Location = new Point(31, 260);
            btnMyApplication.Name = "btnMyApplication";
            btnMyApplication.Size = new Size(182, 33);
            btnMyApplication.TabIndex = 5;
            btnMyApplication.Text = "My Application";
            btnMyApplication.UseVisualStyleBackColor = false;
            btnMyApplication.Click += btnMyApplication_Click;
            // 
            // btnJobVacancy
            // 
            btnJobVacancy.ForeColor = Color.White;
            btnJobVacancy.Location = new Point(31, 211);
            btnJobVacancy.Name = "btnJobVacancy";
            btnJobVacancy.Size = new Size(182, 33);
            btnJobVacancy.TabIndex = 4;
            btnJobVacancy.Text = "Job Vacancy";
            btnJobVacancy.UseVisualStyleBackColor = false;
            btnJobVacancy.Click += btnJobVacancy_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SteelBlue;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(31, 105);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(182, 33);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button3_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(31, 418);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(182, 33);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button2_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.MidnightBlue;
            btnProfile.ForeColor = SystemColors.ControlText;
            btnProfile.Location = new Point(31, 159);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(182, 33);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSubtitle);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pnlUpdates);
            panel2.Controls.Add(pnlInterview);
            panel2.Controls.Add(pnlDocsCard);
            panel2.Controls.Add(pnlStatusCard);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 753);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(34, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(312, 20);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Here's the latest summary of your application.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlText;
            lblWelcome.Location = new Point(34, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(289, 38);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome, Applicant!";
            // 
            // pnlUpdates
            // 
            pnlUpdates.BackColor = Color.GhostWhite;
            pnlUpdates.Controls.Add(lstRecentUpdates);
            pnlUpdates.Controls.Add(label4);
            pnlUpdates.Location = new Point(34, 405);
            pnlUpdates.Name = "pnlUpdates";
            pnlUpdates.Size = new Size(830, 336);
            pnlUpdates.TabIndex = 3;
            // 
            // lstRecentUpdates
            // 
            lstRecentUpdates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRecentUpdates.FormattingEnabled = true;
            lstRecentUpdates.Location = new Point(18, 44);
            lstRecentUpdates.Margin = new Padding(15);
            lstRecentUpdates.Name = "lstRecentUpdates";
            lstRecentUpdates.Size = new Size(786, 264);
            lstRecentUpdates.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 19);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 0;
            label4.Text = "Recent Updates";
            // 
            // pnlInterview
            // 
            pnlInterview.BackColor = Color.GhostWhite;
            pnlInterview.Controls.Add(lblInterviewLocation);
            pnlInterview.Controls.Add(lblInterviewTime);
            pnlInterview.Controls.Add(lblInterviewDate);
            pnlInterview.Controls.Add(label2);
            pnlInterview.Location = new Point(34, 269);
            pnlInterview.Name = "pnlInterview";
            pnlInterview.Size = new Size(830, 118);
            pnlInterview.TabIndex = 2;
            pnlInterview.Paint += pnlInterview_Paint;
            // 
            // lblInterviewLocation
            // 
            lblInterviewLocation.AutoSize = true;
            lblInterviewLocation.Location = new Point(326, 50);
            lblInterviewLocation.Name = "lblInterviewLocation";
            lblInterviewLocation.Size = new Size(69, 20);
            lblInterviewLocation.TabIndex = 3;
            lblInterviewLocation.Text = "Location:";
            // 
            // lblInterviewTime
            // 
            lblInterviewTime.AutoSize = true;
            lblInterviewTime.Location = new Point(19, 82);
            lblInterviewTime.Name = "lblInterviewTime";
            lblInterviewTime.Size = new Size(45, 20);
            lblInterviewTime.TabIndex = 2;
            lblInterviewTime.Text = "Time:";
            // 
            // lblInterviewDate
            // 
            lblInterviewDate.AutoSize = true;
            lblInterviewDate.Location = new Point(19, 50);
            lblInterviewDate.Name = "lblInterviewDate";
            lblInterviewDate.Size = new Size(44, 20);
            lblInterviewDate.TabIndex = 1;
            lblInterviewDate.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 0;
            label2.Text = "Interview Schedule";
            // 
            // pnlDocsCard
            // 
            pnlDocsCard.BackColor = Color.GhostWhite;
            pnlDocsCard.Controls.Add(lstMissingDocuments);
            pnlDocsCard.Controls.Add(label3);
            pnlDocsCard.Location = new Point(426, 105);
            pnlDocsCard.Name = "pnlDocsCard";
            pnlDocsCard.Size = new Size(438, 139);
            pnlDocsCard.TabIndex = 1;
            // 
            // lstMissingDocuments
            // 
            lstMissingDocuments.FormattingEnabled = true;
            lstMissingDocuments.Location = new Point(17, 54);
            lstMissingDocuments.Name = "lstMissingDocuments";
            lstMissingDocuments.Size = new Size(302, 64);
            lstMissingDocuments.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 18);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 0;
            label3.Text = "Missing Documents";
            // 
            // pnlStatusCard
            // 
            pnlStatusCard.BackColor = Color.GhostWhite;
            pnlStatusCard.Controls.Add(lblCurrentStatus);
            pnlStatusCard.Location = new Point(34, 105);
            pnlStatusCard.Name = "pnlStatusCard";
            pnlStatusCard.Size = new Size(386, 139);
            pnlStatusCard.TabIndex = 0;
            pnlStatusCard.Paint += panel3_Paint;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(18, 18);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(110, 20);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1126, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ApplicantDashboardForm";
            Text = "Applicant Dashboard";
            Load += ApplicantDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlUpdates.ResumeLayout(false);
            pnlUpdates.PerformLayout();
            pnlInterview.ResumeLayout(false);
            pnlInterview.PerformLayout();
            pnlDocsCard.ResumeLayout(false);
            pnlDocsCard.PerformLayout();
            pnlStatusCard.ResumeLayout(false);
            pnlStatusCard.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Panel panel1;
        private Button btnProfile;
        private Panel panel2;
        private Button btnLogout;
        private Button btnDashboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void RoundPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            pnl.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Dashboard.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Panel pnlStatusCard;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel pnlDocsCard;
        private Label label3;
        private Label lblCurrentStatus;
        private Label lblStatus;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel pnlUpdates;
        private Panel pnlInterview;
        private Label label2;
        private ListBox lstRecentUpdates;
        private Label label4;
        private Label lblWelcome;

        private void pnlInterview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadCurrentStatus()
        {
            lstMissingDocuments.Items.Clear();
            lstRecentUpdates.Items.Clear();

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string statusQuery = @"SELECT CurrentStatus, ApplicationID FROM Applications WHERE ApplicantID = @ApplicantID LIMIT 1";
                    int applicationID = 0;

                    using (MySqlCommand cmd = new MySqlCommand(statusQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", this.realApplicantID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblCurrentStatus.Text = $"Current Status: {reader["CurrentStatus"]}";
                                applicationID = Convert.ToInt32(reader["ApplicationID"]);
                            }
                            else
                            {
                                lblCurrentStatus.Text = "Current Status: No Active Application";
                            }
                        }
                    }

                    string docsQuery = @"
                    SELECT RequirementName
                    FROM RequirementTypes
                    WHERE RequirementTypeID NOT IN
                    (
                        SELECT RequirementTypeID
                        FROM ApplicantDocuments
                        WHERE ApplicantID = @ApplicantID
                    )";

                    using (MySqlCommand cmd = new MySqlCommand(docsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", this.realApplicantID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstMissingDocuments.Items.Add(reader["RequirementName"].ToString());
                            }
                        }
                    }

                    if (applicationID == 0)
                    {
                        lstMissingDocuments.Items.Add("No active application.");
                    }
                    else if (lstMissingDocuments.Items.Count == 0)
                    {
                        lstMissingDocuments.Items.Add("All required documents submitted.");
                    }

                    string interviewQuery = @"SELECT i.InterviewDate, i.Location, t.TypeName FROM InterviewSchedules i
                                             INNER JOIN InterviewTypes t ON i.InterviewTypeID = t.InterviewTypeID
                                             WHERE i.ApplicationID = @ApplicationID AND i.Status = 'Scheduled' LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(interviewQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime schedDate = Convert.ToDateTime(reader["InterviewDate"]);
                                lblInterviewDate.Text = $"Date: {schedDate.ToString("MMMM dd, yyyy")}";
                                lblInterviewTime.Text = $"Time: {schedDate.ToString("hh:mm tt")}";
                                lblInterviewLocation.Text = $"Location: {reader["Location"]} ({reader["TypeName"]})";
                            }
                            else
                            {
                                lblInterviewDate.Text = "Date: No interview scheduled yet.";
                                lblInterviewTime.Text = "Time: --:--";
                                lblInterviewLocation.Text = "Location: ----";
                            }
                        }
                    }

                    string historyQuery = @"SELECT Status, Remarks, ChangedAt FROM ApplicationStatusHistory 
                                            WHERE ApplicationID = @ApplicationID ORDER BY ChangedAt DESC LIMIT 5";
                    using (MySqlCommand cmd = new MySqlCommand(historyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime changeDate = Convert.ToDateTime(reader["ChangedAt"]);
                                string statusText = $"{changeDate.ToString("MM/dd")} - {reader["Status"]}: {reader["Remarks"]}";
                                lstRecentUpdates.Items.Add(statusText);
                            }
                        }
                    }

                    if (lstRecentUpdates.Items.Count == 0)
                    {
                        lstRecentUpdates.Items.Add("No recent status activity updates found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error loading operational data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Label lblSubtitle;
        private Label lblInterviewLocation;
        private Label lblInterviewTime;
        private Label lblInterviewDate;
        private ListBox lstMissingDocuments;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplicantDashboardForm_Load(object sender, EventArgs e)
        {
            LoadApplicantProfileAndSummary();
            LoadCurrentStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicantProfileForm profileForm = new ApplicantProfileForm(this.loggedInAccountID);
            profileForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ApplicantLogin login = new ApplicantLogin();
                login.Show();
                this.Close();
            }
        }

        private Button btnJobVacancy;

        private void btnJobVacancy_Click(object sender, EventArgs e)
        {
            JobVacancies jobvacanciesWindow = new JobVacancies(this.realApplicantID);
            jobvacanciesWindow.Show();
            this.Hide();

        }

        private Button btnMyDocuments;
        private Button btnMyApplication;

        private void btnMyDocuments_Click(object sender, EventArgs e)
        {
            ApplicantDocuments ApplicantDocumentsWindow = new ApplicantDocuments(this.realApplicantID);
            ApplicantDocumentsWindow.Show();
            this.Hide();
        }

        private Button btnApplicationStatus;

        private void btnApplicationStatus_Click(object sender, EventArgs e)
        {
            ApplicationStatusForm ApplicationStatusWindow = new ApplicationStatusForm(this.realApplicantID);
            ApplicationStatusWindow.Show();
            this.Hide();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            MyApplicationPage ApplicationPageWindow = new MyApplicationPage(this.realApplicantID);
            ApplicationPageWindow.Show();
            this.Hide();
        }
    }
}