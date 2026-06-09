using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class MyApplicationPage : Form
    {
        private int currentApplicantID;
        private bool isSubmitted = true;
        private bool isUnderHRReview = false;

        public MyApplicationPage(int dynamicID)
        {
            InitializeComponent();
            this.currentApplicantID = dynamicID;
            LoadMockApplicantData();
        }

        private void LoadMockApplicantData()
        {
            lblJobTitle.Text = "Junior Programmer (IT Department)";

            lblStatus.Text = "Submitted / Pending HR Review";
            lblStatus.ForeColor = Color.Navy;

            txtApplicantName.Text = "Miguela Vistar";
            lblResumePath.Text = "Miguela_Vistar_Resume_2026.pdf";
            lblTranscriptPath.Text = "Miguela_Vistar_TOR_Official.pdf";

            ToggleFormControls(false);

            MessageBox.Show("Welcome back, Miguela!\n\nDisplaying your submitted portfolio record for the 'Junior Programmer' position.",
                            "Application File Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            if (isSubmitted)
            {
                MessageBox.Show("Cannot save as draft. This application package has already been locked and submitted to HR. Click 'Edit Application' to revert it first.",
                                "System Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblStatus.Text = "Draft";
            lblStatus.ForeColor = Color.DarkOrange;
            MessageBox.Show("Your changes have been securely saved as a local Draft!", "Draft State Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApplicantName.Text))
            {
                MessageBox.Show("Please enter your full name before processing the submission pipeline.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isSubmitted = true;
            lblStatus.Text = "Submitted / Pending HR Review";
            lblStatus.ForeColor = Color.Navy; 

            ToggleFormControls(false);

            MessageBox.Show("Your updated application package has been successfully transmitted to corporate recruitment arrays!", "Submission Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isUnderHRReview)
            {
                MessageBox.Show("Access Denied: HR corporate review has already started. Profile properties are now locked.", "System Evaluation Lock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (isSubmitted)
            {
                DialogResult systemDialog = MessageBox.Show("Would you like to withdraw your current submission to modify your documents and profile details?", "Unlock Application Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (systemDialog == DialogResult.Yes)
                {
                    isSubmitted = false;
                    lblStatus.Text = "Draft";
                    lblStatus.ForeColor = Color.DarkOrange;

                    ToggleFormControls(true);
                    MessageBox.Show("Form unlocked! You may now revise your full name or upload alternative documents.", "Edit Mode Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The form structure is already unlocked and ready for live inputs.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToggleFormControls(bool state)
        {
            txtApplicantName.Enabled = state;
            btnBrowseResume.Enabled = state;
            btnBrowseTranscript.Enabled = state;
            btnSaveDraft.Enabled = state;
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
    }
}