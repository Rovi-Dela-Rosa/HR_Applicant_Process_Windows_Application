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
            this.Resize += Choice_Resize;
        }

        private void Choice_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int blockWidth = 338 + 60 + 338;
            int blockHeight = 396;

            int startX = (formWidth - blockWidth) / 2;
            int startY = (formHeight - blockHeight) / 2;

            button1.Left = startX;
            button1.Top = startY;

            button2.Left = startX + 338 + 60;
            button2.Top = startY;
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
