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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            miniToolStrip = new StatusStrip();
            tslblDataRowCount = new ToolStripStatusLabel();
            tslblDebitCount = new ToolStripStatusLabel();
            tslblCreditCount = new ToolStripStatusLabel();
            tslblSavingsCount = new ToolStripStatusLabel();
            dgvMain = new DataGridView();
            panelSearch = new Panel();
            btnOpenTransfer = new Button();
            label1 = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip1 = new StatusStrip();
            dgvSub = new DataGridView();
            FromAccount = new DataGridViewTextBoxColumn();
            ToAccount = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panelHistoryBrowser = new Panel();
            lblAccountNumberDisplay = new Label();
            label2 = new Label();
            statusStrip2 = new StatusStrip();
            tslblSubDataRowCount = new ToolStripStatusLabel();
            tslblDeposit = new ToolStripStatusLabel();
            tslblWithdraw = new ToolStripStatusLabel();
            tslblTransfer = new ToolStripStatusLabel();
            AccountNumber = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            InterestRate = new DataGridViewTextBoxColumn();
            OpenAt = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panelSearch.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            panelHistoryBrowser.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(0, 0);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(1170, 27);
            miniToolStrip.TabIndex = 2;
            // 
            // tslblDataRowCount
            // 
            tslblDataRowCount.Name = "tslblDataRowCount";
            tslblDataRowCount.Size = new Size(119, 21);
            tslblDataRowCount.Text = "Total Items: N/A";
            // 
            // tslblDebitCount
            // 
            tslblDebitCount.Name = "tslblDebitCount";
            tslblDebitCount.Size = new Size(54, 21);
            tslblDebitCount.Text = "Debit: ";
            // 
            // tslblCreditCount
            // 
            tslblCreditCount.Name = "tslblCreditCount";
            tslblCreditCount.Size = new Size(59, 21);
            tslblCreditCount.Text = "Credit: ";
            // 
            // tslblSavingsCount
            // 
            tslblSavingsCount.Name = "tslblSavingsCount";
            tslblSavingsCount.Size = new Size(71, 21);
            tslblSavingsCount.Text = "Savings: ";
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, Balance, InterestRate, OpenAt, AccountType, CustomerID, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.Location = new Point(4, 130);
            dgvMain.Margin = new Padding(4);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersWidth = 51;
            dgvMain.Size = new Size(895, 499);
            dgvMain.TabIndex = 1;
            dgvMain.CellClick += dgvMain_CellClick;
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            dgvMain.ColumnHeaderMouseClick += dgvMain_ColumnHeaderMouseClick;
            // 
            // panelSearch
            // 
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(btnOpenTransfer);
            panelSearch.Controls.Add(label1);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(btnAdd);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Font = new Font("Segoe UI", 11F);
            panelSearch.Location = new Point(4, 4);
            panelSearch.Margin = new Padding(4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(895, 118);
            panelSearch.TabIndex = 0;
            // 
            // btnOpenTransfer
            // 
            btnOpenTransfer.BackgroundImage = (Image)resources.GetObject("btnOpenTransfer.BackgroundImage");
            btnOpenTransfer.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenTransfer.Cursor = Cursors.Hand;
            btnOpenTransfer.Location = new Point(783, 37);
            btnOpenTransfer.Name = "btnOpenTransfer";
            btnOpenTransfer.Size = new Size(45, 45);
            btnOpenTransfer.TabIndex = 5;
            btnOpenTransfer.UseVisualStyleBackColor = true;
            btnOpenTransfer.Click += btnOpenTransfer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold);
            label1.Location = new Point(156, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 4;
            label1.Text = "Search:";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(652, 39);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 40);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(731, 37);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 45);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12.25F);
            txtSearch.Location = new Point(256, 41);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(389, 35);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMain, 0, 1);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvSub, 1, 1);
            tableLayoutPanel1.Controls.Add(panelHistoryBrowser, 1, 0);
            tableLayoutPanel1.Controls.Add(statusStrip2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1291, 661);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslblDataRowCount, tslblDebitCount, tslblCreditCount, tslblSavingsCount });
            statusStrip1.Location = new Point(0, 634);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(903, 27);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // dgvSub
            // 
            dgvSub.AllowUserToAddRows = false;
            dgvSub.AllowUserToDeleteRows = false;
            dgvSub.AllowUserToOrderColumns = true;
            dgvSub.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { FromAccount, ToAccount, Type, Amount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSub.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSub.Dock = DockStyle.Fill;
            dgvSub.Location = new Point(907, 130);
            dgvSub.Margin = new Padding(4);
            dgvSub.Name = "dgvSub";
            dgvSub.ReadOnly = true;
            dgvSub.RowHeadersWidth = 51;
            dgvSub.Size = new Size(380, 499);
            dgvSub.TabIndex = 3;
            dgvSub.CellDoubleClick += dgvSub_CellDoubleClick;
            // 
            // FromAccount
            // 
            FromAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FromAccount.DataPropertyName = "FromAccountNumber";
            FromAccount.HeaderText = "From";
            FromAccount.MinimumWidth = 6;
            FromAccount.Name = "FromAccount";
            FromAccount.ReadOnly = true;
            FromAccount.Width = 89;
            // 
            // ToAccount
            // 
            ToAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ToAccount.DataPropertyName = "ToAccountNumber";
            ToAccount.HeaderText = "To";
            ToAccount.MinimumWidth = 6;
            ToAccount.Name = "ToAccount";
            ToAccount.ReadOnly = true;
            ToAccount.Width = 63;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Type.DataPropertyName = "GetTransType";
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 86;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // panelHistoryBrowser
            // 
            panelHistoryBrowser.BorderStyle = BorderStyle.FixedSingle;
            panelHistoryBrowser.Controls.Add(lblAccountNumberDisplay);
            panelHistoryBrowser.Controls.Add(label2);
            panelHistoryBrowser.Dock = DockStyle.Fill;
            panelHistoryBrowser.Font = new Font("Segoe UI", 11F);
            panelHistoryBrowser.Location = new Point(907, 4);
            panelHistoryBrowser.Margin = new Padding(4);
            panelHistoryBrowser.Name = "panelHistoryBrowser";
            panelHistoryBrowser.Size = new Size(380, 118);
            panelHistoryBrowser.TabIndex = 4;
            // 
            // lblAccountNumberDisplay
            // 
            lblAccountNumberDisplay.AutoSize = true;
            lblAccountNumberDisplay.Location = new Point(26, 58);
            lblAccountNumberDisplay.Name = "lblAccountNumberDisplay";
            lblAccountNumberDisplay.Size = new Size(159, 25);
            lblAccountNumberDisplay.TabIndex = 0;
            lblAccountNumberDisplay.Text = "Account: Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(26, 28);
            label2.Name = "label2";
            label2.Size = new Size(299, 25);
            label2.TabIndex = 0;
            label2.Text = "Showing Transaction History of:";
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { tslblSubDataRowCount, tslblDeposit, tslblWithdraw, tslblTransfer });
            statusStrip2.Location = new Point(903, 634);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(388, 27);
            statusStrip2.TabIndex = 5;
            statusStrip2.Text = "statusStrip2";
            // 
            // tslblSubDataRowCount
            // 
            tslblSubDataRowCount.Name = "tslblSubDataRowCount";
            tslblSubDataRowCount.Size = new Size(77, 21);
            tslblSubDataRowCount.Text = "Total: N/A";
            // 
            // tslblDeposit
            // 
            tslblDeposit.Name = "tslblDeposit";
            tslblDeposit.Size = new Size(70, 21);
            tslblDeposit.Text = "Deposit: ";
            // 
            // tslblWithdraw
            // 
            tslblWithdraw.Name = "tslblWithdraw";
            tslblWithdraw.Size = new Size(85, 21);
            tslblWithdraw.Text = "Withdraw: ";
            // 
            // tslblTransfer
            // 
            tslblTransfer.Name = "tslblTransfer";
            tslblTransfer.Size = new Size(73, 21);
            tslblTransfer.Text = "Transfer: ";
            // 
            // AccountNumber
            // 
            AccountNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountNumber.DataPropertyName = "AccountNumber";
            AccountNumber.HeaderText = "AccountNumber";
            AccountNumber.MinimumWidth = 6;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.ReadOnly = true;
            AccountNumber.Width = 196;
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 115;
            // 
            // InterestRate
            // 
            InterestRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InterestRate.DataPropertyName = "InterestRate";
            InterestRate.HeaderText = "InterestRate";
            InterestRate.MinimumWidth = 6;
            InterestRate.Name = "InterestRate";
            InterestRate.ReadOnly = true;
            InterestRate.Width = 157;
            // 
            // OpenAt
            // 
            OpenAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OpenAt.DataPropertyName = "OpenAt";
            OpenAt.HeaderText = "OpenAt";
            OpenAt.MinimumWidth = 6;
            OpenAt.Name = "OpenAt";
            OpenAt.ReadOnly = true;
            OpenAt.Width = 113;
            // 
            // AccountType
            // 
            AccountType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountType.DataPropertyName = "AccountTypeName";
            AccountType.HeaderText = "Type";
            AccountType.MinimumWidth = 6;
            AccountType.Name = "AccountType";
            AccountType.ReadOnly = true;
            AccountType.Width = 86;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 55;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 80;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 661);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Browser";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            panelHistoryBrowser.ResumeLayout(false);
            panelHistoryBrowser.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private StatusStrip miniToolStrip;
        private ToolStripStatusLabel tslblDataRowCount;
        private ToolStripStatusLabel tslblDebitCount;
        private ToolStripStatusLabel tslblCreditCount;
        private ToolStripStatusLabel tslblSavingsCount;
        private DataGridView dgvMain;
        private Panel panelSearch;
        private Button btnOpenTransfer;
        private Label label1;
        private Button btnSearch;
        private Button btnAdd;
        private TextBox txtSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private StatusStrip statusStrip1;
        private DataGridView dgvSub;
        private Panel panelHistoryBrowser;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel tslblSubDataRowCount;
        private ToolStripStatusLabel tslblDeposit;
        private ToolStripStatusLabel tslblWithdraw;
        private ToolStripStatusLabel tslblTransfer;
        private Label lblAccountNumberDisplay;
        private Label label2;
        private DataGridViewTextBoxColumn FromAccount;
        private DataGridViewTextBoxColumn ToAccount;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn InterestRate;
        private DataGridViewTextBoxColumn OpenAt;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
