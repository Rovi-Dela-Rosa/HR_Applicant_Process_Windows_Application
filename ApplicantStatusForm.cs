using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN.Forms
{
    public partial class ApplicationStatusForm : Form
    {
        private int currentApplicantID;
        public ApplicationStatusForm(int applicantID)
        {
            InitializeComponent();
            this.currentApplicantID = applicantID;

            this.Load += ApplicationStatusForm_Load;
        }

        private void ApplicationStatusForm_Load(object sender, EventArgs e)
        {
            LoadStatusHistory();
        }

        private void LoadStatusHistory()
        {

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    p.PositionName AS Position,
                    ash.Status,
                    ash.Remarks,
                    ash.ChangedAt
                FROM ApplicationStatusHistory ash
                INNER JOIN Applications a
                    ON ash.ApplicationID = a.ApplicationID
                INNER JOIN JobVacancies jv
                    ON a.VacancyID = jv.VacancyID
                INNER JOIN Positions p
                    ON jv.PositionID = p.PositionID
                WHERE a.ApplicantID = @ApplicantID
                ORDER BY ash.ChangedAt DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ApplicantID", this.currentApplicantID);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvStatusHistory.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application status: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(this.currentApplicantID);
            dashboard.Show();

            this.Close();
        }
    }
}
