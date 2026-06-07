using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Interview_Evaluation
{
    public partial class Form1 : Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=MysqlEnzo;" +
            "database=hr_recruitment_db;";

        public Form1()
        {
            InitializeComponent();

            SetupComboBoxDrawing();

            LoadInterviews();
            LoadEvaluations();

            HookValidation();

            btnSave.Enabled = false;
        }

        private void SetupComboBoxDrawing()
        {
            foreach (ComboBox cmb in new[] { cmbInterview, cmbResult })
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
                        ev.Remarks
                    FROM InterviewEvaluations ev
                    INNER JOIN InterviewSchedules isch ON ev.InterviewID     = isch.InterviewID
                    INNER JOIN Applications app        ON isch.ApplicationID = app.ApplicationID
                    INNER JOIN Applicants a            ON app.ApplicantID    = a.ApplicantID
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
                !cmbResult.Text.StartsWith("-- Select");

            btnSave.Enabled = valid;
        }

        private void HookValidation()
        {
            cmbInterview.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbResult.SelectionChangeCommitted += (s, e) => ValidateInputs();
            txtScore.TextChanged += (s, e) => ValidateInputs();
            txtScore.Leave += txtScore_Leave;

            btnSave.Click += btnSave_Click;
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
                            (InterviewID, Score, Result, Remarks)
                        VALUES
                            (@InterviewID, @Score, @Result, @Remarks)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InterviewID", cmbInterview.SelectedValue);
                    cmd.Parameters.AddWithValue("@Score", score);
                    cmd.Parameters.AddWithValue("@Result", cmbResult.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Evaluation saved successfully!");

                    LoadInterviews();
                    LoadEvaluations();

                    txtScore.Clear();
                    txtRemarks.Clear();
                    cmbResult.SelectedIndex = -1;
                    cmbInterview.SelectedIndex = 0;

                    ValidateInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
