using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class Screening2 : Form
    {
        private string connectionString =
            "server=localhost;port=3306;database=hr_recruitment_db;uid=root;pwd=ivor_blunt00;";

        public Screening2()
        {
            InitializeComponent();

            // Load applicants immediately
            LoadApplicants();

            // Status choices
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Qualified / Shortlisted");
            cboStatus.Items.Add("Not Qualified / Rejected");
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // ================= LOAD APPLICANTS =================
        private void LoadApplicants()
        {
            try
            {
                cmbApplicant2.Items.Clear();

                using (MySqlConnection conn =
                    new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "SELECT Username FROM ApplicantAccounts ORDER BY Username";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbApplicant2.Items.Add(
                            reader["Username"].ToString());
                    }

                    reader.Close();
                }

                if (cmbApplicant2.Items.Count > 0)
                {
                    cmbApplicant2.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(
                        "No applicant usernames found in ApplicantAccounts.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error:\n\n" + ex.Message);
            }
        }

        // ================= SUBMIT SCREENING =================
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbApplicant2.SelectedIndex == -1)
                {
                    MessageBox.Show("Select an applicant.");
                    return;
                }

                if (cboStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Select screening result.");
                    return;
                }

                string username =
                    cmbApplicant2.SelectedItem.ToString();

                string result =
                    cboStatus.SelectedItem.ToString();

                using (MySqlConnection conn =
                    new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Find AccountID from username
                    string getIDQuery =
                        @"
                        SELECT a.ApplicationID
                        FROM Applications a
                        INNER JOIN Applicants ap
                        ON a.ApplicantID = ap.ApplicantID
                        INNER JOIN ApplicantAccounts aa
                        ON ap.AccountID = aa.AccountID
                        WHERE aa.Username=@username
                        ORDER BY a.AppliedDate DESC
                        LIMIT 1";

                    MySqlCommand getCmd =
                        new MySqlCommand(getIDQuery, conn);

                    getCmd.Parameters.AddWithValue(
                        "@username",
                        username);

                    object accountID =
                        getCmd.ExecuteScalar();

                    if (accountID == null)
                    {
                        MessageBox.Show("Applicant not found.");
                        return;
                    }

                    // Only qualified applicants proceed
                    if (result == "Qualified / Shortlisted")
                    {
                        string insertQuery =
                            @"INSERT INTO ScreeningResults
                            (ApplicationID, Result, Remarks)
                            VALUES
                            (@id,@result,@remarks)";

                        MySqlCommand insertCmd =
                            new MySqlCommand(insertQuery, conn);

                        insertCmd.Parameters.AddWithValue(
                            "@id",
                            accountID);

                        insertCmd.Parameters.AddWithValue(
                            "@result",
                            "Qualified / Shortlisted");

                        insertCmd.Parameters.AddWithValue(
                            "@remarks",
                            txtRemarks.Text);

                        insertCmd.ExecuteNonQuery();

                        string updateQuery = @"
                        UPDATE Applications
                        SET CurrentStatus='Shortlisted'
                        WHERE ApplicationID=@ApplicationID";

                        string historyQuery = @"
                        INSERT INTO ApplicationStatusHistory
                        (ApplicationID, Status, Remarks)
                        VALUES
                        (@ApplicationID,
                        'Shortlisted',
                        'Applicant passed initial screening.')";


                        using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                        {
                            historyCmd.Parameters.AddWithValue(
                                "@ApplicationID",
                                accountID);

                            historyCmd.ExecuteNonQuery();
                        }


                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue(
                                "@ApplicationID",
                                accountID);

                            updateCmd.ExecuteNonQuery();

                            AuditTrailManager.LogAction("HR Staff", Convert.ToInt32(accountID), "Applicant passed screening and was shortlisted");
                        }

                        MessageBox.Show(
                            "Screening finalized.\nApplicant may proceed to Interview Schedule and Evaluation.");
                    }
                    else
                    {
                        string rejectQuery = @"
                        UPDATE Applications
                        SET CurrentStatus='Rejected'
                        WHERE ApplicationID=@ApplicationID";


                        using (MySqlCommand rejectCmd =
                        new MySqlCommand(rejectQuery, conn))
                        {
                            rejectCmd.Parameters.AddWithValue(
                                "@ApplicationID",
                                accountID);

                            rejectCmd.ExecuteNonQuery();

                            AuditTrailManager.LogAction("HR Staff", Convert.ToInt32(accountID), "Applicant rejected during screening");
                        }


                        string historyQuery = @"
                        INSERT INTO ApplicationStatusHistory
                        (ApplicationID, Status, Remarks)
                        VALUES
                        (@ApplicationID,
                        'Rejected',
                        'Applicant did not pass initial screening.')";


                        using (MySqlCommand historyCmd =
                        new MySqlCommand(historyQuery, conn))
                        {
                            historyCmd.Parameters.AddWithValue(
                                "@ApplicationID",
                                accountID);

                            historyCmd.ExecuteNonQuery();
                        }
                    }
                }

                txtRemarks.Clear();
                cboStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message);
            }
        }

        private void Screening2_Load(object sender, EventArgs e)
        {

        }

        private void Back(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hrstaff loginForm = new Hrstaff();
            loginForm.Show();
            this.Hide();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}