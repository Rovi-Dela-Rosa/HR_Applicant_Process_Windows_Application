using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class ApplicantReviewForm : Form
    {
        private string connectionString =
            "server=localhost;port=3306;database=hr_recruitment_db;uid=root;pwd=ivor_blunt00;";

        private int selectedApplicantID = 0;

        public ApplicantReviewForm()
        {
            InitializeComponent();

            this.Load += ApplicantReviewForm_Load;

            dgvApplicants.CellClick += dgvApplicants_CellClick;
            btnLockApplication.Click += btnLockApplication_Click;
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            cboStatusFilter.SelectedIndexChanged += cboStatusFilter_SelectedIndexChanged;
        }

        
        private void ApplicantReviewForm_Load(object sender, EventArgs e)
        {
            LoadStatusFilter();
            LoadApplicants();
        }

       
        private void LoadApplicants(string search = "", string status = "All")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    a.ApplicantID,
                    a.FirstName,
                    a.LastName,
                    IFNULL(aa.Email,'') AS Email,
                    IFNULL(ap.CurrentStatus,'No Application') AS Status
                FROM Applicants a
                LEFT JOIN ApplicantAccounts aa
                    ON a.AccountID = aa.AccountID
                LEFT JOIN Applications ap
                    ON a.ApplicantID = ap.ApplicantID
                WHERE
                (
                    @search = ''
                    OR a.FirstName LIKE @searchLike
                    OR a.LastName LIKE @searchLike
                    OR aa.Email LIKE @searchLike
                )
                AND
                (
                    @status = 'All'
                    OR ap.CurrentStatus = @status
                )";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@searchLike", "%" + search + "%");
                cmd.Parameters.AddWithValue("@status", status);

                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);

                dgvApplicants.DataSource = dt;
            }
        }

        // =========================
        // SELECT APPLICANT (FIXED DBNull CRASH)
        // =========================
        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object value = dgvApplicants.Rows[e.RowIndex].Cells["ApplicantID"].Value;

            if (value == null || value == DBNull.Value)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            selectedApplicantID = Convert.ToInt32(value);

            LoadProfile();
            LoadDocuments();
        }

        
        private void LoadProfile()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    a.FirstName,
                    a.LastName,
                    IFNULL(aa.Email,'') AS Email,
                    IFNULL(a.ContactNumber,'') AS ContactNumber,
                    IFNULL(a.Address,'') AS Address
                FROM Applicants a
                LEFT JOIN ApplicantAccounts aa
                    ON a.AccountID = aa.AccountID
                WHERE a.ApplicantID = @ApplicantID";

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

        
        private void LoadDocuments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    d.DocumentID,
                    r.RequirementName,
                    IFNULL(d.FilePath,'') AS FilePath,
                    IFNULL(d.Status,'') AS Status,
                    IFNULL(d.Remarks,'') AS Remarks,
                    d.DateSubmitted
                FROM ApplicantDocuments d
                INNER JOIN RequirementTypes r
                    ON d.RequirementTypeID = r.RequirementTypeID
                WHERE d.ApplicantID = @ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);

                dgvDocuments.DataSource = dt;
            }
        }

        
        
        private void btnLockApplication_Click(object sender, EventArgs e)
        {
            if (selectedApplicantID == 0)
            {
                MessageBox.Show("Select an applicant first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Lock this application?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string check = @"
                SELECT COUNT(*)
                FROM Applications
                WHERE ApplicantID=@ApplicantID";

                MySqlCommand cmd = new MySqlCommand(check, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("No application found.");
                    return;
                }

                string update = @"
                UPDATE Applications
                SET CurrentStatus='Locked'
                WHERE ApplicantID=@ApplicantID";

                MySqlCommand updateCmd = new MySqlCommand(update, conn);
                updateCmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                updateCmd.ExecuteNonQuery();
            }

            LoadApplicants();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim(), cboStatusFilter.Text);
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim(), cboStatusFilter.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboStatusFilter.SelectedIndex = 0;
            LoadApplicants();
        }
    }
}