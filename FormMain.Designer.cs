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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            miniToolStrip = new StatusStrip();
            dgvMain = new DataGridView();
            AccountNumber = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            InterestRate = new DataGridViewTextBoxColumn();
            OpenAt = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            statusStrip1 = new StatusStrip();
            tslblDataRowCount = new ToolStripStatusLabel();
            tslblDebitCount = new ToolStripStatusLabel();
            tslblCreditCount = new ToolStripStatusLabel();
            tslblSavingsCount = new ToolStripStatusLabel();
            statusStrip2 = new StatusStrip();
            tslblSubDataRowCount = new ToolStripStatusLabel();
            tslblDeposit = new ToolStripStatusLabel();
            tslblWithdraw = new ToolStripStatusLabel();
            tslblTransfer = new ToolStripStatusLabel();
            panelHistoryBrowser = new Panel();
            lblAccountNumberDisplay = new Label();
            dgvSub = new DataGridView();
            FromAccount = new DataGridViewTextBoxColumn();
            ToAccount = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            statusStrip1.SuspendLayout();
            statusStrip2.SuspendLayout();
            panelHistoryBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
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
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, Balance, InterestRate, OpenAt, AccountType, CustomerID, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(67, 69, 94);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.Location = new Point(3, 53);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersWidth = 51;
            dgvMain.Size = new Size(962, 599);
            dgvMain.TabIndex = 1;
            dgvMain.CellClick += dgvMain_CellClick;
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            dgvMain.ColumnHeaderMouseClick += dgvMain_ColumnHeaderMouseClick;
            // 
            // AccountNumber
            // 
            AccountNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountNumber.DataPropertyName = "AccountNumber";
            AccountNumber.HeaderText = "AccountNumber";
            AccountNumber.MinimumWidth = 6;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.ReadOnly = true;
            AccountNumber.Width = 161;
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 95;
            // 
            // InterestRate
            // 
            InterestRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InterestRate.DataPropertyName = "InterestRate";
            InterestRate.HeaderText = "InterestRate";
            InterestRate.MinimumWidth = 6;
            InterestRate.Name = "InterestRate";
            InterestRate.ReadOnly = true;
            InterestRate.Width = 127;
            // 
            // OpenAt
            // 
            OpenAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OpenAt.DataPropertyName = "OpenAt";
            OpenAt.HeaderText = "OpenAt";
            OpenAt.MinimumWidth = 6;
            OpenAt.Name = "OpenAt";
            OpenAt.ReadOnly = true;
            OpenAt.Width = 93;
            // 
            // AccountType
            // 
            AccountType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountType.DataPropertyName = "AccountTypeName";
            AccountType.HeaderText = "Type";
            AccountType.MinimumWidth = 6;
            AccountType.Name = "AccountType";
            AccountType.ReadOnly = true;
            AccountType.Width = 71;
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
            Edit.Width = 46;
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
            Delete.Width = 66;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMain, 0, 1);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 2);
            tableLayoutPanel1.Controls.Add(statusStrip2, 1, 2);
            tableLayoutPanel1.Controls.Add(panelHistoryBrowser, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvSub, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1383, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Font = new Font("Segoe UI", 11F);
            panelSearch.Location = new Point(3, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(962, 44);
            panelSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12.25F);
            txtSearch.Location = new Point(18, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(392, 29);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(416, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 30);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslblDataRowCount, tslblDebitCount, tslblCreditCount, tslblSavingsCount });
            statusStrip1.Location = new Point(0, 655);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(968, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslblDataRowCount
            // 
            tslblDataRowCount.Name = "tslblDataRowCount";
            tslblDataRowCount.Size = new Size(93, 17);
            tslblDataRowCount.Text = "Total Items: N/A";
            // 
            // tslblDebitCount
            // 
            tslblDebitCount.Name = "tslblDebitCount";
            tslblDebitCount.Size = new Size(41, 17);
            tslblDebitCount.Text = "Debit: ";
            // 
            // tslblCreditCount
            // 
            tslblCreditCount.Name = "tslblCreditCount";
            tslblCreditCount.Size = new Size(45, 17);
            tslblCreditCount.Text = "Credit: ";
            // 
            // tslblSavingsCount
            // 
            tslblSavingsCount.Name = "tslblSavingsCount";
            tslblSavingsCount.Size = new Size(53, 17);
            tslblSavingsCount.Text = "Savings: ";
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { tslblSubDataRowCount, tslblDeposit, tslblWithdraw, tslblTransfer });
            statusStrip2.Location = new Point(968, 655);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new Padding(1, 0, 11, 0);
            statusStrip2.Size = new Size(415, 22);
            statusStrip2.TabIndex = 5;
            statusStrip2.Text = "statusStrip2";
            // 
            // tslblSubDataRowCount
            // 
            tslblSubDataRowCount.Name = "tslblSubDataRowCount";
            tslblSubDataRowCount.Size = new Size(61, 17);
            tslblSubDataRowCount.Text = "Total: N/A";
            // 
            // tslblDeposit
            // 
            tslblDeposit.Name = "tslblDeposit";
            tslblDeposit.Size = new Size(53, 17);
            tslblDeposit.Text = "Deposit: ";
            // 
            // tslblWithdraw
            // 
            tslblWithdraw.Name = "tslblWithdraw";
            tslblWithdraw.Size = new Size(64, 17);
            tslblWithdraw.Text = "Withdraw: ";
            // 
            // tslblTransfer
            // 
            tslblTransfer.Name = "tslblTransfer";
            tslblTransfer.Size = new Size(55, 17);
            tslblTransfer.Text = "Transfer: ";
            // 
            // panelHistoryBrowser
            // 
            panelHistoryBrowser.BorderStyle = BorderStyle.FixedSingle;
            panelHistoryBrowser.Controls.Add(lblAccountNumberDisplay);
            panelHistoryBrowser.Dock = DockStyle.Fill;
            panelHistoryBrowser.Font = new Font("Segoe UI", 11F);
            panelHistoryBrowser.Location = new Point(971, 3);
            panelHistoryBrowser.Name = "panelHistoryBrowser";
            panelHistoryBrowser.Size = new Size(409, 44);
            panelHistoryBrowser.TabIndex = 4;
            // 
            // lblAccountNumberDisplay
            // 
            lblAccountNumberDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAccountNumberDisplay.AutoSize = true;
            lblAccountNumberDisplay.Location = new Point(2, 12);
            lblAccountNumberDisplay.Margin = new Padding(2, 0, 2, 0);
            lblAccountNumberDisplay.Name = "lblAccountNumberDisplay";
            lblAccountNumberDisplay.Size = new Size(335, 20);
            lblAccountNumberDisplay.TabIndex = 0;
            lblAccountNumberDisplay.Text = "Showing Transaction History Of Account: Number";
            // 
            // dgvSub
            // 
            dgvSub.AllowUserToAddRows = false;
            dgvSub.AllowUserToDeleteRows = false;
            dgvSub.AllowUserToOrderColumns = true;
            dgvSub.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { FromAccount, ToAccount, Type, Amount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(67, 69, 94);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSub.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSub.Dock = DockStyle.Fill;
            dgvSub.Location = new Point(971, 53);
            dgvSub.Name = "dgvSub";
            dgvSub.ReadOnly = true;
            dgvSub.RowHeadersWidth = 51;
            dgvSub.Size = new Size(409, 599);
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
            FromAccount.Width = 74;
            // 
            // ToAccount
            // 
            ToAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ToAccount.DataPropertyName = "ToAccountNumber";
            ToAccount.HeaderText = "To";
            ToAccount.MinimumWidth = 6;
            ToAccount.Name = "ToAccount";
            ToAccount.ReadOnly = true;
            ToAccount.Width = 53;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Type.DataPropertyName = "GetTransType";
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 71;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 677);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Browser";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            panelHistoryBrowser.ResumeLayout(false);
            panelHistoryBrowser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private StatusStrip miniToolStrip;
        private DataGridView dgvMain;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvSub;
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
        private Panel panelSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslblDataRowCount;
        private ToolStripStatusLabel tslblDebitCount;
        private ToolStripStatusLabel tslblCreditCount;
        private ToolStripStatusLabel tslblSavingsCount;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel tslblSubDataRowCount;
        private ToolStripStatusLabel tslblDeposit;
        private ToolStripStatusLabel tslblWithdraw;
        private ToolStripStatusLabel tslblTransfer;
        private Panel panelHistoryBrowser;
        private Label lblAccountNumberDisplay;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
