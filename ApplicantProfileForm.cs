using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HR_RecruitmentSystem
{
    public partial class ApplicantProfileForm : Form
    {
        private void LoadProfile()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Applicants LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        currentApplicantID = Convert.ToInt32(reader["ApplicantID"]);

                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        txtContactNumber.Text = reader["ContactNumber"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                        txtEducation.Text = reader["HighestEducation"].ToString();
                        txtSkills.Text = reader["Skills"].ToString();
                        txtWrkExp.Text = reader["WorkExperience"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int currentApplicantID = 0;
        public ApplicantProfileForm()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWrkExp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Applicants
                        SET FirstName=@FirstName,
                            LastName=@LastName,
                            ContactNumber=@ContactNumber,
                            Address=@Address,
                            HighestEducation=@Education,
                            Skills=@Skills,
                            WorkExperience=@WorkExperience
                        WHERE ApplicantID=@ApplicantID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Education", txtEducation.Text);
                    cmd.Parameters.AddWithValue("@Skills", txtSkills.Text);
                    cmd.Parameters.AddWithValue("@WorkExperience", txtWrkExp.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("First Name is required.");
                return;
            }

            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Last Name is required.");
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Applicants
                        (FirstName, LastName, ContactNumber,
                         Address, HighestEducation,
                         Skills, WorkExperience)
                         VALUES
                        (@FirstName, @LastName, @ContactNumber,
                         @Address, @Education,
                         @Skills, @WorkExperience)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Education", txtEducation.Text);
                    cmd.Parameters.AddWithValue("@Skills", txtSkills.Text);
                    cmd.Parameters.AddWithValue("@WorkExperience", txtWrkExp.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grpEducation_Enter(object sender, EventArgs e)
        {

        }

        private void grpPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void ApplicantProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void ApplicantProfileForm_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
