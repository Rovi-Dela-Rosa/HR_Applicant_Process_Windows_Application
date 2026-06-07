using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ApplicantDocumentsForm
{
    public partial class Form1 : Form
    {
        private string connectionString =
            "server=localhost;port=3306;database=hr_recruitment_db;uid=root;pwd=KalelSQL123;";

        private int applicantID = 1;

        public Form1()
        {
            InitializeComponent();
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT DocumentID, DocumentType, FileName, FilePath,
                           Status, Remarks, DateSubmitted
                    FROM ApplicantDocuments
                    WHERE ApplicantID = @ApplicantID";

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

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string check = @"
                        SELECT COUNT(*) 
                        FROM ApplicantDocuments
                        WHERE ApplicantID=@ApplicantID
                        AND DocumentType=@DocumentType";

                    MySqlCommand checkCmd = new MySqlCommand(check, conn);
                    checkCmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                    checkCmd.Parameters.AddWithValue("@DocumentType", cboDocumentType.Text);

                    bool exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;

                    if (exists)
                    {
                        string update = @"
                            UPDATE ApplicantDocuments
                            SET FileName=@FileName,
                                FilePath=@FilePath,
                                Status='Submitted',
                                DateSubmitted=NOW()
                            WHERE ApplicantID=@ApplicantID
                            AND DocumentType=@DocumentType";

                        MySqlCommand cmd = new MySqlCommand(update, conn);
                        cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                        cmd.Parameters.AddWithValue("@DocumentType", cboDocumentType.Text);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
                        cmd.Parameters.AddWithValue("@FilePath", destinationPath);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string insert = @"
                            INSERT INTO ApplicantDocuments
                            (ApplicantID, DocumentType, FileName, FilePath, Status)
                            VALUES
                            (@ApplicantID, @DocumentType, @FileName, @FilePath, 'Submitted')";

                        MySqlCommand cmd = new MySqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                        cmd.Parameters.AddWithValue("@DocumentType", cboDocumentType.Text);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
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

                using (MySqlConnection conn = new MySqlConnection(connectionString))
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
                txtRemarks.Text =
                    dgvDocuments.Rows[e.RowIndex].Cells["Remarks"].Value?.ToString() ?? "";
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
    }
}