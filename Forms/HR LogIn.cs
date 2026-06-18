using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class HRLogin : Form
    {
        public HRLogin()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = richTextBox1.Text.Trim();
            string email = richTextBox2.Text.Trim();
            string password = textBox1.Text;

            string connString = "server=localhost;database=hr_recruitment_db;uid=root;pwd=MysqlEnzo;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                string query = @"SELECT r.RoleName 
                         FROM Users u 
                         JOIN Roles r ON u.RoleID = r.RoleID 
                         WHERE u.Username = @username 
                         AND u.Email = @email 
                         AND u.PasswordHash = @password";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role == "Admin")
                        {
                            new HRAdminDashboard().Show();
                        }
                        else
                        {
                            new Hrstaff().Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username, Email, or Password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void Back(object sender, EventArgs e)
        {
            Choice choiceForm = new Choice();
            choiceForm.Show();
            this.Hide();
        }

        private void Changepass(object sender, EventArgs e)
        {
            HrChangePass changePassForm = new HrChangePass();
            changePassForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar)
            {
                textBox1.UseSystemPasswordChar = false;
                button1.Text = "👁";
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                button1.Text = "👁";
            }
        }
    }
}

