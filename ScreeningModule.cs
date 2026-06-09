using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class Screening: Form
    {
        private string connectionString =
            "server=localhost;port=3306;database=hr_recruitment_db;uid=root;pwd=ivor_blunt00;";

        public Screening()
        {
            InitializeComponent();
        }

        // ================= LOAD FORM =================
        private void Screening_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Qualified");
            cboStatus.Items.Add("Not Qualified");

            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadScreeningData();
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtApplicantId.Text, out int applicantId))
                {
                    MessageBox.Show("Invalid Applicant ID");
                    return;
                }

                if (cboStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Select status");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO Screening (ApplicantID, Status, Remarks)
                    VALUES (@id, @status, @remarks)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", applicantId);
                    cmd.Parameters.AddWithValue("@status", cboStatus.Text);
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Saved successfully!");
                LoadScreeningData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= LOAD DATA =================
        private void LoadScreeningData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT s.ScreeningID,
                           s.ApplicantID,
                           a.FirstName,
                           a.LastName,
                           s.Status,
                           s.Remarks,
                           s.DateScreened
                    FROM Screening s
                    JOIN Applicants a ON s.ApplicantID = a.ApplicantID
                    ORDER BY s.ScreeningID DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvScreening.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        // ================= LOAD BUTTON =================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadScreeningData();
        }

        // ================= CLEAR =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtApplicantId.Clear();
            txtRemarks.Clear();
            cboStatus.SelectedIndex = -1;
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvScreening.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a record first.");
                    return;
                }

                int screeningId = Convert.ToInt32(
                    dgvScreening.SelectedRows[0].Cells["ScreeningID"].Value
                );

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Screening WHERE ScreeningID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", screeningId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully!");

                LoadScreeningData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }

        // ================= GRID CLICK =================
        private void dgvScreening_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvScreening.Rows[e.RowIndex];

                txtApplicantId.Text = row.Cells["ApplicantID"].Value.ToString();
                cboStatus.Text = row.Cells["Status"].Value.ToString();
                txtRemarks.Text = row.Cells["Remarks"].Value.ToString();
            }
        }

        private void dgvScreening_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}