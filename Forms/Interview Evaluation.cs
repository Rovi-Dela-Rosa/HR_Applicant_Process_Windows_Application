using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class InterviewEvaluationForm : Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=MysqlEnzo;" +
            "database=hr_recruitment_db;";

        public InterviewEvaluationForm()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;

            SetupComboBoxDrawing();

            LoadInterviews();
            LoadEvaluators();
            LoadEvaluations();

            HookValidation();

            btnSave.Enabled = false;
        }

        private void SetupComboBoxDrawing()
        {
            foreach (ComboBox cmb in new[] { cmbInterview, cmbResult, cmbEvaluatedBy })
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

        private void LoadInterviews()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT
                        isch.InterviewID,
                        CONCAT(
                            isch.InterviewID, ' - ',
                            a.FirstName, ' ', a.LastName,
                            ' (', DATE_FORMAT(isch.InterviewDate, '%b %d, %Y'), ')'
                        ) AS DisplayText
                    FROM InterviewSchedules isch
                    INNER JOIN Applications app ON isch.ApplicationID = app.ApplicationID
                    INNER JOIN Applicants a     ON app.ApplicantID    = a.ApplicantID
                    WHERE isch.InterviewID NOT IN
                    (
                        SELECT InterviewID FROM InterviewEvaluations
                    )
                    ORDER BY isch.InterviewDate DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row["InterviewID"] = 0;
                row["DisplayText"] = "-- Select Interview --";
                dt.Rows.InsertAt(row, 0);

                cmbInterview.DataSource = dt;
                cmbInterview.DisplayMember = "DisplayText";
                cmbInterview.ValueMember = "InterviewID";
                cmbInterview.SelectedIndex = 0;
            }
        }

        private void LoadEvaluators()
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
                row["DisplayText"] = "-- Select Evaluator --";
                dt.Rows.InsertAt(row, 0);

                cmbEvaluatedBy.DataSource = dt;
                cmbEvaluatedBy.DisplayMember = "DisplayText";
                cmbEvaluatedBy.ValueMember = "UserID";
                cmbEvaluatedBy.SelectedIndex = 0;
            }
        }

        private void LoadEvaluations()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT
                        ev.EvaluationID,
                        CONCAT(a.FirstName, ' ', a.LastName) AS Applicant,
                        isch.InterviewDate                   AS InterviewDateTime,
                        ev.Score,
                        ev.Result,
                        ev.Remarks,
                        u.Username                           AS EvaluatedBy
                    FROM InterviewEvaluations ev
                    INNER JOIN InterviewSchedules isch ON ev.InterviewID     = isch.InterviewID
                    INNER JOIN Applications app        ON isch.ApplicationID = app.ApplicationID
                    INNER JOIN Applicants a            ON app.ApplicantID    = a.ApplicantID
                    LEFT  JOIN users u                 ON ev.EvaluatedBy     = u.UserID
                    ORDER BY isch.InterviewDate DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvEvaluations.DataSource = dt;

                dgvEvaluations.Columns["EvaluationID"].Visible = false;

                dgvEvaluations.Columns["Applicant"].HeaderText = "Applicant";
                dgvEvaluations.Columns["InterviewDateTime"].HeaderText = "Interview Date";
                dgvEvaluations.Columns["Score"].HeaderText = "Score";
                dgvEvaluations.Columns["Result"].HeaderText = "Result";
                dgvEvaluations.Columns["Remarks"].HeaderText = "Remarks";
                dgvEvaluations.Columns["EvaluatedBy"].HeaderText = "Evaluated By";

                dgvEvaluations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEvaluations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvEvaluations.ReadOnly = true;
                dgvEvaluations.AllowUserToAddRows = false;
            }
        }

        private void txtScore_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtScore.Text, out decimal value))
            {
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                txtScore.Text = value.ToString();
            }
        }

        private void ValidateInputs()
        {
            bool valid =
                cmbInterview.SelectedIndex > 0 &&
                !string.IsNullOrWhiteSpace(txtScore.Text) &&
                decimal.TryParse(txtScore.Text, out _) &&
                cmbResult.SelectedIndex > -1 &&
                !cmbResult.Text.StartsWith("-- Select") &&
                cmbEvaluatedBy.SelectedIndex > 0;

            btnSave.Enabled = valid;
        }

        private void HookValidation()
        {
            cmbInterview.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbResult.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbEvaluatedBy.SelectionChangeCommitted += (s, e) => ValidateInputs();

            txtScore.TextChanged += (s, e) => ValidateInputs();
            txtScore.Leave += txtScore_Leave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtScore.Text, out decimal score))
            {
                MessageBox.Show("Please enter a valid numeric score.");
                return;
            }

            if (score < 0) score = 0;
            if (score > 100) score = 100;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO InterviewEvaluations
                            (InterviewID, Score, Result, Remarks, EvaluatedBy)
                        VALUES
                            (@InterviewID, @Score, @Result, @Remarks, @EvaluatedBy)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InterviewID", cmbInterview.SelectedValue);
                    cmd.Parameters.AddWithValue("@Score", score);
                    cmd.Parameters.AddWithValue("@Result", cmbResult.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
                    cmd.Parameters.AddWithValue("@EvaluatedBy", cmbEvaluatedBy.SelectedValue);

                    cmd.ExecuteNonQuery();

                    AuditTrailManager.LogAction("HR Staff", Convert.ToInt32(cmbEvaluatedBy.SelectedValue),
                        "Submitted interview evaluation for Interview ID: " + cmbInterview.SelectedValue);

                    // GET APPLICATION ID
                    string getApplicationQuery = @"
                    SELECT ApplicationID
                    FROM InterviewSchedules
                    WHERE InterviewID=@InterviewID";


                    int applicationID = 0;


                    using (MySqlCommand getAppCmd = new MySqlCommand(getApplicationQuery, conn))
                    {
                        getAppCmd.Parameters.AddWithValue(
                            "@InterviewID",
                            cmbInterview.SelectedValue
                        );

                        applicationID = Convert.ToInt32(
                            getAppCmd.ExecuteScalar()
                        );
                    }

                    string updateInterviewQuery = @"
                    UPDATE InterviewSchedules
                    SET Status='Completed'
                    WHERE InterviewID=@InterviewID";


                    using (MySqlCommand interviewCmd =
                    new MySqlCommand(updateInterviewQuery, conn))
                    {
                        interviewCmd.Parameters.AddWithValue(
                            "@InterviewID",
                            cmbInterview.SelectedValue
                        );

                        interviewCmd.ExecuteNonQuery();
                    }

                    string updateApplicationQuery = @"
                    UPDATE Applications
                    SET CurrentStatus='For Final Review'
                    WHERE ApplicationID=@ApplicationID";


                    using (MySqlCommand appCmd =
                    new MySqlCommand(updateApplicationQuery, conn))
                    {
                        appCmd.Parameters.AddWithValue(
                            "@ApplicationID",
                            applicationID
                        );

                        appCmd.ExecuteNonQuery();
                    }


                    string historyQuery = @"
                    INSERT INTO ApplicationStatusHistory
                    (ApplicationID, Status, Remarks)
                    VALUES
                    (@ApplicationID,
                    'For Final Review',
                    'Interview evaluation completed. Application forwarded for final review.')";


                    using (MySqlCommand historyCmd =
                    new MySqlCommand(historyQuery, conn))
                    {
                        historyCmd.Parameters.AddWithValue(
                            "@ApplicationID",
                            applicationID
                        );

                        historyCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Evaluation saved successfully!");

                    LoadInterviews();
                    LoadEvaluators();
                    LoadEvaluations();

                    txtScore.Clear();
                    txtRemarks.Clear();
                    cmbResult.SelectedIndex = -1;
                    cmbInterview.SelectedIndex = 0;
                    cmbEvaluatedBy.SelectedIndex = 0;

                    ValidateInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hrstaff hrForm = new Hrstaff();
            hrForm.Show();
            this.Hide();
        }
    }
}
