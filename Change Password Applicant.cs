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
    public partial class Changepassaplicant : Form
    {
        string connectionString = "server=localhost;database=hr_recruitment_db;uid=root;pwd=DDNLR023;";

        public Changepassaplicant()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string userOrEmail = richTextBox1.Text.Trim();
            string newPassword = richTextBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(userOrEmail) ||
                string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM ApplicantAccounts
                        WHERE Username = @Input
                           OR Email = @Input";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Input", userOrEmail);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        string updateQuery = @"
                            UPDATE ApplicantAccounts
                            SET PasswordHash = @PasswordHash
                            WHERE Username = @Input
                               OR Email = @Input";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@PasswordHash", newPassword);
                        updateCmd.Parameters.AddWithValue("@Input", userOrEmail);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Password changed successfully!");
                        ApplicantLogin changePassForm = new ApplicantLogin();
                        changePassForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or email not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Back(object sender, EventArgs e)
        {
            ApplicantLogin changePassForm = new ApplicantLogin();
            changePassForm.Show();
            this.Hide();
        }
    }
}
