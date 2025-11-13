namespace BankManagement
{
    partial class FormTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaction));
            panelTransfer = new Panel();
            cboReceiver = new ComboBox();
            cboSender = new ComboBox();
            cboTransactionMode = new ComboBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            txtAmount = new TextBox();
            txtNotes = new TextBox();
            lblAmount = new Label();
            lblTransactionType = new Label();
            lblNotes = new Label();
            lblToAcc = new Label();
            lblFromAcc = new Label();
            lblToAccType = new Label();
            lblMoney = new Label();
            lblReceiverNum = new Label();
            lblSenderNum = new Label();
            lblFromAccType = new Label();
            lblBalance = new Label();
            lblTitle = new Label();
            panelTransfer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTransfer
            // 
            panelTransfer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTransfer.BackColor = Color.FromArgb(221, 221, 235);
            panelTransfer.Controls.Add(cboReceiver);
            panelTransfer.Controls.Add(cboSender);
            panelTransfer.Controls.Add(cboTransactionMode);
            panelTransfer.Controls.Add(btnCancel);
            panelTransfer.Controls.Add(btnConfirm);
            panelTransfer.Controls.Add(txtAmount);
            panelTransfer.Controls.Add(txtNotes);
            panelTransfer.Controls.Add(lblAmount);
            panelTransfer.Controls.Add(lblTransactionType);
            panelTransfer.Controls.Add(lblNotes);
            panelTransfer.Controls.Add(lblToAcc);
            panelTransfer.Controls.Add(lblFromAcc);
            panelTransfer.Controls.Add(lblToAccType);
            panelTransfer.Controls.Add(lblMoney);
            panelTransfer.Controls.Add(lblReceiverNum);
            panelTransfer.Controls.Add(lblSenderNum);
            panelTransfer.Controls.Add(lblFromAccType);
            panelTransfer.Controls.Add(lblBalance);
            panelTransfer.Controls.Add(lblTitle);
            panelTransfer.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            panelTransfer.Location = new Point(15, 17);
            panelTransfer.Margin = new Padding(4);
            panelTransfer.Name = "panelTransfer";
            panelTransfer.Size = new Size(883, 685);
            panelTransfer.TabIndex = 0;
            // 
            // cboReceiver
            // 
            cboReceiver.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReceiver.Font = new Font("Source Sans 3", 13F);
            cboReceiver.ForeColor = Color.FromArgb(50, 52, 76);
            cboReceiver.FormattingEnabled = true;
            cboReceiver.Location = new Point(464, 193);
            cboReceiver.Name = "cboReceiver";
            cboReceiver.Size = new Size(309, 35);
            cboReceiver.TabIndex = 4;
            // 
            // cboSender
            // 
            cboSender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSender.Font = new Font("Source Sans 3", 13F);
            cboSender.ForeColor = Color.FromArgb(50, 52, 76);
            cboSender.FormattingEnabled = true;
            cboSender.Location = new Point(116, 193);
            cboSender.Name = "cboSender";
            cboSender.Size = new Size(309, 35);
            cboSender.TabIndex = 4;
            // 
            // cboTransactionMode
            // 
            cboTransactionMode.Cursor = Cursors.Hand;
            cboTransactionMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransactionMode.Font = new Font("Source Sans 3", 13F);
            cboTransactionMode.ForeColor = Color.FromArgb(50, 52, 76);
            cboTransactionMode.FormattingEnabled = true;
            cboTransactionMode.Items.AddRange(new object[] { "Transfer", "Deposit", "Withdraw" });
            cboTransactionMode.Location = new Point(536, 305);
            cboTransactionMode.Name = "cboTransactionMode";
            cboTransactionMode.Size = new Size(237, 35);
            cboTransactionMode.TabIndex = 3;
            cboTransactionMode.SelectedIndexChanged += cboTransactionMode_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(67, 69, 94);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Source Sans 3", 13.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(50, 52, 76);
            btnCancel.Location = new Point(563, 575);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "✖ CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(67, 69, 94);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Source Sans 3", 13.25F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(116, 575);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(190, 50);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "✓ CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Source Sans 3", 12F);
            txtAmount.ForeColor = Color.FromArgb(50, 52, 76);
            txtAmount.Location = new Point(116, 304);
            txtAmount.Margin = new Padding(4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(346, 36);
            txtAmount.TabIndex = 1;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Source Sans 3", 12F);
            txtNotes.ForeColor = Color.FromArgb(50, 52, 76);
            txtNotes.Location = new Point(116, 397);
            txtNotes.Margin = new Padding(4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(657, 131);
            txtNotes.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(50, 52, 76);
            lblAmount.Location = new Point(109, 272);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(93, 28);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTransactionType.ForeColor = Color.FromArgb(50, 52, 76);
            lblTransactionType.Location = new Point(530, 272);
            lblTransactionType.Margin = new Padding(4, 0, 4, 0);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(177, 28);
            lblTransactionType.TabIndex = 0;
            lblTransactionType.Text = "Transaction Type:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(50, 52, 76);
            lblNotes.Location = new Point(109, 365);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(193, 28);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Description (Note):";
            // 
            // lblToAcc
            // 
            lblToAcc.AutoSize = true;
            lblToAcc.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblToAcc.ForeColor = Color.FromArgb(50, 52, 76);
            lblToAcc.Location = new Point(458, 161);
            lblToAcc.Margin = new Padding(4, 0, 4, 0);
            lblToAcc.Name = "lblToAcc";
            lblToAcc.Size = new Size(123, 28);
            lblToAcc.TabIndex = 0;
            lblToAcc.Text = "To Account:";
            // 
            // lblFromAcc
            // 
            lblFromAcc.AutoSize = true;
            lblFromAcc.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblFromAcc.ForeColor = Color.FromArgb(50, 52, 76);
            lblFromAcc.Location = new Point(113, 161);
            lblFromAcc.Margin = new Padding(4, 0, 4, 0);
            lblFromAcc.Name = "lblFromAcc";
            lblFromAcc.Size = new Size(149, 28);
            lblFromAcc.TabIndex = 0;
            lblFromAcc.Text = "From Account:";
            // 
            // lblToAccType
            // 
            lblToAccType.AutoSize = true;
            lblToAccType.Font = new Font("Segoe UI", 11.5F);
            lblToAccType.ForeColor = Color.FromArgb(50, 52, 76);
            lblToAccType.Location = new Point(458, 238);
            lblToAccType.Margin = new Padding(4, 0, 4, 0);
            lblToAccType.Name = "lblToAccType";
            lblToAccType.Size = new Size(16, 28);
            lblToAccType.TabIndex = 0;
            lblToAccType.Text = ".";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Source Sans 3", 12F);
            lblMoney.Location = new Point(202, 122);
            lblMoney.Margin = new Padding(4, 0, 4, 0);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(22, 25);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "0";
            // 
            // lblReceiverNum
            // 
            lblReceiverNum.AutoSize = true;
            lblReceiverNum.Font = new Font("Segoe UI", 11.5F);
            lblReceiverNum.ForeColor = Color.FromArgb(50, 52, 76);
            lblReceiverNum.Location = new Point(581, 161);
            lblReceiverNum.Margin = new Padding(4, 0, 4, 0);
            lblReceiverNum.Name = "lblReceiverNum";
            lblReceiverNum.Size = new Size(16, 28);
            lblReceiverNum.TabIndex = 0;
            lblReceiverNum.Text = ".";
            // 
            // lblSenderNum
            // 
            lblSenderNum.AutoSize = true;
            lblSenderNum.Font = new Font("Segoe UI", 11.5F);
            lblSenderNum.Location = new Point(263, 161);
            lblSenderNum.Margin = new Padding(4, 0, 4, 0);
            lblSenderNum.Name = "lblSenderNum";
            lblSenderNum.Size = new Size(16, 28);
            lblSenderNum.TabIndex = 0;
            lblSenderNum.Text = ".";
            // 
            // lblFromAccType
            // 
            lblFromAccType.AutoSize = true;
            lblFromAccType.Font = new Font("Segoe UI", 11.5F);
            lblFromAccType.ForeColor = Color.FromArgb(50, 52, 76);
            lblFromAccType.Location = new Point(112, 233);
            lblFromAccType.Margin = new Padding(4, 0, 4, 0);
            lblFromAccType.Name = "lblFromAccType";
            lblFromAccType.Size = new Size(16, 28);
            lblFromAccType.TabIndex = 0;
            lblFromAccType.Text = ".";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblBalance.ForeColor = Color.FromArgb(50, 52, 76);
            lblBalance.Location = new Point(113, 118);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(91, 28);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(367, 51);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANSFER";
            // 
            // FormTransaction
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 157, 194);
            CancelButton = btnCancel;
            ClientSize = new Size(914, 717);
            Controls.Add(panelTransfer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Transaction";
            Load += FormTransfer_Load;
            panelTransfer.ResumeLayout(false);
            panelTransfer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTransfer;
        private Label lblFromAcc;
        private Label lblBalance;
        private Label lblTitle;
        private Label lblAmount;
        private TextBox txtAmount;
        private TextBox txtNotes;
        private Label lblNotes;
        private Label lblToAcc;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblFromAccType;
        private Label lblTittle;
        private Label lblToAccType;
        private Label lblMoney;
        private Label lblSenderNum;
        private Label lblReceiverNum;
        private Label lblTransactionType;
        private ComboBox cboTransactionMode;
        private ComboBox cboSender;
        private ComboBox cboReceiver;
    }
}