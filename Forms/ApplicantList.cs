using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class ApplicantList : Form
    {
        private string connString =
            "server=localhost;database=hr_recruitment_db;uid=root;pwd=MysqlEnzo;";

        public ApplicantList()
        {
            InitializeComponent();
            this.Resize += ApplicantList_Resize;
        }

        private void ApplicantList_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void SearchApplicants(string keyword)
        {
            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        SELECT AccountID,
                               Username,
                               Email
                        FROM ApplicantAccounts
                        WHERE Username LIKE @search";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@search",
                        keyword + "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HRAdminDashboard_Load(object sender, EventArgs e)
        {
            SearchApplicants("");
        }

        private void richTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchApplicants(richTextBoxSearch.Text.Trim());
        }

        private void Back(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hrstaff loginForm = new Hrstaff();
            loginForm.Show();
            this.Hide();
        }
    }
}