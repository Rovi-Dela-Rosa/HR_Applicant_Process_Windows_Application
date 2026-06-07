using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class JobVacancies : Form
    {
        private void dgvJobs_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string jobID = dgvJobs.Rows[e.RowIndex]
                    .Cells[0]
                    .Value?
                    .ToString() ?? "";

                if (jobID == "J001")
                {
                    lblPosition.Text = "Position: Software Developer";
                    lblDepartment.Text = "Department: IT";
                    lblType.Text = "Employment Type: Full-Time";
                    lblQualifications.Text = "Qualifications: BSIT/BSCS Graduate";
                    lblDocuments.Text = "Required Documents: Resume, TOR";
                }
                else if (jobID == "J002")
                {
                    lblPosition.Text = "Position: HR Assistant";
                    lblDepartment.Text = "Department: HR";
                    lblType.Text = "Employment Type: Full-Time";
                    lblQualifications.Text = "Qualifications: HRM Graduate";
                    lblDocuments.Text = "Required Documents: Resume, Diploma";
                }
                else if (jobID == "J003")
                {
                    lblPosition.Text = "Position: Accountant";
                    lblDepartment.Text = "Department: Finance";
                    lblType.Text = "Employment Type: Full-Time";
                    lblQualifications.Text = "Qualifications: CPA Preferred";
                    lblDocuments.Text = "Required Documents: Resume, PRC License";
                }
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string search = txtSearch.Text?.ToLower() ?? "";

            foreach (DataGridViewRow row in dgvJobs.Rows)
            {
                if (!row.IsNewRow)
                {
                    string position =
                        row.Cells[1].Value?.ToString()?.ToLower() ?? "";

                    row.Visible = position.Contains(search);
                }
            }
        }

        public JobVacancies()
        {
            InitializeComponent();

            searchPanel.BackColor = Color.FromArgb(250, 250, 250);
            headerPanel.BackColor = Color.FromArgb(25, 118, 210);

            btnSearch.BackColor = Color.FromArgb(33, 150, 243);
            btnApply.BackColor = Color.FromArgb(0, 120, 215);
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnExit.BackColor = Color.FromArgb(231, 76, 60);

            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            dgvJobs.AllowUserToResizeColumns = false;
            dgvJobs.AllowUserToResizeRows = false;
            dgvJobs.AllowUserToDeleteRows = false;

            dgvJobs.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvJobs.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgvJobs.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(204, 229, 255);

            dgvJobs.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvJobs.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvJobs.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 102, 204);

            dgvJobs.RowHeadersDefaultCellStyle.SelectionBackColor =
                Color.Blue;

            dgvJobs.RowHeadersDefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvJobs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvJobs.MultiSelect = false;

            btnApply.Click += btnApply_Click;
            dgvJobs.CellClick += dgvJobs_CellClick;
            btnExit.Click += btnExit_Click;
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;

            dgvJobs.Rows.Add("J001", "Software Developer", "IT", "Full-Time", "Open");
            dgvJobs.Rows.Add("J002", "HR Assistant", "HR", "Full-Time", "Open");
            dgvJobs.Rows.Add("J003", "Accountant", "Finance", "Full-Time", "Open");

            dgvJobs.AllowUserToAddRows = false;

            lblJobCount.Text = $"Total Jobs: {dgvJobs.Rows.Count}";

            dgvJobs.ReadOnly = true;
            dgvJobs.BackgroundColor = Color.White;
            dgvJobs.GridColor = Color.LightGray;
        }

        private void btnApply_Click(object? sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow != null)
            {
                string jobID =
                    dgvJobs.CurrentRow.Cells[0].Value?.ToString() ?? "";

                string position =
                    dgvJobs.CurrentRow.Cells[1].Value?.ToString() ?? "";

                MessageBox.Show(
                    "You have successfully applied for:\n\n" +
                    jobID + " - " + position,
                    "Application Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a job first.");
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in dgvJobs.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
