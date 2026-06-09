using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Job_Vacancy_Management
{
    public partial class Form1 : Form
    {
        private const string ConnStr =
            "server=localhost;" +
            "user=root;" +
            "password=MysqlEnzo;" +
            "database=hr_recruitment_db;";

        private int _selectedVacancyID = -1;

        public Form1()
        {
            InitializeComponent();

            SetupComboBoxDrawing();

            btnSave.ForeColor = Color.Azure;
            btnEdit.ForeColor = Color.Azure;
            btnClose.ForeColor = Color.Azure;
            btnReopen.ForeColor = Color.Azure;
            btnCancelEdit.ForeColor = Color.Azure;

            dgvVacancies.EnableHeadersVisualStyles = false;
            dgvVacancies.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvVacancies.ColumnHeadersDefaultCellStyle.ForeColor = Color.Azure;
            dgvVacancies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvVacancies.DefaultCellStyle.BackColor = Color.Azure;
            dgvVacancies.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvVacancies.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvVacancies.DefaultCellStyle.SelectionForeColor = Color.Azure;
            dgvVacancies.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 235, 245);
            dgvVacancies.AlternatingRowsDefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvVacancies.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvVacancies.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Azure;
            dgvVacancies.GridColor = Color.SteelBlue;

            LoadPositions();
            LoadDepartments();
            LoadEmploymentTypes();
            LoadRequirementTypes();
            LoadVacancies();

            HookEvents();

            btnSave.Enabled = false;
            ValidateInputs();
        }

        private void SetupComboBoxDrawing()
        {
            foreach (ComboBox cmb in new[] { cmbPosition, cmbDepartment, cmbEmploymentType, cmbStatus })
            {
                cmb.DrawMode = DrawMode.OwnerDrawFixed;
                cmb.DrawItem += ComboBox_DrawItem;
            }
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox cmb = (ComboBox)sender;
            string text = cmb.GetItemText(cmb.Items[e.Index]);

            e.DrawBackground();

            bool isPlaceholder = text.StartsWith("-- Select");
            Color textColor = isPlaceholder ? Color.Gray : e.ForeColor;

            using SolidBrush brush = new SolidBrush(textColor);
            e.Graphics.DrawString(text, e.Font, brush, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void LoadPositions()
        {
            using MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();

            string query = "SELECT PositionID, PositionName FROM Positions ORDER BY PositionName";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow row = dt.NewRow();
            row["PositionID"] = 0;
            row["PositionName"] = "-- Select Position --";
            dt.Rows.InsertAt(row, 0);

            cmbPosition.DataSource = dt;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "PositionID";
            cmbPosition.SelectedIndex = 0;
        }

        private void LoadDepartments()
        {
            using MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();

            string query = "SELECT DepartmentID, DepartmentName FROM Departments ORDER BY DepartmentName";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow row = dt.NewRow();
            row["DepartmentID"] = 0;
            row["DepartmentName"] = "-- Select Department --";
            dt.Rows.InsertAt(row, 0);

            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.SelectedIndex = 0;
        }

        private void LoadEmploymentTypes()
        {
            using MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();

            string query = "SELECT EmploymentTypeID, TypeName FROM EmploymentTypes ORDER BY TypeName";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow row = dt.NewRow();
            row["EmploymentTypeID"] = 0;
            row["TypeName"] = "-- Select Employment Type --";
            dt.Rows.InsertAt(row, 0);

            cmbEmploymentType.DataSource = dt;
            cmbEmploymentType.DisplayMember = "TypeName";
            cmbEmploymentType.ValueMember = "EmploymentTypeID";
            cmbEmploymentType.SelectedIndex = 0;
        }

        private void LoadRequirementTypes()
        {
            using MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();

            string query = "SELECT RequirementTypeID, RequirementName FROM RequirementTypes ORDER BY RequirementName";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            clbRequiredDocs.Items.Clear();

            while (reader.Read())
            {
                clbRequiredDocs.Items.Add(new RequirementItem
                {
                    ID = reader.GetInt32("RequirementTypeID"),
                    Name = reader.GetString("RequirementName")
                });
            }
        }

        private void LoadVacancies()
        {
            using MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();

            string query = @"
                SELECT
                    jv.VacancyID,
                    COALESCE(p.PositionName,  '-')   AS Position,
                    COALESCE(d.DepartmentName, '-')  AS Department,
                    COALESCE(et.TypeName, '-')        AS EmploymentType,
                    jv.JobStatus                      AS Status,
                    COALESCE(jv.Qualifications, '-')  AS Qualifications
                FROM JobVacancies jv
                LEFT JOIN Positions      p  ON jv.PositionID       = p.PositionID
                LEFT JOIN Departments    d  ON jv.DepartmentID     = d.DepartmentID
                LEFT JOIN EmploymentTypes et ON jv.EmploymentTypeID = et.EmploymentTypeID
                ORDER BY jv.VacancyID DESC";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvVacancies.DataSource = dt;

            dgvVacancies.Columns["VacancyID"].Visible = false;

            dgvVacancies.Columns["Position"].HeaderText = "Position";
            dgvVacancies.Columns["Department"].HeaderText = "Department";
            dgvVacancies.Columns["EmploymentType"].HeaderText = "Employment Type";
            dgvVacancies.Columns["Status"].HeaderText = "Status";
            dgvVacancies.Columns["Qualifications"].HeaderText = "Qualifications";

            dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancies.ReadOnly = true;
            dgvVacancies.AllowUserToAddRows = false;

            dgvVacancies.RowPrePaint -= DgvVacancies_RowPrePaint;
            dgvVacancies.RowPrePaint += DgvVacancies_RowPrePaint;
        }

        private void DgvVacancies_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvVacancies.Rows.Count) return;
            var cell = dgvVacancies.Rows[e.RowIndex].Cells["Status"];
            if (cell?.Value == null) return;

            dgvVacancies.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                cell.Value.ToString() switch
                {
                    "Open" => Color.FromArgb(220, 255, 220),
                    "Closed" => Color.FromArgb(255, 220, 220),
                    _ => Color.Azure
                };
        }

        private void ValidateInputs()
        {
            bool valid =
                cmbPosition.SelectedIndex > 0 &&
                cmbDepartment.SelectedIndex > 0 &&
                cmbEmploymentType.SelectedIndex > 0 &&
                cmbStatus.SelectedIndex > -1 &&
                !cmbStatus.Text.StartsWith("-- Select");

            btnSave.Enabled = valid;
        }

        private void HookEvents()
        {
            cmbPosition.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbDepartment.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbEmploymentType.SelectionChangeCommitted += (s, e) => ValidateInputs();
            cmbStatus.SelectionChangeCommitted += (s, e) => ValidateInputs();

            dgvVacancies.SelectionChanged += DgvVacancies_SelectionChanged;

            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnClose.Click += btnClose_Click;
            btnReopen.Click += btnReopen_Click;
            btnCancelEdit.Click += (s, e) => CancelEdit();
        }

        private void DgvVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvVacancies.SelectedRows[0];
            _selectedVacancyID = Convert.ToInt32(row.Cells["VacancyID"].Value);

            string position = row.Cells["Position"].Value?.ToString() ?? "-";
            string status = row.Cells["Status"].Value?.ToString() ?? "-";

            lblEditingLabel.Text = $"Selected:  {position}  —  {status}";

            btnClose.Visible = status == "Open";
            btnReopen.Visible = status == "Closed";

            pnlActions.Visible = true;
        }

        private void CancelEdit()
        {
            _selectedVacancyID = -1;
            pnlActions.Visible = false;
            lblEditingLabel.Text = "Selected: —";

            txtQualifications.Clear();
            cmbPosition.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            cmbEmploymentType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = -1;

            for (int i = 0; i < clbRequiredDocs.Items.Count; i++)
                clbRequiredDocs.SetItemChecked(i, false);

            btnSave.Text = "Save Vacancy";
            dgvVacancies.ClearSelection();
            ValidateInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                if (_selectedVacancyID > 0)
                {
                    string query = @"
                        UPDATE JobVacancies SET
                            PositionID       = @PositionID,
                            DepartmentID     = @DepartmentID,
                            EmploymentTypeID = @EmploymentTypeID,
                            JobStatus        = @JobStatus,
                            Qualifications   = @Qualifications
                        WHERE VacancyID = @VacancyID";

                    using MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PositionID", cmbPosition.SelectedValue);
                    cmd.Parameters.AddWithValue("@DepartmentID", cmbDepartment.SelectedValue);
                    cmd.Parameters.AddWithValue("@EmploymentTypeID", cmbEmploymentType.SelectedValue);
                    cmd.Parameters.AddWithValue("@JobStatus", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Qualifications", txtQualifications.Text.Trim());
                    cmd.Parameters.AddWithValue("@VacancyID", _selectedVacancyID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Vacancy updated successfully!");
                }
                else
                {
                    string query = @"
                        INSERT INTO JobVacancies
                            (PositionID, DepartmentID, EmploymentTypeID, JobStatus, Qualifications)
                        VALUES
                            (@PositionID, @DepartmentID, @EmploymentTypeID, @JobStatus, @Qualifications)";

                    using MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PositionID", cmbPosition.SelectedValue);
                    cmd.Parameters.AddWithValue("@DepartmentID", cmbDepartment.SelectedValue);
                    cmd.Parameters.AddWithValue("@EmploymentTypeID", cmbEmploymentType.SelectedValue);
                    cmd.Parameters.AddWithValue("@JobStatus", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Qualifications", txtQualifications.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Vacancy added successfully!");
                }

                CancelEdit();
                LoadVacancies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedVacancyID < 0) return;

            DataGridViewRow row = dgvVacancies.SelectedRows[0];

            string position = row.Cells["Position"].Value?.ToString();
            foreach (DataRowView item in cmbPosition.Items)
            {
                if (item["PositionName"].ToString() == position)
                {
                    cmbPosition.SelectedItem = item;
                    break;
                }
            }

            string dept = row.Cells["Department"].Value?.ToString();
            foreach (DataRowView item in cmbDepartment.Items)
            {
                if (item["DepartmentName"].ToString() == dept)
                {
                    cmbDepartment.SelectedItem = item;
                    break;
                }
            }

            string empType = row.Cells["EmploymentType"].Value?.ToString();
            foreach (DataRowView item in cmbEmploymentType.Items)
            {
                if (item["TypeName"].ToString() == empType)
                {
                    cmbEmploymentType.SelectedItem = item;
                    break;
                }
            }

            string status = row.Cells["Status"].Value?.ToString();
            for (int i = 0; i < cmbStatus.Items.Count; i++)
            {
                if (cmbStatus.Items[i].ToString() == status)
                {
                    cmbStatus.SelectedIndex = i;
                    break;
                }
            }

            txtQualifications.Text = row.Cells["Qualifications"].Value?.ToString();

            btnSave.Text = "Update Vacancy";
            ValidateInputs();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_selectedVacancyID < 0) return;

            var confirm = MessageBox.Show(
                "Close this vacancy? It will no longer accept new applications.",
                "Confirm Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = "UPDATE JobVacancies SET JobStatus = 'Closed' WHERE VacancyID = @VacancyID";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VacancyID", _selectedVacancyID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Vacancy closed successfully!");
                CancelEdit();
                LoadVacancies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            if (_selectedVacancyID < 0) return;

            var confirm = MessageBox.Show(
                "Reopen this vacancy? It will accept new applications again.",
                "Confirm Reopen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using MySqlConnection conn = new MySqlConnection(ConnStr);
                conn.Open();

                string query = "UPDATE JobVacancies SET JobStatus = 'Open' WHERE VacancyID = @VacancyID";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VacancyID", _selectedVacancyID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Vacancy reopened successfully!");
                CancelEdit();
                LoadVacancies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class RequirementItem
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public override string ToString() => Name;
    }
}
