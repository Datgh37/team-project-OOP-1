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
            panelTransfer = new Panel();
            radWithdraw = new RadioButton();
            radDeposit = new RadioButton();
            radTransfer = new RadioButton();
            btnCancel = new Button();
            btnConfirm = new Button();
            txtFromAcc = new TextBox();
            txtAmount = new TextBox();
            txtToAcc = new TextBox();
            txtNotes = new TextBox();
            lblAmount = new Label();
            lblTransactionType = new Label();
            lblNotes = new Label();
            lblToAcc = new Label();
            lblFromAcc = new Label();
            lblToAccType = new Label();
            lblMoney = new Label();
            lblReceiver = new Label();
            lblSender = new Label();
            lblFromAccType = new Label();
            lblBalance = new Label();
            lblTitle = new Label();
            panelTransfer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTransfer
            // 
            panelTransfer.Controls.Add(radWithdraw);
            panelTransfer.Controls.Add(radDeposit);
            panelTransfer.Controls.Add(radTransfer);
            panelTransfer.Controls.Add(btnCancel);
            panelTransfer.Controls.Add(btnConfirm);
            panelTransfer.Controls.Add(txtFromAcc);
            panelTransfer.Controls.Add(txtAmount);
            panelTransfer.Controls.Add(txtToAcc);
            panelTransfer.Controls.Add(txtNotes);
            panelTransfer.Controls.Add(lblAmount);
            panelTransfer.Controls.Add(lblTransactionType);
            panelTransfer.Controls.Add(lblNotes);
            panelTransfer.Controls.Add(lblToAcc);
            panelTransfer.Controls.Add(lblFromAcc);
            panelTransfer.Controls.Add(lblToAccType);
            panelTransfer.Controls.Add(lblMoney);
            panelTransfer.Controls.Add(lblReceiver);
            panelTransfer.Controls.Add(lblSender);
            panelTransfer.Controls.Add(lblFromAccType);
            panelTransfer.Controls.Add(lblBalance);
            panelTransfer.Controls.Add(lblTitle);
            panelTransfer.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            panelTransfer.Location = new Point(0, -1);
            panelTransfer.Margin = new Padding(4, 4, 4, 4);
            panelTransfer.Name = "panelTransfer";
            panelTransfer.Size = new Size(960, 745);
            panelTransfer.TabIndex = 0;
            // 
            // radWithdraw
            // 
            radWithdraw.AutoSize = true;
            radWithdraw.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            radWithdraw.Location = new Point(707, 440);
            radWithdraw.Name = "radWithdraw";
            radWithdraw.Size = new Size(137, 34);
            radWithdraw.TabIndex = 3;
            radWithdraw.TabStop = true;
            radWithdraw.Text = "Withdraw";
            radWithdraw.UseVisualStyleBackColor = true;
            radWithdraw.CheckedChanged += radWithdraw_CheckedChanged;
            // 
            // radDeposit
            // 
            radDeposit.AutoSize = true;
            radDeposit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            radDeposit.Location = new Point(496, 440);
            radDeposit.Name = "radDeposit";
            radDeposit.Size = new Size(114, 34);
            radDeposit.TabIndex = 3;
            radDeposit.TabStop = true;
            radDeposit.Text = "Deposit";
            radDeposit.UseVisualStyleBackColor = true;
            radDeposit.CheckedChanged += radDeposit_CheckedChanged;
            // 
            // radTransfer
            // 
            radTransfer.AutoSize = true;
            radTransfer.Checked = true;
            radTransfer.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            radTransfer.Location = new Point(287, 440);
            radTransfer.Name = "radTransfer";
            radTransfer.Size = new Size(118, 34);
            radTransfer.TabIndex = 3;
            radTransfer.TabStop = true;
            radTransfer.Text = "Transfer";
            radTransfer.UseVisualStyleBackColor = true;
            radTransfer.CheckedChanged += radTransfer_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(698, 638);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(287, 638);
            btnConfirm.Margin = new Padding(4, 4, 4, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(165, 50);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtFromAcc
            // 
            txtFromAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFromAcc.Location = new Point(287, 203);
            txtFromAcc.Margin = new Padding(4, 4, 4, 4);
            txtFromAcc.Name = "txtFromAcc";
            txtFromAcc.Size = new Size(346, 39);
            txtFromAcc.TabIndex = 1;
            txtFromAcc.TextChanged += txtFromAcc_TextChanged;
            txtFromAcc.Leave += txtFromAcc_Leave;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(287, 364);
            txtAmount.Margin = new Padding(4, 4, 4, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(346, 39);
            txtAmount.TabIndex = 1;
            // 
            // txtToAcc
            // 
            txtToAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToAcc.Location = new Point(287, 286);
            txtToAcc.Margin = new Padding(4, 4, 4, 4);
            txtToAcc.Name = "txtToAcc";
            txtToAcc.Size = new Size(346, 39);
            txtToAcc.TabIndex = 1;
            txtToAcc.TextChanged += txtToAcc_TextChanged;
            txtToAcc.Leave += txtToAcc_Leave;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(287, 511);
            txtNotes.Margin = new Padding(4, 4, 4, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(576, 96);
            txtNotes.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(45, 367);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(108, 31);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(45, 441);
            lblTransactionType.Margin = new Padding(4, 0, 4, 0);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(199, 31);
            lblTransactionType.TabIndex = 0;
            lblTransactionType.Text = "Transaction Type:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(45, 515);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(219, 31);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Description (Note):";
            // 
            // lblToAcc
            // 
            lblToAcc.AutoSize = true;
            lblToAcc.Location = new Point(45, 288);
            lblToAcc.Margin = new Padding(4, 0, 4, 0);
            lblToAcc.Name = "lblToAcc";
            lblToAcc.Size = new Size(140, 31);
            lblToAcc.TabIndex = 0;
            lblToAcc.Text = "To Account:";
            // 
            // lblFromAcc
            // 
            lblFromAcc.AutoSize = true;
            lblFromAcc.Location = new Point(45, 206);
            lblFromAcc.Margin = new Padding(4, 0, 4, 0);
            lblFromAcc.Name = "lblFromAcc";
            lblFromAcc.Size = new Size(171, 31);
            lblFromAcc.TabIndex = 0;
            lblFromAcc.Text = "From Account:";
            // 
            // lblToAccType
            // 
            lblToAccType.AutoSize = true;
            lblToAccType.Font = new Font("Segoe UI", 13.25F);
            lblToAccType.Location = new Point(663, 288);
            lblToAccType.Margin = new Padding(4, 0, 4, 0);
            lblToAccType.Name = "lblToAccType";
            lblToAccType.Size = new Size(19, 31);
            lblToAccType.TabIndex = 0;
            lblToAccType.Text = ".";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(287, 123);
            lblMoney.Margin = new Padding(4, 0, 4, 0);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(27, 32);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "0";
            // 
            // lblReceiver
            // 
            lblReceiver.AutoSize = true;
            lblReceiver.Font = new Font("Segoe UI", 13.25F);
            lblReceiver.Location = new Point(287, 251);
            lblReceiver.Margin = new Padding(4, 0, 4, 0);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(19, 31);
            lblReceiver.TabIndex = 0;
            lblReceiver.Text = ".";
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            lblSender.Font = new Font("Segoe UI", 13.25F);
            lblSender.Location = new Point(287, 162);
            lblSender.Margin = new Padding(4, 0, 4, 0);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(19, 31);
            lblSender.TabIndex = 0;
            lblSender.Text = ".";
            // 
            // lblFromAccType
            // 
            lblFromAccType.AutoSize = true;
            lblFromAccType.Font = new Font("Segoe UI", 13.25F);
            lblFromAccType.Location = new Point(663, 206);
            lblFromAccType.Margin = new Padding(4, 0, 4, 0);
            lblFromAccType.Name = "lblFromAccType";
            lblFromAccType.Size = new Size(19, 31);
            lblFromAccType.TabIndex = 0;
            lblFromAccType.Text = ".";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(45, 123);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(103, 31);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTitle.Location = new Point(433, 48);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(134, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANSFER";
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 743);
            Controls.Add(panelTransfer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTransfer";
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
        private TextBox txtFromAcc;
        private TextBox txtAmount;
        private TextBox txtToAcc;
        private TextBox txtNotes;
        private Label lblNotes;
        private Label lblToAcc;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblFromAccType;
        private Label lblTittle;
        private RadioButton radTransfer;
        private Label lblTransactionType;
        private RadioButton radWithdraw;
        private RadioButton radDeposit;
        private Label lblToAccType;
        private Label lblMoney;
        private Label lblSender;
        private Label lblReceiver;
    }
}