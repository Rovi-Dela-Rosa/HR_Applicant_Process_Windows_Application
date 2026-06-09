using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class ApplicantProfileForm : Form
    {
        private int currentApplicantID;
        private int loggedInAccountID;
        private int accountID;
        private void LoadProfile()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
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
                        if (reader["DateOfBirth"] != DBNull.Value && reader["DateOfBirth"] != null && !string.IsNullOrEmpty(reader["DateOfBirth"].ToString()))
                        {
                            dtpDateOfBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                        }
                        else
                        {
                            dtpDateOfBirth.Value = DateTime.Now;
                        }
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
        public ApplicantProfileForm(int loggedInID)
        {
            InitializeComponent();
            this.accountID = accountID;
            this.loggedInAccountID = loggedInID;
            this.currentApplicantID = loggedInID;
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

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Applicants
                        SET FirstName=@FirstName,
                            LastName=@LastName,
                            ContactNumber=@ContactNumber,
                            Address=@Address,
                            DateOfBirth=@DateOfBirth,
                            HighestEducation=@Education,
                            Skills=@Skills,
                            WorkExperience=@WorkExperience
                        WHERE ApplicantID=@ApplicantID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@AccountID", this.loggedInAccountID);
                    cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy-MM-dd"));
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

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Applicants
                        (AccountID, FirstName, LastName, ContactNumber,
                         Address, DateOfBirth, HighestEducation,
                         Skills, WorkExperience)
                         VALUES
                        (@AccountID, @FirstName, @LastName, @ContactNumber,
                         @Address, @DateOfBirth, @Education,
                         @Skills, @WorkExperience)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@AccountID", loggedInAccountID);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy-MM-dd"));
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

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(this.currentApplicantID);
            dashboard.Show();
            this.Close();
        }
    }
}
