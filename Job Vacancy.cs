using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class JobVacancies : Form
    {
        private int loggedInAccountID;
        private int currentApplicantID;

        private DataTable jobTable;
        private void dgvJobs_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

                lblPosition.Text = "Position: " + (row.Cells["JobTitle"].Value?.ToString() ?? "");
                lblDepartment.Text = "Department: " + (row.Cells["Department"].Value?.ToString() ?? "");
                lblType.Text = "Employment Type: " + (row.Cells["EmploymentType"].Value?.ToString() ?? "");

                if (dgvJobs.Columns.Contains("Qualifications"))
                {
                    lblQualifications.Text =
                        "Qualifications: " +
                        (row.Cells["Qualifications"].Value?.ToString() ?? "");
                }
                else
                {
                    lblQualifications.Text =
                        "Qualifications: Not Available";
                }

                lblDocuments.Text = "Required Documents: Please see 'My Documents' page for submission requirements.";
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            if (jobTable == null)
                return;

            string search = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                dgvJobs.DataSource = jobTable;
                return;
            }


            DataView view = new DataView(jobTable);

            view.RowFilter =
                $"JobTitle LIKE '%{search}%' OR " +
                $"Department LIKE '%{search}%' OR " +
                $"EmploymentType LIKE '%{search}%'";

            dgvJobs.DataSource = view;
        }

        public JobVacancies(int loggedInID)
        {
            InitializeComponent();
            dgvJobs.AutoGenerateColumns = true;

            this.loggedInAccountID = loggedInID;

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT ApplicantID FROM Applicants WHERE AccountID = @AccountID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", this.loggedInAccountID);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            this.currentApplicantID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Please complete your profile first before applying.",
                                "Profile Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            this.Close();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant profile: " + ex.Message);
            }

            searchPanel.BackColor = Color.FromArgb(250, 250, 250);
            headerPanel.BackColor = Color.FromArgb(25, 118, 210);

            btnSearch.BackColor = Color.FromArgb(33, 150, 243);
            btnApply.BackColor = Color.FromArgb(0, 120, 215);
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnExit.BackColor = Color.FromArgb(231, 76, 60);

            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            dgvJobs.AllowUserToResizeColumns = false;
            dgvJobs.AllowUserToResizeRows = false;
            dgvJobs.AllowUserToDeleteRows = false;

            dgvJobs.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvJobs.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgvJobs.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(204, 229, 255);

            dgvJobs.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvJobs.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvJobs.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 102, 204);

            dgvJobs.RowHeadersDefaultCellStyle.SelectionBackColor =
                Color.Blue;

            dgvJobs.RowHeadersDefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvJobs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvJobs.MultiSelect = false;

            btnApply.Click += btnApply_Click;
            dgvJobs.CellClick += dgvJobs_CellClick;
            btnExit.Click += btnExit_Click;
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;

            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.ReadOnly = true;
            dgvJobs.BackgroundColor = Color.White;
            dgvJobs.GridColor = Color.LightGray;

            LoadJobsFromDatabase();
        }

        private void LoadJobsFromDatabase()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        jv.VacancyID, 
                                        p.PositionName AS JobTitle, 
                                        d.DepartmentName AS Department, 
                                        et.TypeName AS EmploymentType, 
                                        jv.JobStatus AS Status,
                                        jv.Qualifications
                                     FROM JobVacancies jv
                                     INNER JOIN Positions p ON jv.PositionID = p.PositionID
                                     INNER JOIN Departments d ON jv.DepartmentID = d.DepartmentID
                                     INNER JOIN EmploymentTypes et ON jv.EmploymentTypeID = et.EmploymentTypeID
                                     WHERE jv.JobStatus = 'Open'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        jobTable = new DataTable();
                        adapter.Fill(jobTable);

                        dgvJobs.DataSource = jobTable;
                    }
                }
                lblJobCount.Text = $"Total Jobs: {dgvJobs.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading jobs from database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object? sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow != null)
            {

                int selectedVacancyID = Convert.ToInt32(dgvJobs.CurrentRow.Cells[0].Value);
                string position = dgvJobs.CurrentRow.Cells[1].Value?.ToString() ?? "";

                try
                {
                    using (var conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string checkQuery = "SELECT COUNT(*) FROM Applications WHERE ApplicantID = @ApplicantID AND VacancyID = @VacancyID";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);
                            checkCmd.Parameters.AddWithValue("@VacancyID", selectedVacancyID);

                            int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (existingCount > 0)
                            {
                                MessageBox.Show("System Block: You have already applied for this job vacancy.", "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string vacancyCheck = "SELECT JobStatus FROM JobVacancies WHERE VacancyID = @VacancyID";

                        using (MySqlCommand statusCmd = new MySqlCommand(vacancyCheck, conn))
                        {
                            statusCmd.Parameters.AddWithValue("@VacancyID", selectedVacancyID);

                            string status = statusCmd.ExecuteScalar()?.ToString() ?? "";

                            if (status.Trim().ToLower() != "open")
                            {
                                MessageBox.Show(
                                    "This vacancy is already closed.",
                                    "Unavailable",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                                return;
                            }
                        }

                        string insertQuery = @"INSERT INTO Applications (ApplicantID, VacancyID, CurrentStatus, AppliedDate) 
                                               VALUES (@ApplicantID, @VacancyID, 'Draft', NOW());

                                                SELECT LAST_INSERT_ID();";

                        int newApplicationID;

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);
                            cmd.Parameters.AddWithValue("@VacancyID", selectedVacancyID);

                            newApplicationID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string historyQuery = @"INSERT INTO ApplicationStatusHistory (ApplicationID, Status, Remarks)
                                                VALUES (@ApplicationID, 'Draft', 'Go to myapplication, then Submit an application for HR review.')";


                        using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                        {
                            historyCmd.Parameters.AddWithValue("@ApplicationID", newApplicationID);

                            historyCmd.ExecuteNonQuery();

                            AuditTrailManager.LogAction("Applicant", currentApplicantID, "Applied for vacancy ID: " + selectedVacancyID);
                        }

                        MessageBox.Show($"You have successfully applied for:\nJob ID: {selectedVacancyID} - {position}\n\nRecord saved live to database!",
                                        "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException myEx) when (myEx.Number == 1062)
                {
                    MessageBox.Show("Database Guard: You have already submitted an application for this vacancy.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a job from the list first.");
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadJobsFromDatabase();
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountID);
            dashboard.Show();
            this.Close();
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(this.currentApplicantID);
            dashboard.Show();

            this.Close();
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {

        }
    }
}
