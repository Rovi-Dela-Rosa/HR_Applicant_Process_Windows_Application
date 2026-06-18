using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class MyApplicationPage : Form
    {
        private int currentApplicantID;
        private string currentStatus = "";

        public MyApplicationPage(int dynamicID)
        {
            InitializeComponent();
            this.currentApplicantID = dynamicID;

            this.Resize += MyApplicationPage_Resize;

        }

        private void MyApplicationPage_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int uiWidth = 953;
            int uiHeight = 733;

            int offsetX = (formWidth - uiWidth) / 2;
            int offsetY = (formHeight - uiHeight) / 2;

            lblTiltle.Left = (panelHeader.Width - lblTiltle.Width) / 2;
            lblTiltle.Top = (panelHeader.Height - lblTiltle.Height) / 2;

            groupBox1.Left = offsetX + 29;
            groupBox1.Top = offsetY + 27;

            groupBox2.Left = offsetX + 29;
            groupBox2.Top = offsetY + 240;

            btnSubmit.Left = offsetX + 348;
            btnSubmit.Top = offsetY + 595;

            btnSaveDraft.Left = offsetX + 390;
            btnSaveDraft.Top = offsetY + 654;

            btnEdit.Left = offsetX + 524;
            btnEdit.Top = offsetY + 653;

            btnWithdraw.Left = offsetX + 215;
            btnWithdraw.Top = offsetY + 653;

            btnBack.Left = 20;
            btnBack.Top = (panelHeader.Height - btnBack.Height) / 2;
        }


        private void LoadApplicationData()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
            SELECT 
                a.ApplicationID,
                a.CurrentStatus,
                CONCAT(ap.FirstName, ' ', ap.LastName) AS ApplicantName,
                p.PositionName,
                d.DepartmentName
            FROM Applications a
            INNER JOIN Applicants ap ON a.ApplicantID = ap.ApplicantID
            INNER JOIN JobVacancies jv ON a.VacancyID = jv.VacancyID
            INNER JOIN Positions p ON jv.PositionID = p.PositionID
            INNER JOIN Departments d ON jv.DepartmentID = d.DepartmentID
            WHERE a.ApplicantID = @ApplicantID
            ORDER BY a.AppliedDate DESC
            LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblJobTitle.Text =
                                    reader["PositionName"].ToString() +
                                    " (" +
                                    reader["DepartmentName"].ToString() +
                                    ")";

                                lblStatus.Text =
                                    reader["CurrentStatus"].ToString();

                                currentStatus = reader["CurrentStatus"].ToString();

                                txtApplicantName.Text =
                                    reader["ApplicantName"].ToString();

                                lblStatus.ForeColor = Color.Navy;

                                if (currentStatus == "Draft" || currentStatus == "Submitted")
                                {
                                    ToggleFormControls(true);
                                }
                                else
                                {
                                    ToggleFormControls(false);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No submitted applications found.",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AddStatusHistory(int applicationID, string status, string remarks)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                                INSERT INTO ApplicationStatusHistory
                                (ApplicationID, Status, Remarks)
                                VALUES
                                (@ApplicationID,@Status,@Remarks)";

                MySqlCommand cmd =
                new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Remarks", remarks);

                cmd.ExecuteNonQuery();
            }
        }

        private bool IsApplicationLocked()
        {
            string[] lockedStatuses =
            {
                "Under Review",
                "Shortlisted",
                "For Interview",
                "For Assessment",
                "For Final Review",
                "Accepted",
                "Rejected",
                "Withdrawn",
            };

            return Array.Exists(
                lockedStatuses,
                status => status.Equals(currentStatus,
                StringComparison.OrdinalIgnoreCase));
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            if (IsApplicationLocked())
            {
                MessageBox.Show(
                    "Cannot save as draft. This application is already locked or under HR review.",
                    "System Restriction",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                                   UPDATE Applications
                                   SET CurrentStatus = @Status
                                   WHERE ApplicantID = @ApplicantID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", "Draft");
                        cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);

                        cmd.ExecuteNonQuery();
                    }
                }

                lblStatus.Text = "Draft";
                lblStatus.ForeColor = Color.DarkOrange;

                MessageBox.Show(
                    "Draft saved successfully!",
                    "Draft Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentStatus != "Draft")
            {
                MessageBox.Show(
                    "This application cannot be submitted because it is already processed by HR.",
                    "Submission Restricted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;

            }
            if (string.IsNullOrWhiteSpace(txtApplicantName.Text))
            {
                MessageBox.Show(
                    "Please enter your full name before processing the submission pipeline.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    UPDATE Applications
                    SET CurrentStatus = @Status
                    WHERE ApplicantID = @ApplicantID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Status",
                            "Submitted"
                        );

                        cmd.Parameters.AddWithValue(
                            "@ApplicantID",
                            currentApplicantID
                        );

                        cmd.ExecuteNonQuery();

                        AuditTrailManager.LogAction("Applicant", currentApplicantID,"Submitted application for HR review");

                        int applicationID = 0;

                        string getIDQuery = @"
                                            SELECT ApplicationID
                                            FROM Applications
                                            WHERE ApplicantID=@ApplicantID
                                            ORDER BY AppliedDate DESC
                                            LIMIT 1";

                        using (MySqlCommand idCmd = new MySqlCommand(getIDQuery, conn))
                        {
                            idCmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);

                            applicationID = Convert.ToInt32(idCmd.ExecuteScalar());
                        }


                        // Insert status history
                        string historyQuery = @"
                                                INSERT INTO ApplicationStatusHistory
                                                (ApplicationID, Status, Remarks)
                                                VALUES
                                                (@ApplicationID, 'Submitted',
                                                'Application submitted and waiting for HR review.')";


                        using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                        {
                            historyCmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                            historyCmd.ExecuteNonQuery();
                        }
                    }

                    currentStatus = "Submitted";


                    lblStatus.Text = "Submitted / Pending HR Review";

                    lblStatus.ForeColor = Color.Navy;

                    if (IsApplicationLocked())
                    {
                        ToggleFormControls(false);
                    }
                    else
                    {
                        ToggleFormControls(true);
                    }

                    MessageBox.Show(
                        "Application submitted successfully!",
                        "Submission Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsApplicationLocked())
            {
                MessageBox.Show(
                    "This application is currently locked because HR has already started reviewing it.",
                    "Application Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            ToggleFormControls(true);

            MessageBox.Show(
                "Application unlocked. You may edit your details.",
                "Edit Mode",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ToggleFormControls(bool state)
        {
            txtApplicantName.Enabled = state;
            btnBrowseResume.Enabled = state;
            btnBrowseTranscript.Enabled = state;
            btnSaveDraft.Enabled = state;
            btnSubmit.Enabled = state;
        }


        private void btnBrowseResume_Click(object sender, EventArgs e)
        {
            string file = OpenFileExplorer();
            if (!string.IsNullOrEmpty(file))
            {
                lblResumePath.Text = Path.GetFileName(file);
            }
        }

        private void btnBrowseTranscript_Click(object sender, EventArgs e)
        {
            string file = OpenFileExplorer();
            if (!string.IsNullOrEmpty(file))
            {
                lblTranscriptPath.Text = Path.GetFileName(file);
            }
        }


        private string OpenFileExplorer()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Documents (*.pdf;*.docx)|*.pdf;*.docx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
            }
            return string.Empty;
        }

        private void panelWorkspace_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(currentApplicantID);
            dashboard.Show();
            this.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (IsApplicationLocked())
            {
                MessageBox.Show(
                "This application can no longer be withdrawn.",
                "Withdrawal Not Allowed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }


            DialogResult result = MessageBox.Show(
                "Are you sure you want to withdraw your application?",
                "Confirm Withdrawal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
            UPDATE Applications
            SET CurrentStatus='Withdrawn'
            WHERE ApplicantID=@ApplicantID";

                    MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@ApplicantID",
                        currentApplicantID);

                    cmd.ExecuteNonQuery();

                    AuditTrailManager.LogAction("Applicant", currentApplicantID, "Withdrawn application");

                    string historyQuery = @"
                                            INSERT INTO ApplicationStatusHistory
                                            (ApplicationID, Status, Remarks)
                                            SELECT ApplicationID,
                                            'Withdrawn',
                                            'Applicant withdrew the application.'
                                            FROM Applications
                                            WHERE ApplicantID=@ApplicantID
                                            ORDER BY AppliedDate DESC
                                            LIMIT 1";


                    using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                    {
                        historyCmd.Parameters.AddWithValue("@ApplicantID", currentApplicantID);

                        historyCmd.ExecuteNonQuery();
                    }
                }


                MessageBox.Show(
                "Application withdrawn successfully.");

                LoadApplicationData();
            }
        }
    }
}