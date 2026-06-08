namespace Maintenance_Module
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            tabMaintenance = new TabControl();
            tabDepartments = new TabPage();
            tabPositions = new TabPage();
            tabEmploymentTypes = new TabPage();
            tabRequirementTypes = new TabPage();
            tabInterviewTypes = new TabPage();
            tabAssessmentTypes = new TabPage();
            pnlDept = new Panel();
            txtDeptName = new TextBox();
            lblDeptName = new Label();
            btnDeptSave = new Button();
            btnDeptDelete = new Button();
            dgvDepartments = new DataGridView();
            pnlPos = new Panel();
            txtPosName = new TextBox();
            lblPosName = new Label();
            btnPosSave = new Button();
            btnPosDelete = new Button();
            dgvPositions = new DataGridView();
            pnlEmp = new Panel();
            txtEmpName = new TextBox();
            lblEmpName = new Label();
            btnEmpSave = new Button();
            btnEmpDelete = new Button();
            dgvEmploymentTypes = new DataGridView();
            pnlReq = new Panel();
            txtReqName = new TextBox();
            lblReqName = new Label();
            btnReqSave = new Button();
            btnReqDelete = new Button();
            dgvRequirementTypes = new DataGridView();
            pnlInt = new Panel();
            txtIntName = new TextBox();
            lblIntName = new Label();
            btnIntSave = new Button();
            btnIntDelete = new Button();
            dgvInterviewTypes = new DataGridView();
            pnlAss = new Panel();
            txtAssName = new TextBox();
            lblAssName = new Label();
            btnAssSave = new Button();
            btnAssDelete = new Button();
            dgvAssessmentTypes = new DataGridView();
            tabMaintenance.SuspendLayout();
            tabDepartments.SuspendLayout();
            tabPositions.SuspendLayout();
            tabEmploymentTypes.SuspendLayout();
            tabRequirementTypes.SuspendLayout();
            tabInterviewTypes.SuspendLayout();
            tabAssessmentTypes.SuspendLayout();
            pnlDept.SuspendLayout();
            pnlPos.SuspendLayout();
            pnlEmp.SuspendLayout();
            pnlReq.SuspendLayout();
            pnlInt.SuspendLayout();
            pnlAss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmploymentTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequirementTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInterviewTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssessmentTypes).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(370, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Maintenance Module";

            // 
            // tabMaintenance
            // 
            tabMaintenance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            tabMaintenance.Controls.Add(tabDepartments);
            tabMaintenance.Controls.Add(tabPositions);
            tabMaintenance.Controls.Add(tabEmploymentTypes);
            tabMaintenance.Controls.Add(tabRequirementTypes);
            tabMaintenance.Controls.Add(tabInterviewTypes);
            tabMaintenance.Controls.Add(tabAssessmentTypes);
            tabMaintenance.Location = new Point(27, 58);
            tabMaintenance.Name = "tabMaintenance";
            tabMaintenance.SelectedIndex = 0;
            tabMaintenance.Size = new Size(970, 530);
            tabMaintenance.TabIndex = 1;

            //
            // tabDepartments
            //
            tabDepartments.BackColor = Color.Azure;
            tabDepartments.Controls.Add(pnlDept);
            tabDepartments.Controls.Add(dgvDepartments);
            tabDepartments.Location = new Point(4, 29);
            tabDepartments.Name = "tabDepartments";
            tabDepartments.Size = new Size(962, 497);
            tabDepartments.TabIndex = 0;
            tabDepartments.Text = "Departments";

            //
            // pnlDept
            //
            pnlDept.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDept.BackColor = Color.SteelBlue;
            pnlDept.BorderStyle = BorderStyle.FixedSingle;
            pnlDept.Controls.Add(lblDeptName);
            pnlDept.Controls.Add(txtDeptName);
            pnlDept.Controls.Add(btnDeptSave);
            pnlDept.Controls.Add(btnDeptDelete);
            pnlDept.Location = new Point(10, 10);
            pnlDept.Name = "pnlDept";
            pnlDept.Size = new Size(942, 70);
            pnlDept.TabIndex = 0;

            //
            // lblDeptName
            //
            lblDeptName.AutoSize = true;
            lblDeptName.Font = new Font("Segoe UI", 10.2F);
            lblDeptName.ForeColor = Color.Azure;
            lblDeptName.Location = new Point(10, 10);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Text = "Department Name";

            //
            // txtDeptName
            //
            txtDeptName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDeptName.BackColor = Color.Azure;
            txtDeptName.BorderStyle = BorderStyle.FixedSingle;
            txtDeptName.ForeColor = Color.MidnightBlue;
            txtDeptName.Location = new Point(10, 36);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(680, 27);
            txtDeptName.TabIndex = 0;

            //
            // btnDeptSave
            //
            btnDeptSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeptSave.BackColor = Color.MidnightBlue;
            btnDeptSave.FlatAppearance.BorderSize = 0;
            btnDeptSave.FlatStyle = FlatStyle.Flat;
            btnDeptSave.ForeColor = Color.Azure;
            btnDeptSave.Location = new Point(706, 33);
            btnDeptSave.Name = "btnDeptSave";
            btnDeptSave.Size = new Size(110, 30);
            btnDeptSave.TabIndex = 1;
            btnDeptSave.Text = "Save";
            btnDeptSave.UseVisualStyleBackColor = false;

            //
            // btnDeptDelete
            //
            btnDeptDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeptDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnDeptDelete.FlatAppearance.BorderSize = 0;
            btnDeptDelete.FlatStyle = FlatStyle.Flat;
            btnDeptDelete.ForeColor = Color.Azure;
            btnDeptDelete.Location = new Point(824, 33);
            btnDeptDelete.Name = "btnDeptDelete";
            btnDeptDelete.Size = new Size(110, 30);
            btnDeptDelete.TabIndex = 2;
            btnDeptDelete.Text = "Delete";
            btnDeptDelete.UseVisualStyleBackColor = false;

            //
            // dgvDeparments
            //
            SetGridStyle(dgvDepartments);
            dgvDepartments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvDepartments.Location = new Point(10, 90);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.Size = new Size(942, 397);
            dgvDepartments.TabIndex = 1;

            //
            // tabPositions
            //
            tabPositions.BackColor = Color.Azure;
            tabPositions.Controls.Add(pnlPos);
            tabPositions.Controls.Add(dgvPositions);
            tabPositions.Location = new Point(4, 29);
            tabPositions.Name = "tabPositions";
            tabPositions.Size = new Size(962, 497);
            tabPositions.TabIndex = 1;
            tabPositions.Text = "Positions";

            //
            // pnlPos
            //
            pnlPos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPos.BackColor = Color.SteelBlue;
            pnlPos.BorderStyle = BorderStyle.FixedSingle;
            pnlPos.Controls.Add(lblPosName);
            pnlPos.Controls.Add(txtPosName);
            pnlPos.Controls.Add(btnPosSave);
            pnlPos.Controls.Add(btnPosDelete);
            pnlPos.Location = new Point(10, 10);
            pnlPos.Name = "pnlPos";
            pnlPos.Size = new Size(942, 70);
            pnlPos.TabIndex = 0;

            //
            // lblPostName
            //
            lblPosName.AutoSize = true;
            lblPosName.Font = new Font("Segoe UI", 10.2F);
            lblPosName.ForeColor = Color.Azure;
            lblPosName.Location = new Point(10, 10);
            lblPosName.Name = "lblPosName";
            lblPosName.Text = "Position Name";

            //
            // txtPosName
            //
            txtPosName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPosName.BackColor = Color.Azure;
            txtPosName.BorderStyle = BorderStyle.FixedSingle;
            txtPosName.ForeColor = Color.MidnightBlue;
            txtPosName.Location = new Point(10, 36);
            txtPosName.Name = "txtPosName";
            txtPosName.Size = new Size(680, 27);
            txtPosName.TabIndex = 0;

            //
            // btnPosSave
            //
            btnPosSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPosSave.BackColor = Color.MidnightBlue;
            btnPosSave.FlatAppearance.BorderSize = 0;
            btnPosSave.FlatStyle = FlatStyle.Flat;
            btnPosSave.ForeColor = Color.Azure;
            btnPosSave.Location = new Point(706, 33);
            btnPosSave.Name = "btnPosSave";
            btnPosSave.Size = new Size(110, 30);
            btnPosSave.TabIndex = 1;
            btnPosSave.Text = "Save";
            btnPosSave.UseVisualStyleBackColor = false;

            //
            // btnPosDelete
            //
            btnPosDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPosDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnPosDelete.FlatAppearance.BorderSize = 0;
            btnPosDelete.FlatStyle = FlatStyle.Flat;
            btnPosDelete.ForeColor = Color.Azure;
            btnPosDelete.Location = new Point(824, 33);
            btnPosDelete.Name = "btnPosDelete";
            btnPosDelete.Size = new Size(110, 30);
            btnPosDelete.TabIndex = 2;
            btnPosDelete.Text = "Delete";
            btnPosDelete.UseVisualStyleBackColor = false;

            //
            // dgvPositions
            //
            SetGridStyle(dgvPositions);
            dgvPositions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvPositions.Location = new Point(10, 90);
            dgvPositions.Name = "dgvPositions";
            dgvPositions.Size = new Size(942, 397);
            dgvPositions.TabIndex = 1;

            //
            // tabEmploymentTypes
            //
            tabEmploymentTypes.BackColor = Color.Azure;
            tabEmploymentTypes.Controls.Add(pnlEmp);
            tabEmploymentTypes.Controls.Add(dgvEmploymentTypes);
            tabEmploymentTypes.Location = new Point(4, 29);
            tabEmploymentTypes.Name = "tabEmploymentTypes";
            tabEmploymentTypes.Size = new Size(962, 497);
            tabEmploymentTypes.TabIndex = 2;
            tabEmploymentTypes.Text = "Employment Types";

            //
            // pnlEmp
            //
            pnlEmp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlEmp.BackColor = Color.SteelBlue;
            pnlEmp.BorderStyle = BorderStyle.FixedSingle;
            pnlEmp.Controls.Add(lblEmpName);
            pnlEmp.Controls.Add(txtEmpName);
            pnlEmp.Controls.Add(btnEmpSave);
            pnlEmp.Controls.Add(btnEmpDelete);
            pnlEmp.Location = new Point(10, 10);
            pnlEmp.Name = "pnlEmp";
            pnlEmp.Size = new Size(942, 70);
            pnlEmp.TabIndex = 0;

            //
            // lblEmpName
            //
            lblEmpName.AutoSize = true;
            lblEmpName.Font = new Font("Segoe UI", 10.2F);
            lblEmpName.ForeColor = Color.Azure;
            lblEmpName.Location = new Point(10, 10);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Text = "Employment Type";

            //
            // txtEmpName
            //
            txtEmpName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmpName.BackColor = Color.Azure;
            txtEmpName.BorderStyle = BorderStyle.FixedSingle;
            txtEmpName.ForeColor = Color.MidnightBlue;
            txtEmpName.Location = new Point(10, 36);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(680, 27);
            txtEmpName.TabIndex = 0;

            //
            // btnEmpSave
            //
            btnEmpSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmpSave.BackColor = Color.MidnightBlue;
            btnEmpSave.FlatAppearance.BorderSize = 0;
            btnEmpSave.FlatStyle = FlatStyle.Flat;
            btnEmpSave.ForeColor = Color.Azure;
            btnEmpSave.Location = new Point(706, 33);
            btnEmpSave.Name = "btnEmpSave";
            btnEmpSave.Size = new Size(110, 30);
            btnEmpSave.TabIndex = 1;
            btnEmpSave.Text = "Save";
            btnEmpSave.UseVisualStyleBackColor = false;

            //
            // btnEmpDelete
            //
            btnEmpDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmpDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnEmpDelete.FlatAppearance.BorderSize = 0;
            btnEmpDelete.FlatStyle = FlatStyle.Flat;
            btnEmpDelete.ForeColor = Color.Azure;
            btnEmpDelete.Location = new Point(824, 33);
            btnEmpDelete.Name = "btnEmpDelete";
            btnEmpDelete.Size = new Size(110, 30);
            btnEmpDelete.TabIndex = 2;
            btnEmpDelete.Text = "Delete";
            btnEmpDelete.UseVisualStyleBackColor = false;

            //
            // dgvEmploymentTypes
            //
            SetGridStyle(dgvEmploymentTypes);
            dgvEmploymentTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvEmploymentTypes.Location = new Point(10, 90);
            dgvEmploymentTypes.Name = "dgvEmploymentTypes";
            dgvEmploymentTypes.Size = new Size(942, 397);
            dgvEmploymentTypes.TabIndex = 1;

            //
            // tabRequirementTypes
            //
            tabRequirementTypes.BackColor = Color.Azure;
            tabRequirementTypes.Controls.Add(pnlReq);
            tabRequirementTypes.Controls.Add(dgvRequirementTypes);
            tabRequirementTypes.Location = new Point(4, 29);
            tabRequirementTypes.Name = "tabRequirementTypes";
            tabRequirementTypes.Size = new Size(962, 497);
            tabRequirementTypes.TabIndex = 3;
            tabRequirementTypes.Text = "Requirement Types";

            //
            // pnlReq
            //
            pnlReq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlReq.BackColor = Color.SteelBlue;
            pnlReq.BorderStyle = BorderStyle.FixedSingle;
            pnlReq.Controls.Add(lblReqName);
            pnlReq.Controls.Add(txtReqName);
            pnlReq.Controls.Add(btnReqSave);
            pnlReq.Controls.Add(btnReqDelete);
            pnlReq.Location = new Point(10, 10);
            pnlReq.Name = "pnlReq";
            pnlReq.Size = new Size(942, 70);
            pnlReq.TabIndex = 0;

            //
            // lblReqName
            //
            lblReqName.AutoSize = true;
            lblReqName.Font = new Font("Segoe UI", 10.2F);
            lblReqName.ForeColor = Color.Azure;
            lblReqName.Location = new Point(10, 10);
            lblReqName.Name = "lblReqName";
            lblReqName.Text = "Requirement Type";

            //
            // txtReqName
            //
            txtReqName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReqName.BackColor = Color.Azure;
            txtReqName.BorderStyle = BorderStyle.FixedSingle;
            txtReqName.ForeColor = Color.MidnightBlue;
            txtReqName.Location = new Point(10, 36);
            txtReqName.Name = "txtReqName";
            txtReqName.Size = new Size(680, 27);
            txtReqName.TabIndex = 0;

            //
            // btnReqSave
            //
            btnReqSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReqSave.BackColor = Color.MidnightBlue;
            btnReqSave.FlatAppearance.BorderSize = 0;
            btnReqSave.FlatStyle = FlatStyle.Flat;
            btnReqSave.ForeColor = Color.Azure;
            btnReqSave.Location = new Point(706, 33);
            btnReqSave.Name = "btnReqSave";
            btnReqSave.Size = new Size(110, 30);
            btnReqSave.TabIndex = 1;
            btnReqSave.Text = "Save";
            btnReqSave.UseVisualStyleBackColor = false;

            //
            // btnReqDelete
            //
            btnReqDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReqDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnReqDelete.FlatAppearance.BorderSize = 0;
            btnReqDelete.FlatStyle = FlatStyle.Flat;
            btnReqDelete.ForeColor = Color.Azure;
            btnReqDelete.Location = new Point(824, 33);
            btnReqDelete.Name = "btnReqDelete";
            btnReqDelete.Size = new Size(110, 30);
            btnReqDelete.TabIndex = 2;
            btnReqDelete.Text = "Delete";
            btnReqDelete.UseVisualStyleBackColor = false;

            //
            // dgvRequirementTypes
            //
            SetGridStyle(dgvRequirementTypes);
            dgvRequirementTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvRequirementTypes.Location = new Point(10, 90);
            dgvRequirementTypes.Name = "dgvRequirementTypes";
            dgvRequirementTypes.Size = new Size(942, 397);
            dgvRequirementTypes.TabIndex = 1;

            //
            // tabInterviewTypes
            //
            tabInterviewTypes.BackColor = Color.Azure;
            tabInterviewTypes.Controls.Add(pnlInt);
            tabInterviewTypes.Controls.Add(dgvInterviewTypes);
            tabInterviewTypes.Location = new Point(4, 29);
            tabInterviewTypes.Name = "tabInterviewTypes";
            tabInterviewTypes.Size = new Size(962, 497);
            tabInterviewTypes.TabIndex = 4;
            tabInterviewTypes.Text = "Interview Types";

            //
            // pnlInt
            //
            pnlInt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInt.BackColor = Color.SteelBlue;
            pnlInt.BorderStyle = BorderStyle.FixedSingle;
            pnlInt.Controls.Add(lblIntName);
            pnlInt.Controls.Add(txtIntName);
            pnlInt.Controls.Add(btnIntSave);
            pnlInt.Controls.Add(btnIntDelete);
            pnlInt.Location = new Point(10, 10);
            pnlInt.Name = "pnlInt";
            pnlInt.Size = new Size(942, 70);
            pnlInt.TabIndex = 0;

            //
            // lblIntName
            //
            lblIntName.AutoSize = true;
            lblIntName.Font = new Font("Segoe UI", 10.2F);
            lblIntName.ForeColor = Color.Azure;
            lblIntName.Location = new Point(10, 10);
            lblIntName.Name = "lblIntName";
            lblIntName.Text = "Interview Type";

            //
            // txtIntName
            //
            txtIntName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIntName.BackColor = Color.Azure;
            txtIntName.BorderStyle = BorderStyle.FixedSingle;
            txtIntName.ForeColor = Color.MidnightBlue;
            txtIntName.Location = new Point(10, 36);
            txtIntName.Name = "txtIntName";
            txtIntName.Size = new Size(680, 27);
            txtIntName.TabIndex = 0;

            //
            // btnIntSave
            //
            btnIntSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIntSave.BackColor = Color.MidnightBlue;
            btnIntSave.FlatAppearance.BorderSize = 0;
            btnIntSave.FlatStyle = FlatStyle.Flat;
            btnIntSave.ForeColor = Color.Azure;
            btnIntSave.Location = new Point(706, 33);
            btnIntSave.Name = "btnIntSave";
            btnIntSave.Size = new Size(110, 30);
            btnIntSave.TabIndex = 1;
            btnIntSave.Text = "Save";
            btnIntSave.UseVisualStyleBackColor = false;

            //
            // btnIntDelete
            //
            btnIntDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIntDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnIntDelete.FlatAppearance.BorderSize = 0;
            btnIntDelete.FlatStyle = FlatStyle.Flat;
            btnIntDelete.ForeColor = Color.Azure;
            btnIntDelete.Location = new Point(824, 33);
            btnIntDelete.Name = "btnIntDelete";
            btnIntDelete.Size = new Size(110, 30);
            btnIntDelete.TabIndex = 2;
            btnIntDelete.Text = "Delete";
            btnIntDelete.UseVisualStyleBackColor = false;

            //
            // dgvInterviewTypes
            //
            SetGridStyle(dgvInterviewTypes);
            dgvInterviewTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvInterviewTypes.Location = new Point(10, 90);
            dgvInterviewTypes.Name = "dgvInterviewTypes";
            dgvInterviewTypes.Size = new Size(942, 397);
            dgvInterviewTypes.TabIndex = 1;

            //
            // TabAssessmentTypes
            //
            tabAssessmentTypes.BackColor = Color.Azure;
            tabAssessmentTypes.Controls.Add(pnlAss);
            tabAssessmentTypes.Controls.Add(dgvAssessmentTypes);
            tabAssessmentTypes.Location = new Point(4, 29);
            tabAssessmentTypes.Name = "tabAssessmentTypes";
            tabAssessmentTypes.Size = new Size(962, 497);
            tabAssessmentTypes.TabIndex = 5;
            tabAssessmentTypes.Text = "Assessment Types";

            //
            // pnlAss
            //
            pnlAss.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAss.BackColor = Color.SteelBlue;
            pnlAss.BorderStyle = BorderStyle.FixedSingle;
            pnlAss.Controls.Add(lblAssName);
            pnlAss.Controls.Add(txtAssName);
            pnlAss.Controls.Add(btnAssSave);
            pnlAss.Controls.Add(btnAssDelete);
            pnlAss.Location = new Point(10, 10);
            pnlAss.Name = "pnlAss";
            pnlAss.Size = new Size(942, 70);
            pnlAss.TabIndex = 0;

            //
            // lblAss
            //
            lblAssName.AutoSize = true;
            lblAssName.Font = new Font("Segoe UI", 10.2F);
            lblAssName.ForeColor = Color.Azure;
            lblAssName.Location = new Point(10, 10);
            lblAssName.Name = "lblAssName";
            lblAssName.Text = "Assessment Type";

            //
            // txtAssName
            //
            txtAssName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAssName.BackColor = Color.Azure;
            txtAssName.BorderStyle = BorderStyle.FixedSingle;
            txtAssName.ForeColor = Color.MidnightBlue;
            txtAssName.Location = new Point(10, 36);
            txtAssName.Name = "txtAssName";
            txtAssName.Size = new Size(680, 27);
            txtAssName.TabIndex = 0;

            //
            // btnAssSave
            //
            btnAssSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAssSave.BackColor = Color.MidnightBlue;
            btnAssSave.FlatAppearance.BorderSize = 0;
            btnAssSave.FlatStyle = FlatStyle.Flat;
            btnAssSave.ForeColor = Color.Azure;
            btnAssSave.Location = new Point(706, 33);
            btnAssSave.Name = "btnAssSave";
            btnAssSave.Size = new Size(110, 30);
            btnAssSave.TabIndex = 1;
            btnAssSave.Text = "Save";
            btnAssSave.UseVisualStyleBackColor = false;

            //
            // btnAssDelete
            //
            btnAssDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAssDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnAssDelete.FlatAppearance.BorderSize = 0;
            btnAssDelete.FlatStyle = FlatStyle.Flat;
            btnAssDelete.ForeColor = Color.Azure;
            btnAssDelete.Location = new Point(824, 33);
            btnAssDelete.Name = "btnAssDelete";
            btnAssDelete.Size = new Size(110, 30);
            btnAssDelete.TabIndex = 2;
            btnAssDelete.Text = "Delete";
            btnAssDelete.UseVisualStyleBackColor = false;

            //
            // dgvAssessmentTypes
            //
            SetGridStyle(dgvAssessmentTypes);
            dgvAssessmentTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvAssessmentTypes.Location = new Point(10, 90);
            dgvAssessmentTypes.Name = "dgvAssessmentTypes";
            dgvAssessmentTypes.Size = new Size(942, 397);
            dgvAssessmentTypes.TabIndex = 1;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1024, 610);
            Controls.Add(tabMaintenance);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maintenance Module";
            tabMaintenance.ResumeLayout(false);
            tabDepartments.ResumeLayout(false);
            tabPositions.ResumeLayout(false);
            tabEmploymentTypes.ResumeLayout(false);
            tabRequirementTypes.ResumeLayout(false);
            tabInterviewTypes.ResumeLayout(false);
            tabAssessmentTypes.ResumeLayout(false);
            pnlDept.ResumeLayout(false);
            pnlDept.PerformLayout();
            pnlPos.ResumeLayout(false);
            pnlPos.PerformLayout();
            pnlEmp.ResumeLayout(false);
            pnlEmp.PerformLayout();
            pnlReq.ResumeLayout(false);
            pnlReq.PerformLayout();
            pnlInt.ResumeLayout(false);
            pnlInt.PerformLayout();
            pnlAss.ResumeLayout(false);
            pnlAss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmploymentTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequirementTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInterviewTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssessmentTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Applies consistent Azure/MidnightBlue/SteelBlue styling to all grids
        /// </summary>
        private static void SetGridStyle(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.Azure;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.MidnightBlue,
                ForeColor = Color.Azure,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Azure,
                ForeColor = Color.MidnightBlue,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.Azure
            };
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.SteelBlue;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion

        private Label lblTitle;
        private TabControl tabMaintenance;
        private TabPage tabDepartments;
        private TabPage tabPositions;
        private TabPage tabEmploymentTypes;
        private TabPage tabRequirementTypes;
        private TabPage tabInterviewTypes;
        private TabPage tabAssessmentTypes;
        private Panel pnlDept;
        private Label lblDeptName;
        private TextBox txtDeptName;
        private Button btnDeptSave;
        private Button btnDeptDelete;
        private DataGridView dgvDepartments;
        private Panel pnlPos;
        private Label lblPosName;
        private TextBox txtPosName;
        private Button btnPosSave;
        private Button btnPosDelete;
        private DataGridView dgvPositions;
        private Panel pnlEmp;
        private Label lblEmpName;
        private TextBox txtEmpName;
        private Button btnEmpSave;
        private Button btnEmpDelete;
        private DataGridView dgvEmploymentTypes;
        private Panel pnlReq;
        private Label lblReqName;
        private TextBox txtReqName;
        private Button btnReqSave;
        private Button btnReqDelete;
        private DataGridView dgvRequirementTypes;
        private Panel pnlInt;
        private Label lblIntName;
        private TextBox txtIntName;
        private Button btnIntSave;
        private Button btnIntDelete;
        private DataGridView dgvInterviewTypes;
        private Panel pnlAss;
        private Label lblAssName;
        private TextBox txtAssName;
        private Button btnAssSave;
        private Button btnAssDelete;
        private DataGridView dgvAssessmentTypes;
    }
}
