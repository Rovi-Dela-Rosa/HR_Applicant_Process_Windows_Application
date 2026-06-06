using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR_Recruitment_System
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
    }
}
