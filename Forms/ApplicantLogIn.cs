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
    public partial class ApplicantLogin : Form
    {
        public ApplicantLogin()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString =
                "server=localhost;database=hr_recruitment_db;uid=root;pwd=MysqlEnzo;";

            string username = richTextBox1.Text.Trim();
            string email = richTextBox2.Text.Trim();
            string password = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT AccountID
                                    FROM ApplicantAccounts
                                    WHERE Username = @Username
                                    AND Email = @Email
                                    AND PasswordHash = @PasswordHash";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int loggedInAccountID = Convert.ToInt32(result);

                            MessageBox.Show("Login successful!");

                            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountID);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username, email, or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Applicantregistration registerForm = new Applicantregistration();
            registerForm.Show();
            this.Hide();
        }



        private void Back(object sender, EventArgs e)
        {
            Choice choiceForm = new Choice();
            choiceForm.Show();
            this.Hide();
        }

        private void Changepassapli(object sender, EventArgs e)
        {
            Changepassaplicant choiceForm = new Changepassaplicant();
            choiceForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar)
            {
                textBox1.UseSystemPasswordChar = false;
                button2.Text = "👁";
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                button2.Text = "👁";
            }

        }
    }

}