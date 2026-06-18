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
    public partial class Hrstaff : Form
    {
        public Hrstaff()
        {
            InitializeComponent();
            LoadApplicantCount();
            LoadTotalHired();

            this.Resize += Hrstaff_Resize;
        }

        private void Hrstaff_Resize(object sender, EventArgs e)
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Height = this.ClientSize.Height;

            panel2.Left = panel1.Width;
            panel2.Top = 0;
            panel2.Width = this.ClientSize.Width - panel1.Width;

            int availableHeight = this.ClientSize.Height - panel2.Height;

            panel4.Left = panel1.Width + (this.ClientSize.Width - panel1.Width - panel4.Width) / 2;
            panel4.Top = panel2.Height + 30;
        }

        private void Logout(object sender, EventArgs e)
        {
            Choice choiceForm = new Choice();
            choiceForm.Show();
            this.Hide();
        }

        private void ApplicantList(object sender, EventArgs e)
        {
            ApplicantList choiceForm = new ApplicantList();
            choiceForm.Show();
            this.Hide();
        }

        private void Screening(object sender, EventArgs e)
        {
            Screening2 choiceForm = new Screening2();
            choiceForm.Show();
            this.Hide();
        }

        private void InterviewSched(object sender, EventArgs e)
        {
            InterviewSchedulingForm choiceForm = new InterviewSchedulingForm();
            choiceForm.Show();
            this.Hide();
        }

        private void InterviewEval(object sender, EventArgs e)
        {
            InterviewEvaluationForm choiceForm = new InterviewEvaluationForm();
            choiceForm.Show();
            this.Hide();
        }

        private void Reports(object sender, EventArgs e)
        {
            Report choiceForm = new Report();
            choiceForm.Show();
            this.Hide();
        }

        private void ApplicantReview(object sender, EventArgs e)
        {
            ApplicantReviewForm choiceForm = new ApplicantReviewForm();
            choiceForm.Show();
            this.Hide();
        }

        private void LoadApplicantCount()
        {
            string connString = "server=localhost;database=hr_recruitment_db;uid=root;pwd=MysqlEnzo;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM ApplicantAccounts";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        lblApplicantCount.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant count: " + ex.Message);
            }
        }



        private void LoadTotalHired()
        {
            string connString = "server=localhost;database=hr_recruitment_db;uid=root;pwd=MysqlEnzo;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*)
                             FROM HiringDecisions
                             WHERE DecisionStatus = 'Hired'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int totalHired = Convert.ToInt32(cmd.ExecuteScalar());

                        lblTotalHired.Text = totalHired.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total hired: " + ex.Message);
            }

        }
    }
}
