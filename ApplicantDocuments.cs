using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using HR_Applicant_Process_Windows_System_MAIN.Database;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class ApplicantDocuments : Form
    {
        private int applicantID;

        public ApplicantDocuments(int dynamicID)
        {
            InitializeComponent();
            this.applicantID = dynamicID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDocumentTypes();
            LoadDocuments();

            txtRemarks.ReadOnly = true;
            txtRemarks.BackColor = SystemColors.Control;

            dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.MultiSelect = false;
        }

        // =========================
        // LOAD TYPES
        // =========================
        private void LoadDocumentTypes()
        {
            cboDocumentType.Items.Clear();
            cboDocumentType.Items.Add("Resume");
            cboDocumentType.Items.Add("Valid ID");
            cboDocumentType.Items.Add("Transcript");
            cboDocumentType.Items.Add("Certificate");
        }

        // =========================
        // LOAD DOCUMENTS
        // =========================
        private void LoadDocuments()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    ad.DocumentID,
                    rt.RequirementName AS DocumentType,
                    ad.FilePath,
                    ad.Status
                FROM ApplicantDocuments ad
                INNER JOIN RequirementTypes rt
                     ON ad.RequirementTypeID = rt.RequirementTypeID
                WHERE ad.ApplicantID = @ApplicantID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDocuments.DataSource = dt;
            }

            CheckMissingRequirements();
        }

        // =========================
        // UPLOAD
        // =========================
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDocumentType.SelectedIndex == -1)
                {
                    MessageBox.Show("Select document type.");
                    return;
                }

                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                string sourcePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(sourcePath);

                string uploadsFolder = Path.Combine(Application.StartupPath, "Uploads");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                string destinationPath = Path.Combine(
                    uploadsFolder,
                    DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName);

                File.Copy(sourcePath, destinationPath, true);

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    int requirementTypeID = 0;

                    string typeQuery = @"
                        SELECT RequirementTypeID
                        FROM RequirementTypes
                        WHERE RequirementName=@Name";

                    MySqlCommand typeCmd = new MySqlCommand(typeQuery, conn);
                    typeCmd.Parameters.AddWithValue("@Name", cboDocumentType.Text);

                    object result = typeCmd.ExecuteScalar();

                    if (result != null)
                    {
                        requirementTypeID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Invalid document type.");
                        return;
                    }

                    string check = @"
                        SELECT COUNT(*) 
                        FROM ApplicantDocuments
                        WHERE ApplicantID=@ApplicantID
                        AND RequirementTypeID=@RequirementTypeID";

                    MySqlCommand checkCmd = new MySqlCommand(check, conn);
                    checkCmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                    checkCmd.Parameters.AddWithValue("@RequirementTypeID", requirementTypeID);

                    bool exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;

                    if (exists)
                    {
                        string update = @"
                                UPDATE ApplicantDocuments
                                SET FilePath=@FilePath,
                                        Status='Submitted'
                                WHERE ApplicantID=@ApplicantID
                                AND RequirementTypeID=@RequirementTypeID";

                        MySqlCommand cmd = new MySqlCommand(update, conn);
                        cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                        cmd.Parameters.AddWithValue("@RequirementTypeID", requirementTypeID);
                        cmd.Parameters.AddWithValue("@FilePath", destinationPath);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string insert = @"
                                INSERT INTO ApplicantDocuments
                                (ApplicantID, RequirementTypeID, FilePath, Status)
                                VALUES
                                (@ApplicantID, @RequirementTypeID, @FilePath, 'Submitted')";

                        MySqlCommand cmd = new MySqlCommand(insert, conn);

                        cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                        cmd.Parameters.AddWithValue("@RequirementTypeID", requirementTypeID);
                        cmd.Parameters.AddWithValue("@FilePath", destinationPath);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Upload successful!");
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Error: " + ex.Message);
            }
        }

        // =========================
        // REFRESH
        // =========================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDocuments();
            CheckMissingRequirements();
        }

        // =========================
        // DELETE (FIXED)
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDocuments.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a document first.");
                    return;
                }

                DataGridViewRow row = dgvDocuments.SelectedRows[0];

                int documentID = Convert.ToInt32(row.Cells["DocumentID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this document?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        DELETE FROM ApplicantDocuments
                        WHERE DocumentID=@DocumentID
                        AND ApplicantID=@ApplicantID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DocumentID", documentID);
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully!");
                LoadDocuments();
                CheckMissingRequirements();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }

        // =========================
        // SHOW REMARKS
        // =========================
        private void dgvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtRemarks.Text = "No remarks available.";
            }
        }

        // =========================
        // MISSING CHECK
        // =========================
        private void CheckMissingRequirements()
        {
            List<string> required = new List<string>
            {
                "Resume",
                "Valid ID",
                "Transcript",
                "Certificate"
            };

            foreach (DataGridViewRow row in dgvDocuments.Rows)
            {
                if (row.IsNewRow) continue;

                string doc = row.Cells["DocumentType"].Value?.ToString();
                if (doc != null)
                    required.Remove(doc);
            }

            lblStatus.Text = required.Count == 0
                ? "Status: Complete"
                : "Missing: " + string.Join(", ", required);
        }

        // SAFE STUB (prevents designer crash)
        private void label2_Click(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(applicantID);
            dashboard.Show();
            this.Close();
        }
    }
}