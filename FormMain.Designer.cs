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
            if (disposing)
            {
                // Dispose components (auto-generated)
                components?.Dispose();
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            dgvMain = new DataGridView();
            MainSTT = new DataGridViewTextBoxColumn();
            AccountNumber = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            InterestRate = new DataGridViewTextBoxColumn();
            OpenAt = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            tableLayoutPanel = new TableLayoutPanel();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvMainStatusStrip = new StatusStrip();
            tslblDataRowCount = new ToolStripStatusLabel();
            tslblDebitCount = new ToolStripStatusLabel();
            tslblCreditCount = new ToolStripStatusLabel();
            tslblSavingsCount = new ToolStripStatusLabel();
            dgvSubStatusStrip = new StatusStrip();
            tslblSubDataRowCount = new ToolStripStatusLabel();
            tslblDeposit = new ToolStripStatusLabel();
            tslblWithdraw = new ToolStripStatusLabel();
            tslblTransfer = new ToolStripStatusLabel();
            panelHistoryBrowser = new Panel();
            lblSubText = new Label();
            btnViewMode = new Button();
            lblAccountNumberDisplay = new Label();
            dgvSub = new DataGridView();
            SubSTT = new DataGridViewTextBoxColumn();
            FromAccount = new DataGridViewTextBoxColumn();
            ToAccount = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            tableLayoutPanel.SuspendLayout();
            panelSearch.SuspendLayout();
            dgvMainStatusStrip.SuspendLayout();
            dgvSubStatusStrip.SuspendLayout();
            panelHistoryBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            SuspendLayout();
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToOrderColumns = true;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = SystemColors.Control;
            dataGridViewCellStyle25.Font = new Font("Source Sans 3", 12F, FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { MainSTT, AccountNumber, Balance, InterestRate, OpenAt, AccountType, CustomerID, Edit, Delete });
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = SystemColors.Window;
            dataGridViewCellStyle31.Font = new Font("Source Sans 3", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle31.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = Color.FromArgb(67, 69, 94);
            dataGridViewCellStyle31.SelectionForeColor = Color.White;
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle31;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.Location = new Point(4, 84);
            dgvMain.Margin = new Padding(4);
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersWidth = 51;
            dgvMain.Size = new Size(1070, 826);
            dgvMain.TabIndex = 1;
            dgvMain.CellClick += dgvMain_CellClick;
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            dgvMain.CellPainting += dgv_CellPainting;
            dgvMain.ColumnHeaderMouseClick += dgvMain_ColumnHeaderMouseClick;
            // 
            // MainSTT
            // 
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MainSTT.DefaultCellStyle = dataGridViewCellStyle26;
            MainSTT.HeaderText = "STT";
            MainSTT.MinimumWidth = 55;
            MainSTT.Name = "MainSTT";
            MainSTT.ReadOnly = true;
            MainSTT.Resizable = DataGridViewTriState.False;
            MainSTT.Width = 55;
            // 
            // AccountNumber
            // 
            AccountNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountNumber.DataPropertyName = "AccountNumber";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccountNumber.DefaultCellStyle = dataGridViewCellStyle27;
            AccountNumber.HeaderText = "AccountNumber";
            AccountNumber.MinimumWidth = 196;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.ReadOnly = true;
            AccountNumber.Width = 196;
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Balance.DataPropertyName = "Balance";
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleRight;
            Balance.DefaultCellStyle = dataGridViewCellStyle28;
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 130;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 130;
            // 
            // InterestRate
            // 
            InterestRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InterestRate.DataPropertyName = "InterestRate";
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleRight;
            InterestRate.DefaultCellStyle = dataGridViewCellStyle29;
            InterestRate.HeaderText = "InterestRate";
            InterestRate.MinimumWidth = 130;
            InterestRate.Name = "InterestRate";
            InterestRate.ReadOnly = true;
            InterestRate.Width = 152;
            // 
            // OpenAt
            // 
            OpenAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OpenAt.DataPropertyName = "OpenAt";
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OpenAt.DefaultCellStyle = dataGridViewCellStyle30;
            OpenAt.HeaderText = "OpenAt";
            OpenAt.MinimumWidth = 113;
            OpenAt.Name = "OpenAt";
            OpenAt.ReadOnly = true;
            OpenAt.Width = 113;
            // 
            // AccountType
            // 
            AccountType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountType.DataPropertyName = "AccountTypeName";
            AccountType.HeaderText = "Type";
            AccountType.MinimumWidth = 86;
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
            Edit.ToolTipText = "Enter Edit";
            Edit.Width = 54;
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
            Delete.ToolTipText = "Delete this Row";
            Delete.Width = 75;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.FromArgb(157, 157, 194);
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel.Controls.Add(dgvMain, 0, 1);
            tableLayoutPanel.Controls.Add(dgvMainStatusStrip, 0, 2);
            tableLayoutPanel.Controls.Add(dgvSubStatusStrip, 1, 2);
            tableLayoutPanel.Controls.Add(panelHistoryBrowser, 1, 0);
            tableLayoutPanel.Controls.Add(dgvSub, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(1540, 941);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Font = new Font("Segoe UI", 11F);
            panelSearch.Location = new Point(4, 4);
            panelSearch.Margin = new Padding(4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1070, 72);
            panelSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12.25F);
            txtSearch.Location = new Point(23, 19);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "    Search";
            txtSearch.Size = new Size(503, 35);
            txtSearch.TabIndex = 1;
            toolTip.SetToolTip(txtSearch, "Account Number / Account Type / Customer ID");
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(535, 15);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 42);
            btnSearch.TabIndex = 2;
            toolTip.SetToolTip(btnSearch, "Search");
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMainStatusStrip
            // 
            dgvMainStatusStrip.ImageScalingSize = new Size(20, 20);
            dgvMainStatusStrip.Items.AddRange(new ToolStripItem[] { tslblDataRowCount, tslblDebitCount, tslblCreditCount, tslblSavingsCount });
            dgvMainStatusStrip.Location = new Point(0, 914);
            dgvMainStatusStrip.Name = "dgvMainStatusStrip";
            dgvMainStatusStrip.Size = new Size(1078, 27);
            dgvMainStatusStrip.TabIndex = 2;
            dgvMainStatusStrip.Text = "dgvMainStatusStrip";
            // 
            // tslblDataRowCount
            // 
            tslblDataRowCount.BackColor = SystemColors.Control;
            tslblDataRowCount.Name = "tslblDataRowCount";
            tslblDataRowCount.Size = new Size(119, 21);
            tslblDataRowCount.Text = "Total Items: N/A";
            // 
            // tslblDebitCount
            // 
            tslblDebitCount.BackColor = SystemColors.Control;
            tslblDebitCount.Name = "tslblDebitCount";
            tslblDebitCount.Size = new Size(54, 21);
            tslblDebitCount.Text = "Debit: ";
            // 
            // tslblCreditCount
            // 
            tslblCreditCount.BackColor = SystemColors.Control;
            tslblCreditCount.Name = "tslblCreditCount";
            tslblCreditCount.Size = new Size(59, 21);
            tslblCreditCount.Text = "Credit: ";
            // 
            // tslblSavingsCount
            // 
            tslblSavingsCount.BackColor = SystemColors.Control;
            tslblSavingsCount.Name = "tslblSavingsCount";
            tslblSavingsCount.Size = new Size(71, 21);
            tslblSavingsCount.Text = "Savings: ";
            // 
            // dgvSubStatusStrip
            // 
            dgvSubStatusStrip.ImageScalingSize = new Size(20, 20);
            dgvSubStatusStrip.Items.AddRange(new ToolStripItem[] { tslblSubDataRowCount, tslblDeposit, tslblWithdraw, tslblTransfer });
            dgvSubStatusStrip.Location = new Point(1078, 914);
            dgvSubStatusStrip.Name = "dgvSubStatusStrip";
            dgvSubStatusStrip.Size = new Size(462, 27);
            dgvSubStatusStrip.TabIndex = 5;
            dgvSubStatusStrip.Text = "statusStrip2";
            // 
            // tslblSubDataRowCount
            // 
            tslblSubDataRowCount.BackColor = SystemColors.Control;
            tslblSubDataRowCount.Name = "tslblSubDataRowCount";
            tslblSubDataRowCount.Size = new Size(77, 21);
            tslblSubDataRowCount.Text = "Total: N/A";
            // 
            // tslblDeposit
            // 
            tslblDeposit.BackColor = SystemColors.Control;
            tslblDeposit.Name = "tslblDeposit";
            tslblDeposit.Size = new Size(70, 21);
            tslblDeposit.Text = "Deposit: ";
            // 
            // tslblWithdraw
            // 
            tslblWithdraw.BackColor = SystemColors.Control;
            tslblWithdraw.Name = "tslblWithdraw";
            tslblWithdraw.Size = new Size(85, 21);
            tslblWithdraw.Text = "Withdraw: ";
            // 
            // tslblTransfer
            // 
            tslblTransfer.BackColor = SystemColors.Control;
            tslblTransfer.Name = "tslblTransfer";
            tslblTransfer.Size = new Size(73, 21);
            tslblTransfer.Text = "Transfer: ";
            // 
            // panelHistoryBrowser
            // 
            panelHistoryBrowser.BorderStyle = BorderStyle.FixedSingle;
            panelHistoryBrowser.Controls.Add(lblSubText);
            panelHistoryBrowser.Controls.Add(btnViewMode);
            panelHistoryBrowser.Controls.Add(lblAccountNumberDisplay);
            panelHistoryBrowser.Dock = DockStyle.Fill;
            panelHistoryBrowser.Font = new Font("Segoe UI", 11F);
            panelHistoryBrowser.Location = new Point(1082, 4);
            panelHistoryBrowser.Margin = new Padding(4);
            panelHistoryBrowser.Name = "panelHistoryBrowser";
            panelHistoryBrowser.Size = new Size(454, 72);
            panelHistoryBrowser.TabIndex = 4;
            // 
            // lblSubText
            // 
            lblSubText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSubText.AutoSize = true;
            lblSubText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubText.ForeColor = Color.White;
            lblSubText.Location = new Point(15, 12);
            lblSubText.Name = "lblSubText";
            lblSubText.Size = new Size(259, 23);
            lblSubText.TabIndex = 0;
            lblSubText.Text = "Showing Transaction history of";
            // 
            // btnViewMode
            // 
            btnViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewMode.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewMode.Cursor = Cursors.Hand;
            btnViewMode.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewMode.Image = (Image)resources.GetObject("btnViewMode.Image");
            btnViewMode.Location = new Point(394, 14);
            btnViewMode.Margin = new Padding(4);
            btnViewMode.Name = "btnViewMode";
            btnViewMode.Size = new Size(42, 42);
            btnViewMode.TabIndex = 2;
            toolTip.SetToolTip(btnViewMode, "View All");
            btnViewMode.UseVisualStyleBackColor = true;
            btnViewMode.Click += btnViewMode_Click;
            // 
            // lblAccountNumberDisplay
            // 
            lblAccountNumberDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAccountNumberDisplay.AutoSize = true;
            lblAccountNumberDisplay.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAccountNumberDisplay.ForeColor = Color.White;
            lblAccountNumberDisplay.Location = new Point(15, 40);
            lblAccountNumberDisplay.Name = "lblAccountNumberDisplay";
            lblAccountNumberDisplay.Size = new Size(170, 25);
            lblAccountNumberDisplay.TabIndex = 0;
            lblAccountNumberDisplay.Text = "Account: Number";
            // 
            // dgvSub
            // 
            dgvSub.AllowUserToAddRows = false;
            dgvSub.AllowUserToDeleteRows = false;
            dgvSub.AllowUserToOrderColumns = true;
            dgvSub.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = SystemColors.Control;
            dataGridViewCellStyle32.Font = new Font("Source Sans 3", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle32.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
            dgvSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { SubSTT, FromAccount, ToAccount, Type, Amount });
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = SystemColors.Window;
            dataGridViewCellStyle36.Font = new Font("Source Sans 3", 12F);
            dataGridViewCellStyle36.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = Color.FromArgb(67, 69, 94);
            dataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.False;
            dgvSub.DefaultCellStyle = dataGridViewCellStyle36;
            dgvSub.Dock = DockStyle.Fill;
            dgvSub.Location = new Point(1082, 84);
            dgvSub.Margin = new Padding(4);
            dgvSub.MultiSelect = false;
            dgvSub.Name = "dgvSub";
            dgvSub.ReadOnly = true;
            dgvSub.RowHeadersWidth = 51;
            dgvSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSub.Size = new Size(454, 826);
            dgvSub.TabIndex = 3;
            dgvSub.CellDoubleClick += dgvSub_CellDoubleClick;
            dgvSub.CellPainting += dgv_CellPainting;
            // 
            // SubSTT
            // 
            SubSTT.HeaderText = "STT";
            SubSTT.MinimumWidth = 55;
            SubSTT.Name = "SubSTT";
            SubSTT.ReadOnly = true;
            SubSTT.Width = 55;
            // 
            // FromAccount
            // 
            FromAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FromAccount.DataPropertyName = "FromAccountNumber";
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleCenter;
            FromAccount.DefaultCellStyle = dataGridViewCellStyle33;
            FromAccount.HeaderText = "From";
            FromAccount.MinimumWidth = 70;
            FromAccount.Name = "FromAccount";
            FromAccount.ReadOnly = true;
            FromAccount.Width = 87;
            // 
            // ToAccount
            // 
            ToAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ToAccount.DataPropertyName = "ToAccountNumber";
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ToAccount.DefaultCellStyle = dataGridViewCellStyle34;
            ToAccount.HeaderText = "To";
            ToAccount.MinimumWidth = 70;
            ToAccount.Name = "ToAccount";
            ToAccount.ReadOnly = true;
            ToAccount.Width = 70;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Type.DataPropertyName = "GetTransType";
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 82;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleRight;
            Amount.DefaultCellStyle = dataGridViewCellStyle35;
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // FormMain
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 941);
            Controls.Add(tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Browser";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            dgvMainStatusStrip.ResumeLayout(false);
            dgvMainStatusStrip.PerformLayout();
            dgvSubStatusStrip.ResumeLayout(false);
            dgvSubStatusStrip.PerformLayout();
            panelHistoryBrowser.ResumeLayout(false);
            panelHistoryBrowser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMain;
        private TableLayoutPanel tableLayoutPanel;
        private DataGridView dgvSub;
        private Panel panelSearch;
        private StatusStrip dgvMainStatusStrip;
        private ToolStripStatusLabel tslblDataRowCount;
        private ToolStripStatusLabel tslblDebitCount;
        private ToolStripStatusLabel tslblCreditCount;
        private ToolStripStatusLabel tslblSavingsCount;
        private StatusStrip dgvSubStatusStrip;
        private ToolStripStatusLabel tslblSubDataRowCount;
        private ToolStripStatusLabel tslblDeposit;
        private ToolStripStatusLabel tslblWithdraw;
        private ToolStripStatusLabel tslblTransfer;
        private Panel panelHistoryBrowser;
        private Label lblAccountNumberDisplay;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnViewMode;
        private ToolTip toolTip;
        private Label lblSubText;
        private DataGridViewTextBoxColumn SubSTT;
        private DataGridViewTextBoxColumn FromAccount;
        private DataGridViewTextBoxColumn ToAccount;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn MainSTT;
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
