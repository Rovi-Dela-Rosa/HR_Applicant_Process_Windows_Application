using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ApplicantDocumentsForm
{
    public partial class ApplicantDocuments : Form
    {
        private string connectionString =
            "server=localhost;port=3306;database=hr_recruitment_db;uid=root;pwd=KalelSQL123;";

        private int applicantID = 1;

        public ApplicantDocuments()
        {
            InitializeComponent();

            this.Load += ApplicantDocuments_Load;

            btnUpload.Click += btnUpload_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnDelete.Click += btnDelete_Click;
            btnSubmit.Click += btnSubmit_Click;
        }

        // =========================
        private void ApplicantDocuments_Load(object sender, EventArgs e)
        {
            LoadRequirementTypes();
            LoadDocuments();
        }

        // =========================
        private void LoadRequirementTypes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT RequirementTypeID, RequirementName FROM RequirementTypes", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboDocumentType.DataSource = dt;
                cboDocumentType.DisplayMember = "RequirementName";
                cboDocumentType.ValueMember = "RequirementTypeID";
                cboDocumentType.SelectedIndex = -1;
            }
        }

        // =========================
        private void LoadDocuments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT d.DocumentID,
                           r.RequirementName,
                           d.FilePath,
                           d.Status,
                           IFNULL(d.Remarks,'') AS Remarks,
                           d.DateSubmitted
                    FROM ApplicantDocuments d
                    INNER JOIN RequirementTypes r
                        ON d.RequirementTypeID = r.RequirementTypeID
                    WHERE d.ApplicantID=@ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDocuments.DataSource = dt;
            }
        }

        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (cboDocumentType.SelectedValue == null) return;

            int typeID = Convert.ToInt32(cboDocumentType.SelectedValue);

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog1.FileName;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE ApplicantDocuments
                    SET FilePath=@FilePath,
                        Status='Uploaded'
                    WHERE ApplicantID=@ApplicantID
                    AND RequirementTypeID=@TypeID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                cmd.Parameters.AddWithValue("@TypeID", typeID);

                cmd.ExecuteNonQuery();
            }

            LoadDocuments();
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.CurrentRow == null)
                return;

            string status = dgvDocuments.CurrentRow.Cells["Status"].Value.ToString();

            
            if (status == "Submitted")
            {
                MessageBox.Show("You cannot delete a submitted document.");
                return;
            }

            int documentID = Convert.ToInt32(dgvDocuments.CurrentRow.Cells["DocumentID"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE ApplicantDocuments
            SET FilePath = NULL,
                Status = 'Missing',
                Remarks = '',
                DateSubmitted = NULL
            WHERE DocumentID = @DocumentID
            AND ApplicantID = @ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DocumentID", documentID);
                cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                cmd.ExecuteNonQuery();
            }

            LoadDocuments();
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string check = @"
                    SELECT COUNT(*)
                    FROM ApplicantDocuments
                    WHERE ApplicantID=@ApplicantID
                    AND (FilePath IS NULL OR FilePath='')";

                MySqlCommand checkCmd = new MySqlCommand(check, conn);
                checkCmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                int missing = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (missing > 0)
                {
                    MessageBox.Show("Complete all documents first.");
                    return;
                }

                string finalizeDocs = @"
                    UPDATE ApplicantDocuments
                    SET Status='Submitted',
                        DateSubmitted=NOW()
                    WHERE ApplicantID=@ApplicantID";

                MySqlCommand cmd1 = new MySqlCommand(finalizeDocs, conn);
                cmd1.Parameters.AddWithValue("@ApplicantID", applicantID);
                cmd1.ExecuteNonQuery();

                string updateApp = @"
                    UPDATE Applications
                    SET CurrentStatus='Submitted'
                    WHERE ApplicantID=@ApplicantID";

                MySqlCommand cmd2 = new MySqlCommand(updateApp, conn);
                cmd2.Parameters.AddWithValue("@ApplicantID", applicantID);
                cmd2.ExecuteNonQuery();
            }

            LoadDocuments();
        }
    }
}