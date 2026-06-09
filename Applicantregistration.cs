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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString =
                "server=localhost;database=hr_recruitment_db;uid=root;pwd=ivor_blunt00;";

            string username = richTextBox1.Text;
            string email = richTextBox2.Text;
            string password = richTextBox3.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"INSERT INTO ApplicantAccounts (Username, Email, PasswordHash)
                             VALUES (@Username, @Email, @PasswordHash)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!");
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
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Back(object sender, EventArgs e)
        {
            ApplicantLogin choiceForm = new ApplicantLogin();
            choiceForm.Show();
            this.Hide();
        }
    }
}
