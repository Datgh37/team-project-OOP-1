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
            lblTransactionType = new Label();
            panel1 = new Panel();
            panelTransfer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTransfer
            // 
            panelTransfer.BackColor = Color.FromArgb(221, 221, 235);
            panelTransfer.Controls.Add(panel1);
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
            panelTransfer.Location = new Point(12, 12);
            panelTransfer.Name = "panelTransfer";
            panelTransfer.Size = new Size(573, 536);
            panelTransfer.TabIndex = 0;
            // 
            // radWithdraw
            // 
            radWithdraw.AutoSize = true;
            radWithdraw.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            radWithdraw.Location = new Point(12, 71);
            radWithdraw.Margin = new Padding(2);
            radWithdraw.Name = "radWithdraw";
            radWithdraw.Size = new Size(113, 29);
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
            radDeposit.Location = new Point(12, 38);
            radDeposit.Margin = new Padding(2);
            radDeposit.Name = "radDeposit";
            radDeposit.Size = new Size(95, 29);
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
            radTransfer.Location = new Point(12, 5);
            radTransfer.Margin = new Padding(2);
            radTransfer.Name = "radTransfer";
            radTransfer.Size = new Size(100, 29);
            radTransfer.TabIndex = 3;
            radTransfer.TabStop = true;
            radTransfer.Text = "Transfer";
            radTransfer.UseVisualStyleBackColor = true;
            radTransfer.CheckedChanged += radTransfer_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(118, 477);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(128, 36);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtFromAcc
            // 
            txtFromAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFromAcc.Location = new Point(35, 149);
            txtFromAcc.Name = "txtFromAcc";
            txtFromAcc.Size = new Size(203, 33);
            txtFromAcc.TabIndex = 1;
            txtFromAcc.TextChanged += txtFromAcc_TextChanged;
            txtFromAcc.Leave += txtFromAcc_Leave;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(35, 245);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(270, 33);
            txtAmount.TabIndex = 1;
            // 
            // txtToAcc
            // 
            txtToAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToAcc.Location = new Point(325, 149);
            txtToAcc.Name = "txtToAcc";
            txtToAcc.Size = new Size(203, 33);
            txtToAcc.TabIndex = 1;
            txtToAcc.TextChanged += txtToAcc_TextChanged;
            txtToAcc.Leave += txtToAcc_Leave;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(35, 370);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(493, 82);
            txtNotes.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAmount.Location = new Point(35, 225);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 17);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNotes.Location = new Point(35, 350);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(127, 17);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Description (Note):";
            // 
            // lblToAcc
            // 
            lblToAcc.AutoSize = true;
            lblToAcc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblToAcc.Location = new Point(325, 129);
            lblToAcc.Name = "lblToAcc";
            lblToAcc.Size = new Size(81, 17);
            lblToAcc.TabIndex = 0;
            lblToAcc.Text = "To Account:";
            lblToAcc.Click += lblToAcc_Click;
            // 
            // lblFromAcc
            // 
            lblFromAcc.AutoSize = true;
            lblFromAcc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFromAcc.Location = new Point(35, 129);
            lblFromAcc.Name = "lblFromAcc";
            lblFromAcc.Size = new Size(98, 17);
            lblFromAcc.TabIndex = 0;
            lblFromAcc.Text = "From Account:";
            // 
            // lblToAccType
            // 
            lblToAccType.AutoSize = true;
            lblToAccType.Font = new Font("Segoe UI", 13.25F);
            lblToAccType.Location = new Point(325, 185);
            lblToAccType.Name = "lblToAccType";
            lblToAccType.Size = new Size(16, 25);
            lblToAccType.TabIndex = 0;
            lblToAccType.Text = ".";
            lblToAccType.Click += lblToAccType_Click;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(139, 88);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(22, 25);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "0";
            // 
            // lblReceiver
            // 
            lblReceiver.AutoSize = true;
            lblReceiver.Font = new Font("Segoe UI", 13.25F);
            lblReceiver.Location = new Point(412, 123);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(16, 25);
            lblReceiver.TabIndex = 0;
            lblReceiver.Text = ".";
            lblReceiver.Click += lblReceiver_Click;
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            lblSender.Font = new Font("Segoe UI", 13.25F);
            lblSender.Location = new Point(139, 123);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(16, 25);
            lblSender.TabIndex = 0;
            lblSender.Text = ".";
            // 
            // lblFromAccType
            // 
            lblFromAccType.AutoSize = true;
            lblFromAccType.Font = new Font("Segoe UI", 13.25F);
            lblFromAccType.Location = new Point(35, 185);
            lblFromAccType.Name = "lblFromAccType";
            lblFromAccType.Size = new Size(16, 25);
            lblFromAccType.TabIndex = 0;
            lblFromAccType.Text = ".";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(35, 88);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(84, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(213, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANSFER";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionType.Location = new Point(373, 206);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(116, 17);
            lblTransactionType.TabIndex = 0;
            lblTransactionType.Text = "Transaction Type:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(radTransfer);
            panel1.Controls.Add(radWithdraw);
            panel1.Controls.Add(radDeposit);
            panel1.Location = new Point(377, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 108);
            panel1.TabIndex = 4;
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 157, 194);
            ClientSize = new Size(597, 560);
            Controls.Add(panelTransfer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTransfer";
            Load += FormTransfer_Load;
            panelTransfer.ResumeLayout(false);
            panelTransfer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private RadioButton radWithdraw;
        private RadioButton radDeposit;
        private Label lblToAccType;
        private Label lblMoney;
        private Label lblSender;
        private Label lblReceiver;
        private Panel panel1;
        private Label lblTransactionType;
    }
}