using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class ApplicantDashboardForm : Form
    {
        private int testApplicantId = 1;
        public ApplicantDashboardForm()
        {
            InitializeComponent();
        }
        private void ApplicantDashboardForm_Load(object sender, EventArgs e)
        {
            LoadApplicationStatus();
            LoadMissingDocumentsCount();
            LoadInterviewSchedule();
        }

        private void LoadApplicationStatus()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();


                    string query = @"SELECT j.JobTitle, a.CurrentStatus, a.AppliedDate 
                                     FROM Applications a
                                     INNER JOIN JobVacancies j ON a.VacancyID = j.VacancyID
                                     WHERE a.ApplicantID = @ApplicantID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", testApplicantId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblJobTitle.Text = reader["JobTitle"].ToString();
                                lblStatus.Text = reader["CurrentStatus"].ToString();

                                DateTime appliedDate = Convert.ToDateTime(reader["AppliedDate"]);
                                lblDateApplied.Text = appliedDate.ToString("MMMM dd, yyyy");
                            }
                            else
                            {

                                lblJobTitle.Text = "No Active Application";
                                lblStatus.Text = "Draft / No Status";
                                lblDateApplied.Text = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMissingDocumentsCount()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) 
                                     FROM RequirementTypes r
                                     LEFT JOIN ApplicantDocuments d ON r.RequirementTypeID = d.RequirementTypeID 
                                                                    AND d.ApplicantID = @ApplicantID
                                     WHERE d.DocumentID IS NULL OR d.Status = 'Rejected'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", testApplicantId);
                        int missingCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (missingCount > 0)
                        {
                            lblMissingDocsStatus.Text = "Incomplete / Missing Files";
                            lblMissingDocsCount.Text = $"You have {missingCount} missing item(s).";
                            lblMissingDocsCount.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            lblMissingDocsStatus.Text = "Complete";
                            lblMissingDocsCount.Text = "All documents submitted successfully.";
                            lblMissingDocsCount.ForeColor = System.Drawing.Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating missing documents: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInterviewSchedule()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            i.InterviewDate, 
                            i.Location, 
                            IFNULL(u.FullName, 'TBD (To Be Determined)') AS 'InterviewerName'
                        FROM InterviewSchedules i
                        LEFT JOIN Users u ON i.InterviewerID = u.UserID
                        INNER JOIN Applications a ON i.ApplicationID = a.ApplicationID
                        WHERE a.ApplicantID = @ApplicantID AND i.Status = 'Scheduled'
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", testApplicantId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                DateTime interviewDate = Convert.ToDateTime(reader["InterviewDate"]);

                                lblInterviewDateTime.Text = interviewDate.ToString("MMMM dd, yyyy - hh:mm tt");
                                lblInterviewerName.Text = reader["InterviewerName"].ToString();
                                lblInterviewLocation.Text = reader["Location"].ToString();
                            }
                            else
                            {

                                lblInterviewDateTime.Text = "[ No Interview Scheduled Yet ]";
                                lblInterviewerName.Text = "N/A";
                                lblInterviewLocation.Text = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interview schedule: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGoToProfile_Click(object sender, EventArgs e)
        {

            ApplicantProfileForm profileForm = new ApplicantProfileForm();
            profileForm.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToProfile_Click_1(object sender, EventArgs e)
        {
            ApplicantProfileForm profileForm = new ApplicantProfileForm();
            profileForm.Show();
        }

        private void ApplicantDashboardForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblJobTitle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
