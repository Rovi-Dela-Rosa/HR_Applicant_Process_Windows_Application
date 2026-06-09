using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void HR(object sender, EventArgs e)
        {
            HRLogin choiceForm = new HRLogin();
            choiceForm.Show();
            this.Hide();
        }

        private void Applicant(object sender, EventArgs e)
        {
            ApplicantLogin choiceForm = new ApplicantLogin();
            choiceForm.Show();
            this.Hide();
        }
    }
}
