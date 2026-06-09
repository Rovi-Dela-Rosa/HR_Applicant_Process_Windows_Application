using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class JobVacancies : Form
    {
        private int currentApplicantID;
        private void dgvJobs_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

                lblPosition.Text = "Position: " + (row.Cells["JobTitle"].Value?.ToString() ?? "");
                lblDepartment.Text = "Department: " + (row.Cells["Department"].Value?.ToString() ?? "");
                lblType.Text = "Employment Type: " + (row.Cells["EmploymentType"].Value?.ToString() ?? "");
                lblQualifications.Text = "Qualifications: " + (row.Cells["Qualifications"].Value?.ToString() ?? "");

                lblDocuments.Text = "Required Documents: Please see 'My Documents' page for submission requirements.";
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string search = txtSearch.Text?.ToLower() ?? "";

            foreach (DataGridViewRow row in dgvJobs.Rows)
            {
                if (!row.IsNewRow)
                {
                    string position = row.Cells[1].Value?.ToString()?.ToLower() ?? "";
                    row.Visible = position.Contains(search);
                }
            }
        }

        public JobVacancies(int ApplicantID)
        {
            InitializeComponent();
            this.currentApplicantID = ApplicantID;

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
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvJobs.DataSource = dt;
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

                        string insertQuery = @"INSERT INTO Applications (ApplicantID, VacancyID, CurrentStatus, AppliedDate) 
                                               VALUES (@ApplicantID, @VacancyID, @CurrentStatus, NOW())";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);
                            cmd.Parameters.AddWithValue("@VacancyID", selectedVacancyID);
                            cmd.Parameters.AddWithValue("@CurrentStatus", "Submitted");

                            cmd.ExecuteNonQuery();
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

            foreach (DataGridViewRow row in dgvJobs.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm (currentApplicantID);
            dashboard.Show();
            this.Close();
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
