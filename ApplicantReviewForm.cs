using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantReview
{
    public partial class ApplicantReviewForm : Form
    {
        private string connectionString =
            "server=localhost;port=3306;database=hr_recruitment_db;uid=root;pwd=KalelSQL123;";

        private int selectedApplicantID = 0;

        public ApplicantReviewForm()
        {
            InitializeComponent();
            dgvApplicants.CellClick += dgvApplicants_CellClick;
        }

        private void ApplicantReviewForm_Load(object sender, EventArgs e)
        {
            LoadStatusFilter();
            LoadApplicants();
        }

        // =========================
        // LOAD APPLICANTS
        // =========================
        private void LoadApplicants(string search = "", string status = "All")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        ApplicantID,
                        FirstName,
                        LastName,
                        Email
                    FROM Applicants
                    WHERE (@search = ''
                        OR FirstName LIKE @searchLike
                        OR LastName LIKE @searchLike
                        OR Email LIKE @searchLike)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@searchLike", "%" + search + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvApplicants.DataSource = dt;
            }
        }

        // =========================
        // SELECT APPLICANT
        // =========================
        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var value = dgvApplicants.Rows[e.RowIndex].Cells["ApplicantID"].Value;

            if (value == null || value == DBNull.Value)
                return;

            selectedApplicantID = Convert.ToInt32(value);

            LoadProfile();
            LoadDocuments();
        }

        // =========================
        // LOAD PROFILE
        // =========================
        private void LoadProfile()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT FirstName, LastName, Email, ContactNumber, Address
                    FROM Applicants
                    WHERE ApplicantID = @ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["FirstName"] + " " + reader["LastName"];
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["ContactNumber"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                }
            }
        }

        // =========================
        // LOAD DOCUMENTS
        // =========================
        private void LoadDocuments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        d.DocumentID,
                        r.RequirementName,
                        d.FilePath,
                        d.Status,
                        d.Remarks,
                        d.DateSubmitted
                    FROM ApplicantDocuments d
                    INNER JOIN RequirementTypes r 
                        ON d.RequirementTypeID = r.RequirementTypeID
                    WHERE d.ApplicantID = @ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDocuments.DataSource = dt;
            }
        }

        // =========================
        // LOCK APPLICATION
        // =========================
        private void btnLockApplication_Click(object sender, EventArgs e)
        {
            if (selectedApplicantID <= 0)
            {
                MessageBox.Show("Select an applicant first.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE Applications
                    SET CurrentStatus = 'Locked'
                    WHERE ApplicantID = @ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                cmd.ExecuteNonQuery();
            }

            LoadApplicants();
        }

        // =========================
        // FILTER + SEARCH
        // =========================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim(), cboStatusFilter.Text);
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim(), cboStatusFilter.Text);
        }

        private void LoadStatusFilter()
        {
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("All");
            cboStatusFilter.Items.Add("Draft");
            cboStatusFilter.Items.Add("Submitted");
            cboStatusFilter.Items.Add("Locked");
            cboStatusFilter.Items.Add("Approved");
            cboStatusFilter.Items.Add("Rejected");

            cboStatusFilter.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplicants();
        }
    }
}