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
        }

        private void ApplicationStatusForm_Load(object sender, EventArgs e)
        {
            LoadStatusHistory();
        }

        private void LoadStatusHistory()
        {
            string query = "SELECT Status, Remarks, ChangeDate FROM ApplicationStatusHistory WHERE ApplicantID = @ApplicantID ORDER BY ChangeDate DESC";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicantID", this.currentApplicantID);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStatusHistory.DataSource = dt;
                }
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
