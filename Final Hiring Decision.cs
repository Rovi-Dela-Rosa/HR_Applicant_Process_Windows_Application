using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class HireDecision : Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=ivor_blunt00;" +
            "database=hr_recruitment_db;";

        public HireDecision()
        {
            InitializeComponent();
            dtpDecisionDate.MinDate = DateTime.Today;

            SetupComboBoxDrawing();

            LoadApplicants();
            LoadDecisionBy();
            LoadDecisions();

            HookValidation();

            btnSave.Enabled = false;
        }

        private void SetupComboBoxDrawing()
        {
            foreach (ComboBox cmb in new[] { cmbApplication, cmbDecisionStatus, cmbDecisionBy })
            {
                cmb.DrawMode = DrawMode.OwnerDrawFixed;
                cmb.DrawItem += ComboBox_DrawItem;
            }
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox cmb = (ComboBox)sender;
            string text = cmb.GetItemText(cmb.Items[e.Index]);

            e.DrawBackground();

            bool isPlaceholder = text.StartsWith("-- Select");
            Color textColor = isPlaceholder ? Color.Gray : e.ForeColor;

            using (SolidBrush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }

            e.DrawFocusRectangle();
        }

        private void LoadApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT
                        app.ApplicationID,
                        CONCAT(app.ApplicationID, ' - ', a.FirstName, ' ', a.LastName) AS DisplayText
                    FROM Applications app
                    INNER JOIN Applicants a ON app.ApplicantID = a.ApplicantID
                    INNER JOIN InterviewSchedules isch ON app.ApplicationID = isch.ApplicationID
                    INNER JOIN InterviewEvaluations ev ON isch.InterviewID  = ev.InterviewID
                    WHERE app.CurrentStatus='For Final Review'
                    AND app.ApplicationID NOT IN
                    (
                        SELECT ApplicationID FROM HiringDecisions
                    )
                    ORDER BY a.LastName, a.FirstName";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row["ApplicationID"] = 0;
                row["DisplayText"] = "-- Select Applicant --";
                dt.Rows.InsertAt(row, 0);

                cmbApplication.DataSource = dt;
                cmbApplication.DisplayMember = "DisplayText";
                cmbApplication.ValueMember = "ApplicationID";
                cmbApplication.SelectedIndex = 0;
            }
        }

        private void LoadDecisionBy()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT UserID, CONCAT(UserID, ' - ', Username) AS DisplayText
                    FROM users";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row["UserID"] = 0;
                row["DisplayText"] = "-- Select User --";
                dt.Rows.InsertAt(row, 0);

                cmbDecisionBy.DataSource = dt;
                cmbDecisionBy.DisplayMember = "DisplayText";
                cmbDecisionBy.ValueMember = "UserID";
                cmbDecisionBy.SelectedIndex = 0;
            }
        }

        private void LoadDecisions()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT
                        hd.DecisionID,
                        CONCAT(a.FirstName, ' ', a.LastName) AS Applicant,
                        hd.DecisionStatus                    AS Status,
                        hd.DecisionDate,
                        u.Username                           AS DecidedBy,
                        hd.Remarks
                    FROM HiringDecisions hd
                    INNER JOIN Applications app ON hd.ApplicationID = app.ApplicationID
                    INNER JOIN Applicants a     ON app.ApplicantID  = a.ApplicantID
                    INNER JOIN users u          ON hd.DecisionBy    = u.UserID
                    ORDER BY hd.DecisionDate DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvDecisions.DataSource = dt;

                dgvDecisions.Columns["DecisionID"].Visible = false;

                dgvDecisions.Columns["Applicant"].HeaderText = "Applicant";
                dgvDecisions.Columns["Status"].HeaderText = "Decision";
                dgvDecisions.Columns["DecisionDate"].HeaderText = "Date";
                dgvDecisions.Columns["DecidedBy"].HeaderText = "Decided By";
                dgvDecisions.Columns["Remarks"].HeaderText = "Remarks";

                dgvDecisions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDecisions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDecisions.ReadOnly = true;
                dgvDecisions.AllowUserToAddRows = false;
            }
        }

        private void ValidateInputs()
        {
            bool valid =
                cmbApplication.SelectedIndex > 0 &&
                cmbDecisionStatus.SelectedIndex > 0 &&
                !cmbDecisionStatus.Text.StartsWith("-- Select") &&
                cmbDecisionBy.SelectedIndex > 0;

            btnSave.Enabled = valid;
        }

        private void HookValidation()
        {
            cmbApplication.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbDecisionStatus.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbDecisionBy.SelectionChangeCommitted += (s, e) => ValidateInputs();

            btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpDecisionDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Decision date cannot be earlier than today.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    DateTime interviewDate;

                    string checkInterviewDateQuery = @"
                    SELECT isch.InterviewDate
                    FROM InterviewSchedules isch
                    INNER JOIN Applications app
                    ON isch.ApplicationID = app.ApplicationID
                    WHERE app.ApplicationID=@ApplicationID";


                    using (MySqlCommand dateCmd =
                    new MySqlCommand(checkInterviewDateQuery, conn))
                    {
                        dateCmd.Parameters.AddWithValue(
                            "@ApplicationID",
                            cmbApplication.SelectedValue
                        );

                        interviewDate =
                            Convert.ToDateTime(dateCmd.ExecuteScalar());
                    }


                    if (dtpDecisionDate.Value.Date < interviewDate.Date)
                    {
                        MessageBox.Show(
                            "Hiring decision date cannot be earlier than the interview date.",
                            "Invalid Decision Date",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    string query = @"
                        INSERT INTO HiringDecisions
                            (ApplicationID, DecisionStatus, Remarks, DecisionBy, DecisionDate)
                        VALUES
                            (@ApplicationID, @DecisionStatus, @Remarks, @DecisionBy, @DecisionDate)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicationID", cmbApplication.SelectedValue);
                    cmd.Parameters.AddWithValue("@DecisionStatus", cmbDecisionStatus.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
                    cmd.Parameters.AddWithValue("@DecisionBy", cmbDecisionBy.SelectedValue);
                    cmd.Parameters.AddWithValue("@DecisionDate", dtpDecisionDate.Value);

                    cmd.ExecuteNonQuery();

                    AuditTrailManager.LogAction("HR Staff", Convert.ToInt32(cmbDecisionBy.SelectedValue), "Made hiring decision: "
                    + cmbDecisionStatus.Text + " for Application ID: " + cmbApplication.SelectedValue);

                    string updateApplicationQuery = @"
                    UPDATE Applications
                    SET CurrentStatus=@Status
                    WHERE ApplicationID=@ApplicationID";

                    using (MySqlCommand updateCmd = new MySqlCommand(updateApplicationQuery, conn))
                    {
                        string newStatus = cmbDecisionStatus.Text;

                        updateCmd.Parameters.AddWithValue(
                            "@Status",
                            newStatus
                        );

                        updateCmd.Parameters.AddWithValue(
                            "@ApplicationID",
                            cmbApplication.SelectedValue
                        );

                        updateCmd.ExecuteNonQuery();
                    }

                    string historyQuery = @"
                    INSERT INTO ApplicationStatusHistory
                    (ApplicationID, Status, Remarks)
                    VALUES
                    (@ApplicationID,@Status,@Remarks)";


                    using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                    {
                        historyCmd.Parameters.AddWithValue(
                            "@ApplicationID",
                            cmbApplication.SelectedValue
                        );

                        historyCmd.Parameters.AddWithValue(
                            "@Status",
                            cmbDecisionStatus.Text
                        );

                        historyCmd.Parameters.AddWithValue(
                            "@Remarks",
                            txtRemarks.Text.Trim()
                        );

                        historyCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hiring decision saved successfully!");

                    LoadApplicants();
                    LoadDecisionBy();
                    LoadDecisions();

                    txtRemarks.Clear();
                    cmbDecisionStatus.SelectedIndex = 0;
                    cmbApplication.SelectedIndex = 0;
                    cmbDecisionBy.SelectedIndex = 0;

                    ValidateInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HRAdminDashboard loginForm = new HRAdminDashboard();
            loginForm.Show();
            this.Hide();
        }
    }
}
