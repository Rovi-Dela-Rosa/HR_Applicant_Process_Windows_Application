using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
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
            btnViewDocument.Click += btnViewDocument_Click;
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

            AuditTrailManager.LogAction("HR Staff", selectedApplicantID, "Viewed applicant profile and submitted documents");
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
                dgvDocuments.Columns["FilePath"].Visible = false;
                dgvDocuments.Columns["DocumentID"].Visible = false;

                dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDocuments.MultiSelect = false;
                dgvDocuments.ReadOnly = true;
                dgvDocuments.RowHeadersVisible = false;
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
                "Start to review and lock this application?",
                "Confirm.",
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
                SET CurrentStatus='Under Review'
                WHERE ApplicantID=@ApplicantID";

                MySqlCommand updateCmd = new MySqlCommand(update, conn);
                updateCmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                updateCmd.ExecuteNonQuery();

                string getApplication = @"
                SELECT ApplicationID
                FROM Applications
                WHERE ApplicantID=@ApplicantID
                LIMIT 1";

                int applicationID = 0;

                using (MySqlCommand idCmd = new MySqlCommand(getApplication, conn))
                {
                    idCmd.Parameters.AddWithValue("@ApplicantID", selectedApplicantID);

                    applicationID = Convert.ToInt32(idCmd.ExecuteScalar());
                }

                string historyQuery = @"
                INSERT INTO ApplicationStatusHistory
                (ApplicationID, Status, Remarks)
                VALUES
                (@ApplicationID,
                'Under Review',
                'HR started reviewing the application.')";


                using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                {
                    historyCmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                    historyCmd.ExecuteNonQuery();
                }
            }

            LoadApplicants();
        }


        private void LoadStatusFilter()
        {
            cboStatusFilter.Items.Clear();

            cboStatusFilter.Items.Add("All");
            cboStatusFilter.Items.Add("Draft");
            cboStatusFilter.Items.Add("Submitted");
            cboStatusFilter.Items.Add("Under Review");
            cboStatusFilter.Items.Add("Shortlisted");
            cboStatusFilter.Items.Add("For Interview");
            cboStatusFilter.Items.Add("For Assessment");
            cboStatusFilter.Items.Add("For Final Review");
            cboStatusFilter.Items.Add("Accepted");
            cboStatusFilter.Items.Add("Rejected");
            cboStatusFilter.Items.Add("Withdrawn");

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

        private void Back(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hrstaff loginForm = new Hrstaff();
            loginForm.Show();
            this.Hide();
        }

        private void btnViewDocument_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a document first.");
                return;
            }


            string filePath =
                dgvDocuments.SelectedRows[0]
                .Cells["FilePath"]
                .Value.ToString();


            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("No file available.");
                return;
            }


            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show(
                    "The document file cannot be found.",
                    "Missing File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}