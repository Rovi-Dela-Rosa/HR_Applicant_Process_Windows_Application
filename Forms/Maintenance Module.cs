using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public partial class MaintenanceModule : Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=MysqlEnzo;" +
            "database=hr_recruitment_db;";

        private readonly Dictionary<DataGridView, int> _selectedID = new();
        private bool _suppressRowSelect = false;

        private record TabConfig(
            DataGridView Grid,
            TextBox TextBox,
            string Table,
            string NameCol,
            string IdCol,
            string Query);

        private List<TabConfig> _tabs = new();

        public MaintenanceModule()
        {
            InitializeComponent();

            foreach (Button btn in new[] {
                btnDeptSave, btnDeptDelete,
                btnPosSave,  btnPosDelete,
                btnEmpSave,  btnEmpDelete,
                btnReqSave,  btnReqDelete,
                btnIntSave,  btnIntDelete,
                btnAssSave,  btnAssDelete })
            {
                btn.ForeColor = Color.Azure;
            }

            _tabs = new List<TabConfig>
            {
                new(dgvDepartments,      txtDeptName, "Departments",     "DepartmentName",   "DepartmentID",     "SELECT DepartmentID AS ID, DepartmentName AS Name FROM Departments ORDER BY DepartmentName"),
                new(dgvPositions,        txtPosName,  "Positions",       "PositionName",     "PositionID",       "SELECT PositionID AS ID, PositionName AS Name FROM Positions ORDER BY PositionName"),
                new(dgvEmploymentTypes,  txtEmpName,  "EmploymentTypes", "TypeName",         "EmploymentTypeID", "SELECT EmploymentTypeID AS ID, TypeName AS Name FROM EmploymentTypes ORDER BY TypeName"),
                new(dgvRequirementTypes, txtReqName,  "RequirementTypes","RequirementName",  "RequirementTypeID","SELECT RequirementTypeID AS ID, RequirementName AS Name FROM RequirementTypes ORDER BY RequirementName"),
                new(dgvInterviewTypes,   txtIntName,  "InterviewTypes",  "TypeName",         "InterviewTypeID",  "SELECT InterviewTypeID AS ID, TypeName AS Name FROM InterviewTypes ORDER BY TypeName"),
                new(dgvAssessmentTypes,  txtAssName,  "AssessmentTypes", "AssessmentName",   "AssessmentTypeID", "SELECT AssessmentTypeID AS ID, AssessmentName AS Name FROM AssessmentTypes ORDER BY AssessmentName"),
            };

            foreach (var tab in _tabs)
                _selectedID[tab.Grid] = -1;

            HookEvents();
            tabMaintenance.SelectedIndexChanged += TabMaintenance_SelectedIndexChanged;
            LoadAll();

        }

        private void LoadAll()
        {
            foreach (var tab in _tabs)
                LoadGrid(tab.Grid, tab.Query);
        }

        private void LoadGrid(DataGridView dgv, string query)
        {
            _suppressRowSelect = true;
            _selectedID[dgv] = -1;

            try
            {
                dgv.Rows.Clear();
                dgv.Columns.Clear();

                dgv.Columns.Add("ID", "ID");
                dgv.Columns.Add("Name", "Name");
                dgv.Columns["ID"].Visible = false;
                dgv.Columns["Name"].HeaderText = "Name";
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    dgv.Rows.Add(reader["ID"], reader["Name"]);

                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}");
            }
            finally
            {
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 300;
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    _suppressRowSelect = false;
                    _selectedID[dgv] = -1;
                };
                timer.Start();
            }
        }

        private void HookEvents()
        {
            foreach (var tab in _tabs)
            {
                var t = tab;
                t.Grid.SelectionChanged += (s, e) =>
                {
                    if (_suppressRowSelect) return;
                    if (t.Grid.SelectedRows.Count == 0) return;
                    var row = t.Grid.SelectedRows[0];
                    if (row.Cells["ID"].Value == null) return;

                    _selectedID[t.Grid] = Convert.ToInt32(row.Cells["ID"].Value);
                    t.TextBox.Text = row.Cells["Name"].Value?.ToString();
                };
            }

            btnDeptSave.Click += (s, e) => SaveTab(_tabs[0]);
            btnPosSave.Click += (s, e) => SaveTab(_tabs[1]);
            btnEmpSave.Click += (s, e) => SaveTab(_tabs[2]);
            btnReqSave.Click += (s, e) => SaveTab(_tabs[3]);
            btnIntSave.Click += (s, e) => SaveTab(_tabs[4]);
            btnAssSave.Click += (s, e) => SaveTab(_tabs[5]);

            btnDeptDelete.Click += (s, e) => DeleteTab(_tabs[0]);
            btnPosDelete.Click += (s, e) => DeleteTab(_tabs[1]);
            btnEmpDelete.Click += (s, e) => DeleteTab(_tabs[2]);
            btnReqDelete.Click += (s, e) => DeleteTab(_tabs[3]);
            btnIntDelete.Click += (s, e) => DeleteTab(_tabs[4]);
            btnAssDelete.Click += (s, e) => DeleteTab(_tabs[5]);
        }

        private void SaveTab(TabConfig tab)
        {
            if (string.IsNullOrWhiteSpace(tab.TextBox.Text))
            {
                MessageBox.Show("Please enter a name before saving.");
                return;
            }

            int currentID = _selectedID[tab.Grid];
            bool isUpdate = currentID > 0;

            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                if (isUpdate)
                {
                    try
                    {
                        string query = $"UPDATE `{tab.Table}` SET `{tab.NameCol}` = @Name WHERE `{tab.IdCol}` = @ID";
                        using MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", tab.TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", currentID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated successfully!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Update failed: {ex.Message}\nCode: {ex.Number}");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        string query = $"INSERT INTO `{tab.Table}` (`{tab.NameCol}`) VALUES (@Name)";
                        using MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", tab.TextBox.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added successfully!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Insert failed: {ex.Message}\nCode: {ex.Number}");
                        return;
                    }
                }

                _selectedID[tab.Grid] = -1;
                tab.TextBox.Clear();
                tab.TextBox.Focus();

                LoadGrid(tab.Grid, tab.Query);
                tab.Grid.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
            }
        }

        private void DeleteTab(TabConfig tab)
        {
            int currentID = _selectedID[tab.Grid];

            if (currentID < 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Delete this entry? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = $"DELETE FROM `{tab.Table}` WHERE `{tab.IdCol}` = @ID";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", currentID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted successfully!");

                _selectedID[tab.Grid] = -1;
                tab.TextBox.Clear();
                tab.TextBox.Focus();

                LoadGrid(tab.Grid, tab.Query);
                tab.Grid.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete error: {ex.Message}");
            }
        }

        private void TabMaintenance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMaintenance.SelectedTab == null) return;

            foreach (var tab in _tabs)
            {
                if (tabMaintenance.SelectedTab.Controls.Contains(tab.Grid))
                {
                    _selectedID[tab.Grid] = -1;
                    tab.TextBox.Clear();
                    tab.Grid.ClearSelection();
                }
            }
        }

        private void Back(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HRAdminDashboard loginForm = new HRAdminDashboard();
            loginForm.Show();
            this.Hide();
        }
    }
}
