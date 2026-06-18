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
        private int loggedInAccountID = 0;
        private void LoadProfile()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Applicants WHERE AccountID = @AccountID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", this.loggedInAccountID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.currentApplicantID = Convert.ToInt32(reader["ApplicantID"]);

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

                                btnSave.Enabled = false;
                                btnUpdate.Enabled = true;
                            }
                            else
                            {
                                this.currentApplicantID = 0;
                                ClearFields();
                                btnSave.Enabled = true;
                                btnUpdate.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ApplicantProfileForm(int loggedInID)
        {
            InitializeComponent();
            this.loggedInAccountID = loggedInID;

            this.Resize += ApplicantProfileForm_Resize;
        }

        private void ApplicantProfileForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int uiWidth = 850;
            int uiHeight = 620;

            int offsetX = (formWidth - uiWidth) / 2;
            int offsetY = (formHeight - uiHeight) / 2;

            lblTitle.Left = offsetX + 320;
            lblTitle.Top = offsetY + 10;

            grpPersonalInfo.Left = offsetX;
            grpPersonalInfo.Top = offsetY + 60;

            grpContact.Left = offsetX;
            grpContact.Top = offsetY + 190;

            grpEducation.Left = offsetX;
            grpEducation.Top = offsetY + 310;

            groupBox2.Left = offsetX;
            groupBox2.Top = offsetY + 430;

            grpSkills.Left = offsetX + 460;
            grpSkills.Top = offsetY + 310;

            btnBack.Left = offsetX;
            btnBack.Top = offsetY + 570;

            btnUpdate.Left = offsetX + 560;
            btnUpdate.Top = offsetY + 570;

            btnSave.Left = offsetX + 670;
            btnSave.Top = offsetY + 570;
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
            if (this.currentApplicantID == 0)
            {
                MessageBox.Show("No existing profile found to update. Please save your profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", this.currentApplicantID);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Education", txtEducation.Text.Trim());
                        cmd.Parameters.AddWithValue("@Skills", txtSkills.Text.Trim());
                        cmd.Parameters.AddWithValue("@WorkExperience", txtWrkExp.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Applicants WHERE AccountID = @AccountID";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@AccountID", this.loggedInAccountID);

                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            MessageBox.Show(
                                "Profile already exists. Please use Update instead.",
                                "Duplicate Profile",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            LoadProfile();
                            return;
                        }
                    }

                    string query = @"INSERT INTO Applicants
                        (AccountID, FirstName, LastName, ContactNumber, Address, DateOfBirth, HighestEducation, Skills, WorkExperience)
                        VALUES
                        (@AccountID, @FirstName, @LastName, @ContactNumber, @Address, @DateOfBirth, @Education, @Skills, @WorkExperience)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", this.loggedInAccountID);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Education", txtEducation.Text.Trim());
                        cmd.Parameters.AddWithValue("@Skills", txtSkills.Text.Trim());
                        cmd.Parameters.AddWithValue("@WorkExperience", txtWrkExp.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadProfile();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(this.loggedInAccountID);
            dashboard.Show();
            this.Close();
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            txtEducation.Clear();
            txtSkills.Clear();
            txtWrkExp.Clear();
        }
    }
}
