using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HR_RecruitmentSystem
{
    public partial class ApplicantDashboardForm : Form
    {
        public ApplicantDashboardForm()
        {
            InitializeComponent();

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
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
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
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Location = new Point(31, 211);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(182, 33);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button2_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.ForeColor = Color.Black;
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
            panel2.Size = new Size(732, 753);
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
            lblWelcome.Location = new Point(34, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(360, 38);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome Back, Applicant!";
            // 
            // pnlUpdates
            // 
            pnlUpdates.BackColor = Color.GhostWhite;
            pnlUpdates.Controls.Add(lstRecentUpdates);
            pnlUpdates.Controls.Add(label4);
            pnlUpdates.Location = new Point(34, 405);
            pnlUpdates.Name = "pnlUpdates";
            pnlUpdates.Size = new Size(662, 223);
            pnlUpdates.TabIndex = 3;
            // 
            // lstRecentUpdates
            // 
            lstRecentUpdates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRecentUpdates.FormattingEnabled = true;
            lstRecentUpdates.Location = new Point(18, 44);
            lstRecentUpdates.Margin = new Padding(15);
            lstRecentUpdates.Name = "lstRecentUpdates";
            lstRecentUpdates.Size = new Size(618, 164);
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
            pnlInterview.Size = new Size(662, 118);
            pnlInterview.TabIndex = 2;
            pnlInterview.Paint += pnlInterview_Paint;
            // 
            // lblInterviewLocation
            // 
            lblInterviewLocation.AutoSize = true;
            lblInterviewLocation.Location = new Point(231, 50);
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
            pnlDocsCard.Location = new Point(351, 105);
            pnlDocsCard.Name = "pnlDocsCard";
            pnlDocsCard.Size = new Size(345, 139);
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
            pnlStatusCard.Size = new Size(300, 139);
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
            ClientSize = new Size(982, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ApplicantDashboardForm";
            Text = "Applicant Dashboard";
            Load += ApplicantDashboardForm_Load_1;
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
            MessageBox.Show("You are already on Dashboard.");
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
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT CurrentStatus FROM Applications LIMIT 1";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblStatus.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            lblStatus.Text = "Under Review";

            lstMissingDocuments.Items.Add("Resume");
            lstMissingDocuments.Items.Add("Transcript of Records");

            lblInterviewDate.Text = "Date: June 20, 2026";
            lblInterviewTime.Text = "Time: 10:00 AM";
            lblInterviewLocation.Text = "Location: HR Office";

            lstRecentUpdates.Items.Add("Application submitted.");
            lstRecentUpdates.Items.Add("Documents verified.");
            lstRecentUpdates.Items.Add("Interview scheduled.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicantProfileForm profileForm =
                new ApplicantProfileForm();

            profileForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ApplicantDashboardForm_Load_1(object sender, EventArgs e)
        {
            LoadCurrentStatus();

            lstMissingDocuments.Items.Add("Resume");
            lstMissingDocuments.Items.Add("Transcript of Records");
        }
    }
}
