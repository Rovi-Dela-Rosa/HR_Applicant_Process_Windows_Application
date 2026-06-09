using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class HRAdminDashboard : Form
    {
        public HRAdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            HRLogin loginForm = new HRLogin();
            loginForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddHR_Click(object sender, EventArgs e)
        {
            string username = richTextBox1.Text.Trim();
            string email = richTextBox2.Text.Trim();
            string password = richTextBox3.Text.Trim();
            string roleIdText = richTextBox4.Text.Trim();

            if (username == "" || email == "" || password == "" || roleIdText == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int roleId;

            if (!int.TryParse(roleIdText, out roleId))
            {
                MessageBox.Show("Role ID must be a number.");
                return;
            }

            string connString =
                "server=localhost;database=hr_recruitment_db;uid=root;pwd=DDNLR023;";

            string query = @"
        INSERT INTO Users
        (Username, Email, PasswordHash, FullName, RoleID)
        VALUES
        (@username, @email, @password, @fullname, @roleid)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Temporary FullName
                    cmd.Parameters.AddWithValue("@fullname", username);

                    cmd.Parameters.AddWithValue("@roleid", roleId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("HR Member Added Successfully!");

                    richTextBox1.Clear();
                    richTextBox2.Clear();
                    richTextBox3.Clear();
                    richTextBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            string username = richTextBox5.Text.Trim();
            string roleIdText = richTextBox6.Text.Trim();

            if (username == "" || roleIdText == "")
            {
                MessageBox.Show("Please enter Username and Role ID.");
                return;
            }

            int roleId;

            if (!int.TryParse(roleIdText, out roleId))
            {
                MessageBox.Show("Role ID must be a number.");
                return;
            }

            string connString =
                "server=localhost;database=hr_recruitment_db;uid=root;pwd=DDNLR023;";

            string query =
                "UPDATE Users SET RoleID = @roleId WHERE Username = @username";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Role updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void JobVacant(object sender, EventArgs e)
        {
            JobVacancyManagement loginForm = new JobVacancyManagement();
            loginForm.Show();
            this.Hide();
        }

        private void ApplicantList(object sender, EventArgs e)
        {
            ApplicantList loginForm = new ApplicantList();
            loginForm.Show();
            this.Hide();
        }



        private void Applicantreviewie(object sender, EventArgs e)
        {
            ApplicantReviewForm loginForm = new ApplicantReviewForm();
            loginForm.Show();
            this.Hide();
        }

        private void Screening(object sender, EventArgs e)
        {
            Screening loginForm = new Screening();
            loginForm.Show();
            this.Hide();
        }

        private void Interviewsched(object sender, EventArgs e)
        {
            Interviewsched loginForm = new Interviewsched();
            loginForm.Show();
            this.Hide();
        }

        private void Intervieweval(object sender, EventArgs e)
        {
            InterviewEval loginForm = new InterviewEval();
            loginForm.Show();
            this.Hide();
        }

        private void Hiredeci(object sender, EventArgs e)
        {
            HireDecision loginForm = new HireDecision();
            loginForm.Show();
            this.Hide();
        }

        private void Report(object sender, EventArgs e)
        {
            Report loginForm = new Report();
            loginForm.Show();
            this.Hide();
        }

        private void ApplicantLists(object sender, EventArgs e)
        {
            ApplicantList loginForm = new ApplicantList();
            loginForm.Show();
            this.Hide();
        }

        private void Maintenance(object sender, EventArgs e)
        {
            MaintenanceModule loginForm = new MaintenanceModule();
            loginForm.Show();
            this.Hide();
        }
    }
}
