using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace HR_Applicant_Process_Windows_System_MAIN

{
    public partial class Interviewsched: Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=ivor_blunt00;" +
            "database=hr_recruitment_db;";

        private int _selectedInterviewID = -1;

        public Interviewsched()
        {
            InitializeComponent();

            SetupComboBoxDrawing();

            LoadQualifiedApplicants();
            LoadInterviewers();
            LoadExistingSchedules();

            HookValidation();

            btnSave.Enabled = false;
            btnUpdate.Enabled = false;

            ValidateInputs();
        }

        private void SetupComboBoxDrawing()
        {
            foreach (ComboBox cmb in new[] {
                cmbApplicant, cmbInterviewer, cmbStatus,
                cmbUpdateInterviewer, cmbUpdateStatus })
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

        private void LoadQualifiedApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT
                        app.ApplicationID,
                        CONCAT(app.ApplicationID, ' - ', a.FirstName, ' ', a.LastName) AS DisplayText
                    FROM Applicants a
                    INNER JOIN Applications app ON a.ApplicantID = app.ApplicantID
                    INNER JOIN ScreeningResults sr ON app.ApplicationID = sr.ApplicationID
                    WHERE sr.Result = 'Qualified'
                    AND app.ApplicationID NOT IN (SELECT ApplicationID FROM InterviewSchedules)";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row["ApplicationID"] = 0;
                row["DisplayText"] = "-- Select Applicant --";
                dt.Rows.InsertAt(row, 0);

                cmbApplicant.DataSource = dt;
                cmbApplicant.DisplayMember = "DisplayText";
                cmbApplicant.ValueMember = "ApplicationID";
                cmbApplicant.SelectedIndex = 0;
            }
        }

        private void LoadInterviewers()
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

                DataTable dtNew = dt.Copy();
                DataRow rowNew = dtNew.NewRow();
                rowNew["UserID"] = 0;
                rowNew["DisplayText"] = "-- Select Interviewer --";
                dtNew.Rows.InsertAt(rowNew, 0);

                cmbInterviewer.DataSource = dtNew;
                cmbInterviewer.DisplayMember = "DisplayText";
                cmbInterviewer.ValueMember = "UserID";
                cmbInterviewer.SelectedIndex = 0;

                DataTable dtUpdate = dt.Copy();
                DataRow rowUpdate = dtUpdate.NewRow();
                rowUpdate["UserID"] = 0;
                rowUpdate["DisplayText"] = "-- Select Interviewer --";
                dtUpdate.Rows.InsertAt(rowUpdate, 0);

                cmbUpdateInterviewer.DataSource = dtUpdate;
                cmbUpdateInterviewer.DisplayMember = "DisplayText";
                cmbUpdateInterviewer.ValueMember = "UserID";
                cmbUpdateInterviewer.SelectedIndex = 0;
            }
        }

        private void LoadExistingSchedules()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                string query = @"
            SELECT
                isch.InterviewID,
                CONCAT(a.FirstName, ' ', a.LastName) AS Applicant,
                app.ApplicationID,
                isch.InterviewDate  AS InterviewDateTime,
                isch.Location,
                isch.Status,
                u.Username          AS Interviewer
            FROM InterviewSchedules isch
            INNER JOIN Applications app ON isch.ApplicationID = app.ApplicationID
            INNER JOIN Applicants a     ON app.ApplicantID    = a.ApplicantID
            INNER JOIN users u          ON isch.InterviewerID = u.UserID
            WHERE isch.InterviewDate >= NOW()
            ORDER BY isch.InterviewDate ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvSchedules.DataSource = dt;

                dgvSchedules.Columns["InterviewID"].Visible = false;
                dgvSchedules.Columns["ApplicationID"].Visible = false;

                dgvSchedules.Columns["Applicant"].HeaderText = "Applicant";
                dgvSchedules.Columns["InterviewDateTime"].HeaderText = "Date & Time";
                dgvSchedules.Columns["Location"].HeaderText = "Location";
                dgvSchedules.Columns["Status"].HeaderText = "Status";
                dgvSchedules.Columns["Interviewer"].HeaderText = "Interviewer";

                dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSchedules.ReadOnly = true;
                dgvSchedules.AllowUserToAddRows = false;
            }
        }

        private void ValidateInputs()
        {
            bool valid =
                cmbApplicant.SelectedIndex > 0 &&
                cmbInterviewer.SelectedIndex > 0 &&
                !string.IsNullOrWhiteSpace(txtLocation.Text) &&
                cmbStatus.SelectedIndex > -1;

            btnSave.Enabled = valid;
        }

        private void ValidateUpdate()
        {
            bool valid =
                _selectedInterviewID > 0 &&
                cmbUpdateInterviewer.SelectedIndex > 0 &&
                !string.IsNullOrWhiteSpace(txtUpdateLocation.Text) &&
                cmbUpdateStatus.SelectedIndex > -1;

            btnUpdate.Enabled = valid;
        }

        private void HookValidation()
        {
            txtLocation.TextChanged += (s, e) => ValidateInputs();
            cmbApplicant.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbInterviewer.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbStatus.SelectionChangeCommitted += (s, e) => ValidateInputs();

            txtUpdateLocation.TextChanged += (s, e) => ValidateUpdate();
            cmbUpdateInterviewer.SelectionChangeCommitted += (s, e) => ValidateUpdate();
            cmbUpdateStatus.SelectionChangeCommitted += (s, e) => ValidateUpdate();

            dgvSchedules.SelectionChanged += dgvSchedules_SelectionChanged;

            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnCancelUpdate.Click += (s, e) => CloseUpdatePanel();
        }

        private void dgvSchedules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvSchedules.SelectedRows[0];

            _selectedInterviewID = Convert.ToInt32(row.Cells["InterviewID"].Value);

            DateTime interviewDate = Convert.ToDateTime(row.Cells["InterviewDateTime"].Value);
            dtpUpdateDate.Value = interviewDate.Date;
            dtpUpdateTime.Value = interviewDate;

            txtUpdateLocation.Text = row.Cells["Location"].Value?.ToString();

            string status = row.Cells["Status"].Value?.ToString();
            for (int i = 0; i < cmbUpdateStatus.Items.Count; i++)
            {
                if (cmbUpdateStatus.Items[i].ToString() == status)
                {
                    cmbUpdateStatus.SelectedIndex = i;
                    break;
                }
            }

            string interviewer = row.Cells["Interviewer"].Value?.ToString();
            foreach (DataRowView item in cmbUpdateInterviewer.Items)
            {
                if (item["DisplayText"].ToString().Contains(interviewer ?? ""))
                {
                    cmbUpdateInterviewer.SelectedItem = item;
                    break;
                }
            }

            lblSelectedSchedule.Text =
                $"Editing:  {row.Cells["Applicant"].Value}  —  {interviewDate:MMM dd, yyyy  hh:mm tt}";

            pnlUpdate.Visible = true;
            ValidateUpdate();
        }


        private void CloseUpdatePanel()
        {
            _selectedInterviewID = -1;
            pnlUpdate.Visible = false;
            lblSelectedSchedule.Text = "Editing: —";
            btnUpdate.Enabled = false;
            dgvSchedules.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO InterviewSchedules
                            (ApplicationID, InterviewDate, InterviewerID, Location, Status)
                        VALUES
                            (@ApplicationID, @InterviewDate, @InterviewerID, @Location, @Status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicationID", cmbApplicant.SelectedValue);
                    cmd.Parameters.AddWithValue("@InterviewDate", dtpInterviewDate.Value);
                    cmd.Parameters.AddWithValue("@InterviewerID", cmbInterviewer.SelectedValue);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Interview scheduled successfully!");

                    LoadQualifiedApplicants();
                    LoadInterviewers();
                    LoadExistingSchedules();

                    txtLocation.Clear();
                    cmbStatus.SelectedIndex = -1;
                    cmbApplicant.SelectedIndex = 0;
                    cmbInterviewer.SelectedIndex = 0;

                    ValidateInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedInterviewID < 0) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    DateTime combined = dtpUpdateDate.Value.Date
                                      + dtpUpdateTime.Value.TimeOfDay;

                    string query = @"
                        UPDATE InterviewSchedules SET
                            InterviewDate = @InterviewDate,
                            InterviewerID = @InterviewerID,
                            Location      = @Location,
                            Status        = @Status
                        WHERE InterviewID = @InterviewID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InterviewDate", combined);
                    cmd.Parameters.AddWithValue("@InterviewerID", cmbUpdateInterviewer.SelectedValue);
                    cmd.Parameters.AddWithValue("@Location", txtUpdateLocation.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbUpdateStatus.Text);
                    cmd.Parameters.AddWithValue("@InterviewID", _selectedInterviewID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Schedule updated successfully!");

                    CloseUpdatePanel();
                    LoadExistingSchedules();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
