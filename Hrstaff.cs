using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class Hrstaff : Form
    {
        public Hrstaff()
        {
            InitializeComponent();
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
            Screening choiceForm = new Screening();
            choiceForm.Show();
            this.Hide();
        }

        private void InterviewSched(object sender, EventArgs e)
        {
            Interviewsched choiceForm = new Interviewsched();
            choiceForm.Show();
            this.Hide();
        }

        private void InterviewEval(object sender, EventArgs e)
        {
            InterviewEval choiceForm = new InterviewEval();
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
    }
}
