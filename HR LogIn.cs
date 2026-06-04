using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HR_Recruitment_System
{
    public partial class HRLogin : Form
    {
        public HRLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString =
                "server=localhost;database=hr_recruitment_db;uid=root;pwd=DDNLR023;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MessageBox.Show("Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }



        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetHRUsername(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
    
    }
}
