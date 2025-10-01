namespace BankManagement
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSearch = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            OpenAt = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            Notes = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1228, 679);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(btnAdd);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(3, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(976, 129);
            panelSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(782, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(138, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(577, 33);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(56, 55);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(76, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, Balance, OpenAt, FirstName, LastName, Edit, Delete, Notes });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(976, 538);
            dataGridView1.TabIndex = 1;
            // 
            // Number
            // 
            Number.DataPropertyName = "Number";
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 73;
            // 
            // OpenAt
            // 
            OpenAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OpenAt.DataPropertyName = "OpenAt";
            OpenAt.HeaderText = "OpenAt";
            OpenAt.Name = "OpenAt";
            OpenAt.ReadOnly = true;
            OpenAt.Width = 73;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 86;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 85;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.Edit;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 33;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.Delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 46;
            // 
            // Notes
            // 
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 679);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Browser";
            tableLayoutPanel1.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSearch;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn OpenAt;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn Notes;
    }
}
