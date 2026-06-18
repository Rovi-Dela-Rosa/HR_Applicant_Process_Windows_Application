namespace HR_Applicant_Process_Windows_System_MAIN
{
    partial class ApplicantList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            richTextBoxSearch = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextBoxSearch);
            panel1.Location = new Point(205, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 567);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.SteelBlue;
            linkLabel1.DisabledLinkColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(26, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-- Back";
            linkLabel1.LinkClicked += Back;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 131);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(446, 411);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Username to search";
            // 
            // richTextBoxSearch
            // 
            richTextBoxSearch.BackColor = SystemColors.Window;
            richTextBoxSearch.BorderStyle = BorderStyle.None;
            richTextBoxSearch.Location = new Point(31, 69);
            richTextBoxSearch.Margin = new Padding(3, 4, 3, 4);
            richTextBoxSearch.Name = "richTextBoxSearch";
            richTextBoxSearch.Size = new Size(377, 32);
            richTextBoxSearch.TabIndex = 1;
            richTextBoxSearch.Text = "";
            richTextBoxSearch.TextChanged += richTextBoxSearch_TextChanged;
            // 
            // ApplicantList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicantList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RichTextBox richTextBoxSearch;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
    }
}