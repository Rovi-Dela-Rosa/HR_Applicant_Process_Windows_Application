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
    public partial class Applicantregistration : Form
    {
        public Applicantregistration()
        {
            InitializeComponent();
            this.Resize += Applicantregistration_Resize;
        }

        private void Applicantregistration_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString =
    "server=localhost;database=hr_recruitment_db;uid=root;pwd=MysqlEnzo;";

            string username = richTextBox1.Text.Trim();
            string email = richTextBox2.Text.Trim();
            string password = richTextBox3.Text.Trim();


            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please complete all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (!email.Contains("@"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM ApplicantAccounts 
                WHERE Email = @Email";


                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);

                        int existingEmail =
                            Convert.ToInt32(checkCmd.ExecuteScalar());


                        if (existingEmail > 0)
                        {
                            MessageBox.Show(
                                "This email is already registered. Please use another email.",
                                "Duplicate Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    string query = @"
                INSERT INTO ApplicantAccounts 
                (Username, Email, PasswordHash)
                VALUES 
                (@Username, @Email, @PasswordHash)";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);


                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Registration successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            AuditTrailManager.LogAction("Applicant", Convert.ToInt32(cmd.LastInsertedId),"Created applicant account");

                            ApplicantLogin choiceForm = new ApplicantLogin();
                            choiceForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            ApplicantLogin choiceForm = new ApplicantLogin();
            choiceForm.Show();
            this.Hide();
        }

        private void Applicantregistration_Load(object sender, EventArgs e)
        {

        }
    }
}
