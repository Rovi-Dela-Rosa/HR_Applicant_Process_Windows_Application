using System.Data;
using System.IO;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class Report : Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=MysqlEnzo;" +
            "database=hr_recruitment_db;";

        public Report()
        {
            InitializeComponent();

            LoadAllReports();

            btnRefresh.Click += (s, e) => LoadAllReports();
            btnGenerateReport.Click += btnGenerateReport_Click;

            tabReports.SelectedIndexChanged += (s, e) => UpdateCountLabel();
        }

        private void LoadAllReports()
        {
            LoadApplicantList();
            LoadPendingApplications();
            LoadInterviews();
            LoadDecisions();
            LoadMissingRequirements();
            UpdateCountLabel();
        }

        private void LoadApplicantList()
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = @"
                    SELECT
                        a.ApplicantID                               AS ID,
                        CONCAT(a.FirstName, ' ', a.LastName)        AS Name,
                        COALESCE(aa.Email, '-')                     AS Email,
                        COALESCE(a.ContactNumber, '-')              AS Contact,
                        COALESCE(a.HighestEducation, '-')           AS Education,
                        COALESCE(a.Skills, '-')                     AS Skills,
                        COALESCE(aa.AccountStatus, '-')             AS AccountStatus,
                        COALESCE(CAST(aa.CreatedAt AS CHAR), '-')   AS RegisteredDate
                    FROM Applicants a
                    LEFT JOIN ApplicantAccounts aa ON a.AccountID = aa.AccountID
                    ORDER BY a.ApplicantID DESC";

                DataTable dt = FetchData(query, conn);
                dgvApplicants.DataSource = dt;

                RenameColumn(dgvApplicants, "ID", "ID");
                RenameColumn(dgvApplicants, "Name", "Full Name");
                RenameColumn(dgvApplicants, "Email", "Email");
                RenameColumn(dgvApplicants, "Contact", "Contact");
                RenameColumn(dgvApplicants, "Education", "Education");
                RenameColumn(dgvApplicants, "Skills", "Skills");
                RenameColumn(dgvApplicants, "AccountStatus", "Account Status");
                RenameColumn(dgvApplicants, "RegisteredDate", "Registered");

                StyleGrid(dgvApplicants);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Applicant List error: {ex.Message}");
            }
        }

        private void LoadPendingApplications()
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = @"
                    SELECT
                        app.ApplicationID                               AS AppID,
                        CONCAT(a.FirstName, ' ', a.LastName)            AS Applicant,
                        COALESCE(p.PositionName, '-')                   AS Position,
                        COALESCE(d.DepartmentName, '-')                 AS Department,
                        CASE
                            WHEN ev.Result IS NOT NULL
                                THEN CONCAT('Interviewed — ', ev.Result)
                            WHEN isch.InterviewID IS NOT NULL
                             AND isch.InterviewDate <= NOW()
                                THEN 'Interview Done — Awaiting Evaluation'
                            WHEN isch.InterviewID IS NOT NULL
                             AND isch.InterviewDate > NOW()
                                THEN 'Interview Scheduled'
                            WHEN sr.Result = 'Qualified'
                                THEN 'Qualified — Pending Interview'
                            WHEN sr.Result = 'Pending'
                                THEN 'Under Screening'
                            WHEN sr.Result IS NOT NULL
                                THEN sr.Result
                            ELSE COALESCE(app.CurrentStatus, 'Pending')
                        END                                             AS Status,
                        app.AppliedDate
                    FROM Applications app
                    LEFT JOIN Applicants a             ON app.ApplicantID      = a.ApplicantID
                    LEFT JOIN JobVacancies jv          ON app.VacancyID        = jv.VacancyID
                    LEFT JOIN Positions p              ON jv.PositionID        = p.PositionID
                    LEFT JOIN Departments d            ON jv.DepartmentID      = d.DepartmentID
                    LEFT JOIN ScreeningResults sr      ON app.ApplicationID    = sr.ApplicationID
                    LEFT JOIN InterviewSchedules isch  ON app.ApplicationID    = isch.ApplicationID
                    LEFT JOIN InterviewEvaluations ev  ON isch.InterviewID     = ev.InterviewID
                    WHERE app.CurrentStatus NOT IN
                        ('Accepted', 'Rejected', 'Withdrawn', 'Hired')
                    AND (sr.Result IS NULL OR sr.Result NOT IN ('Rejected', 'Not Qualified'))
                    AND ev.Result IS NULL
                    ORDER BY app.AppliedDate DESC";

                DataTable dt = FetchData(query, conn);
                dgvPending.DataSource = dt;

                RenameColumn(dgvPending, "AppID", "Application ID");
                RenameColumn(dgvPending, "Applicant", "Applicant");
                RenameColumn(dgvPending, "Position", "Position");
                RenameColumn(dgvPending, "Department", "Department");
                RenameColumn(dgvPending, "Status", "Status");
                RenameColumn(dgvPending, "AppliedDate", "Applied On");

                StyleGrid(dgvPending);

                dgvPending.RowPrePaint -= DgvPending_RowPrePaint;
                dgvPending.RowPrePaint += DgvPending_RowPrePaint;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pending Applications error: {ex.Message}");
            }
        }

        private void DgvPending_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPending.Rows.Count) return;
            var cell = dgvPending.Rows[e.RowIndex].Cells["Status"];
            if (cell?.Value == null) return;

            string status = cell.Value.ToString() ?? "";

            dgvPending.Rows[e.RowIndex].DefaultCellStyle.BackColor = status switch
            {
                "Draft" => Color.FromArgb(255, 255, 240),
                "Submitted" => Color.FromArgb(230, 244, 255),
                "Screening" => Color.FromArgb(255, 243, 205),
                "Under Screening" => Color.FromArgb(255, 243, 205),
                "Qualified — Pending Interview" => Color.FromArgb(220, 255, 220),
                "Interview Scheduled" => Color.FromArgb(209, 236, 241),
                "Interview Done — Awaiting Evaluation" => Color.FromArgb(255, 243, 205),
                _ when status.StartsWith("Interviewed — Passed") => Color.FromArgb(220, 255, 220),
                _ when status.StartsWith("Interviewed — Failed") => Color.FromArgb(255, 220, 220),
                _ when status.StartsWith("Interviewed — Waitlisted") => Color.FromArgb(255, 255, 210),
                _ => Color.White
            };
        }

        private void LoadInterviews()
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = @"
                    SELECT
                        isch.InterviewID                                AS ID,
                        CONCAT(a.FirstName, ' ', a.LastName)            AS Applicant,
                        COALESCE(p.PositionName, '-')                   AS Position,
                        isch.InterviewDate,
                        COALESCE(isch.Location, '-')                    AS Location,
                        COALESCE(u.Username, '-')                       AS Interviewer,
                        COALESCE(isch.Status, '-')                      AS SchedStatus,
                        COALESCE(CAST(ev.Score AS CHAR), '-')           AS Score,
                        COALESCE(ev.Result, 'Not Evaluated')            AS EvalResult,
                        COALESCE(ev.Remarks, '-')                       AS EvalRemarks
                    FROM InterviewSchedules isch
                    LEFT JOIN Applications app        ON isch.ApplicationID  = app.ApplicationID
                    LEFT JOIN Applicants a            ON app.ApplicantID     = a.ApplicantID
                    LEFT JOIN JobVacancies jv         ON app.VacancyID       = jv.VacancyID
                    LEFT JOIN Positions p             ON jv.PositionID       = p.PositionID
                    LEFT JOIN Users u                 ON isch.InterviewerID  = u.UserID
                    LEFT JOIN InterviewEvaluations ev ON isch.InterviewID    = ev.InterviewID
                    ORDER BY isch.InterviewDate DESC";

                DataTable dt = FetchData(query, conn);
                dgvInterviews.DataSource = dt;

                RenameColumn(dgvInterviews, "ID", "ID");
                RenameColumn(dgvInterviews, "Applicant", "Applicant");
                RenameColumn(dgvInterviews, "Position", "Position");
                RenameColumn(dgvInterviews, "InterviewDate", "Date/Time");
                RenameColumn(dgvInterviews, "Location", "Location");
                RenameColumn(dgvInterviews, "Interviewer", "Interviewer");
                RenameColumn(dgvInterviews, "SchedStatus", "Schedule Status");
                RenameColumn(dgvInterviews, "Score", "Score");
                RenameColumn(dgvInterviews, "EvalResult", "Result");
                RenameColumn(dgvInterviews, "EvalRemarks", "Remarks");

                StyleGrid(dgvInterviews);

                dgvInterviews.RowPrePaint -= DgvInterviews_RowPrePaint;
                dgvInterviews.RowPrePaint += DgvInterviews_RowPrePaint;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Interviews error: {ex.Message}");
            }
        }

        private void DgvInterviews_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvInterviews.Rows.Count) return;
            var cell = dgvInterviews.Rows[e.RowIndex].Cells["EvalResult"];
            if (cell?.Value == null) return;

            dgvInterviews.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                cell.Value.ToString() switch
                {
                    "Passed" => Color.FromArgb(220, 255, 220),
                    "Failed" => Color.FromArgb(255, 220, 220),
                    "Waitlisted" => Color.FromArgb(255, 255, 210),
                    "Not Evaluated" => Color.FromArgb(240, 240, 240),
                    _ => Color.White
                };
        }

        private void LoadDecisions()
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = @"
                    SELECT
                        COALESCE(hd.DecisionID, 0)                      AS DecisionID,
                        CONCAT(a.FirstName, ' ', a.LastName)            AS Applicant,
                        COALESCE(p.PositionName, '-')                   AS Position,
                        COALESCE(d.DepartmentName, '-')                 AS Department,
                        COALESCE(hd.DecisionStatus, app.CurrentStatus)  AS Decision,
                        COALESCE(hd.DecisionDate, app.AppliedDate)      AS Date,
                        COALESCE(u.Username, '-')                       AS DecidedBy,
                        COALESCE(hd.Remarks, '-')                       AS Remarks
                    FROM Applications app
                    LEFT JOIN Applicants a       ON app.ApplicantID    = a.ApplicantID
                    LEFT JOIN JobVacancies jv    ON app.VacancyID      = jv.VacancyID
                    LEFT JOIN Positions p        ON jv.PositionID      = p.PositionID
                    LEFT JOIN Departments d      ON jv.DepartmentID    = d.DepartmentID
                    LEFT JOIN HiringDecisions hd ON app.ApplicationID  = hd.ApplicationID
                    LEFT JOIN Users u            ON hd.DecisionBy      = u.UserID
                    WHERE hd.DecisionID IS NOT NULL
                       OR app.CurrentStatus IN
                           ('Rejected', 'Hired', 'Accepted', 'On Hold', 'Waitlisted', 'Withdrawn')
                    ORDER BY Date DESC";

                DataTable dt = FetchData(query, conn);
                dgvDecisions.DataSource = dt;

                dgvDecisions.Columns["DecisionID"].Visible = false;

                RenameColumn(dgvDecisions, "Applicant", "Applicant");
                RenameColumn(dgvDecisions, "Position", "Position");
                RenameColumn(dgvDecisions, "Department", "Department");
                RenameColumn(dgvDecisions, "Decision", "Decision");
                RenameColumn(dgvDecisions, "Date", "Date");
                RenameColumn(dgvDecisions, "DecidedBy", "Decided By");
                RenameColumn(dgvDecisions, "Remarks", "Remarks");

                StyleGrid(dgvDecisions);

                dgvDecisions.RowPrePaint -= DgvDecisions_RowPrePaint;
                dgvDecisions.RowPrePaint += DgvDecisions_RowPrePaint;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decisions error: {ex.Message}");
            }
        }

        private void DgvDecisions_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDecisions.Rows.Count) return;
            var cell = dgvDecisions.Rows[e.RowIndex].Cells["Decision"];
            if (cell?.Value == null) return;

            dgvDecisions.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                cell.Value.ToString() switch
                {
                    "Hired" => Color.FromArgb(220, 255, 220),
                    "Accepted" => Color.FromArgb(220, 255, 220),
                    "Rejected" => Color.FromArgb(255, 220, 220),
                    "Withdrawn" => Color.FromArgb(240, 240, 240),
                    "On Hold" => Color.FromArgb(255, 255, 210),
                    "Waitlisted" => Color.FromArgb(255, 243, 205),
                    _ => Color.White
                };
        }

        private void LoadMissingRequirements()
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = @"
                    SELECT
                        a.ApplicantID,
                        CONCAT(a.FirstName, ' ', a.LastName)            AS Applicant,
                        COALESCE(aa.Email, '-')                         AS Email,
                        GROUP_CONCAT(rt.RequirementName
                            ORDER BY rt.RequirementName
                            SEPARATOR ', ')                             AS MissingDocuments,
                        app.ApplicationID,
                        COALESCE(p.PositionName, '-')                   AS AppliedFor,
                        COALESCE(app.CurrentStatus, '-')                AS AppStatus
                    FROM Applicants a
                    LEFT  JOIN ApplicantAccounts aa ON a.AccountID         = aa.AccountID
                    INNER  JOIN Applications app     ON a.ApplicantID       = app.ApplicantID
                    LEFT  JOIN JobVacancies jv      ON app.VacancyID       = jv.VacancyID
                    LEFT  JOIN Positions p          ON jv.PositionID       = p.PositionID
                    CROSS JOIN RequirementTypes rt
                    LEFT  JOIN ApplicantDocuments ad
                        ON  a.ApplicantID          = ad.ApplicantID
                        AND rt.RequirementTypeID   = ad.RequirementTypeID
                        AND ad.Status              = 'Approved'
                    WHERE ad.DocumentID IS NULL
                    AND (
                        app.CurrentStatus IS NULL
                        OR app.CurrentStatus NOT IN
                        ('Hired','Accepted','Rejected','Withdrawn')
                    )
                    GROUP BY
                        a.ApplicantID,
                        a.FirstName,
                        a.LastName,
                        aa.Email,
                        app.ApplicationID,
                        p.PositionName,
                        app.CurrentStatus
                    ORDER BY a.LastName";

                DataTable dt = FetchData(query, conn);
                dgvMissing.DataSource = dt;

                dgvMissing.Columns["ApplicantID"].Visible = false;
                dgvMissing.Columns["ApplicationID"].Visible = false;

                RenameColumn(dgvMissing, "Applicant", "Applicant");
                RenameColumn(dgvMissing, "Email", "Email");
                RenameColumn(dgvMissing, "MissingDocuments", "Missing Documents");
                RenameColumn(dgvMissing, "AppliedFor", "Applied For");
                RenameColumn(dgvMissing, "AppStatus", "Application Status");

                StyleGrid(dgvMissing);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Missing Requirements error: {ex.Message}");
            }
        }

        private void UpdateCountLabel()
        {
            DataGridView current = tabReports.SelectedIndex switch
            {
                0 => dgvApplicants,
                1 => dgvPending,
                2 => dgvInterviews,
                3 => dgvDecisions,
                4 => dgvMissing,
                _ => dgvApplicants
            };

            string tabName = tabReports.SelectedIndex switch
            {
                0 => "applicants",
                1 => "pending applications",
                2 => "interviews",
                3 => "decisions",
                4 => "missing requirement entries",
                _ => "records"
            };

            lblReportCount.Text = $"{current.Rows.Count} {tabName} found";
        }

        private static DataTable FetchData(string query, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private static void RenameColumn(DataGridView dgv, string colName, string header)
        {
            if (dgv.Columns.Contains(colName))
                dgv.Columns[colName].HeaderText = header;
        }

        private static void StyleGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
        }

        private void Back(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HRAdminDashboard loginForm = new HRAdminDashboard();
            loginForm.Show();
            this.Hide();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "CSV File (*.csv)|*.csv";
                    save.FileName = "Recruitment_Report.csv";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(save.FileName))
                        {
                            for (int i = 0; i < dgvDecisions.Columns.Count; i++)
                            {
                                sw.Write(dgvDecisions.Columns[i].HeaderText);

                                if (i < dgvDecisions.Columns.Count - 1)
                                    sw.Write(",");
                            }

                            sw.WriteLine();

                            foreach (DataGridViewRow row in dgvDecisions.Rows)
                            {
                                for (int i = 0; i < dgvDecisions.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());

                                    if (i < dgvDecisions.Columns.Count - 1)
                                        sw.Write(",");
                                }

                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show(
                            "Recruitment report generated successfully!",
                            "Export Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Report generation error:\n" + ex.Message);
            }
        }
    }
}
