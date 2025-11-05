namespace BankManagement
{
    partial class FormBill
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
            pnlTittle = new Panel();
            lblTitle = new Label();
            pnlRowTo = new Panel();
            lblToAccNum = new Label();
            lblTo = new Label();
            lblToAcc = new Label();
            pnlRowTID = new Panel();
            lblID = new Label();
            lblTid = new Label();
            pnlRowFrom = new Panel();
            lblFromAccNum = new Label();
            lblFrom = new Label();
            lblFromAcc = new Label();
            pnlRowTTime = new Panel();
            lblTime = new Label();
            lblTtime = new Label();
            pnlRowNote = new Panel();
            lblDescription = new Label();
            lblNotes = new Label();
            pnlRowStatus = new Panel();
            lblSta = new Label();
            lblStatus = new Label();
            pnlRowAmount = new Panel();
            lblMoney = new Label();
            lblAmount = new Label();
            btnFinish = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            pnlRowTType = new Panel();
            lblTransactionType = new Label();
            lblTType = new Label();
            pnlTittle.SuspendLayout();
            pnlRowTo.SuspendLayout();
            pnlRowTID.SuspendLayout();
            pnlRowFrom.SuspendLayout();
            pnlRowTTime.SuspendLayout();
            pnlRowNote.SuspendLayout();
            pnlRowStatus.SuspendLayout();
            pnlRowAmount.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            pnlRowTType.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittle
            // 
            pnlTittle.Controls.Add(lblTitle);
            pnlTittle.Dock = DockStyle.Top;
            pnlTittle.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlTittle.Location = new Point(0, 0);
            pnlTittle.Margin = new Padding(4);
            pnlTittle.Name = "pnlTittle";
            pnlTittle.Size = new Size(907, 108);
            pnlTittle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(305, 38);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANSACTION RECEIPT";
            // 
            // pnlRowTo
            // 
            pnlRowTo.AutoSize = true;
            pnlRowTo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowTo.Controls.Add(lblToAccNum);
            pnlRowTo.Controls.Add(lblTo);
            pnlRowTo.Controls.Add(lblToAcc);
            pnlRowTo.Dock = DockStyle.Top;
            pnlRowTo.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowTo.Location = new Point(3, 89);
            pnlRowTo.Name = "pnlRowTo";
            pnlRowTo.Padding = new Padding(5);
            pnlRowTo.Size = new Size(901, 80);
            pnlRowTo.TabIndex = 4;
            // 
            // lblToAccNum
            // 
            lblToAccNum.AutoSize = true;
            lblToAccNum.Font = new Font("Segoe UI", 12F);
            lblToAccNum.Location = new Point(401, 47);
            lblToAccNum.Margin = new Padding(4, 0, 4, 0);
            lblToAccNum.Name = "lblToAccNum";
            lblToAccNum.RightToLeft = RightToLeft.No;
            lblToAccNum.Size = new Size(161, 28);
            lblToAccNum.TabIndex = 0;
            lblToAccNum.Text = "Account Number";
            lblToAccNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(401, 5);
            lblTo.Margin = new Padding(4, 0, 4, 0);
            lblTo.Name = "lblTo";
            lblTo.RightToLeft = RightToLeft.No;
            lblTo.Size = new Size(133, 32);
            lblTo.TabIndex = 0;
            lblTo.Text = "To Account";
            lblTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblToAcc
            // 
            lblToAcc.AutoSize = true;
            lblToAcc.Location = new Point(294, 4);
            lblToAcc.Margin = new Padding(4, 0, 4, 0);
            lblToAcc.Name = "lblToAcc";
            lblToAcc.Size = new Size(50, 35);
            lblToAcc.TabIndex = 0;
            lblToAcc.Text = "To:";
            lblToAcc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRowTID
            // 
            pnlRowTID.AutoSize = true;
            pnlRowTID.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowTID.Controls.Add(lblID);
            pnlRowTID.Controls.Add(lblTid);
            pnlRowTID.Dock = DockStyle.Top;
            pnlRowTID.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowTID.Location = new Point(3, 379);
            pnlRowTID.Name = "pnlRowTID";
            pnlRowTID.Padding = new Padding(5);
            pnlRowTID.Size = new Size(901, 44);
            pnlRowTID.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(401, 5);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.RightToLeft = RightToLeft.No;
            lblID.Size = new Size(164, 32);
            lblID.TabIndex = 0;
            lblID.Text = "Transaction ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTid
            // 
            lblTid.AutoSize = true;
            lblTid.Location = new Point(155, 4);
            lblTid.Margin = new Padding(4, 0, 4, 0);
            lblTid.Name = "lblTid";
            lblTid.Size = new Size(189, 35);
            lblTid.TabIndex = 0;
            lblTid.Text = "Transaction ID:";
            lblTid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRowFrom
            // 
            pnlRowFrom.AutoSize = true;
            pnlRowFrom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowFrom.Controls.Add(lblFromAccNum);
            pnlRowFrom.Controls.Add(lblFrom);
            pnlRowFrom.Controls.Add(lblFromAcc);
            pnlRowFrom.Dock = DockStyle.Top;
            pnlRowFrom.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowFrom.Location = new Point(3, 3);
            pnlRowFrom.Name = "pnlRowFrom";
            pnlRowFrom.Padding = new Padding(5);
            pnlRowFrom.Size = new Size(901, 80);
            pnlRowFrom.TabIndex = 3;
            // 
            // lblFromAccNum
            // 
            lblFromAccNum.AutoSize = true;
            lblFromAccNum.Font = new Font("Segoe UI", 12F);
            lblFromAccNum.Location = new Point(401, 47);
            lblFromAccNum.Margin = new Padding(4, 0, 4, 0);
            lblFromAccNum.Name = "lblFromAccNum";
            lblFromAccNum.RightToLeft = RightToLeft.No;
            lblFromAccNum.Size = new Size(161, 28);
            lblFromAccNum.TabIndex = 0;
            lblFromAccNum.Text = "Account Number";
            lblFromAccNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(401, 6);
            lblFrom.Margin = new Padding(4, 0, 4, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.RightToLeft = RightToLeft.No;
            lblFrom.Size = new Size(163, 32);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From Account";
            lblFrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFromAcc
            // 
            lblFromAcc.AutoSize = true;
            lblFromAcc.Location = new Point(261, 5);
            lblFromAcc.Margin = new Padding(4, 0, 4, 0);
            lblFromAcc.Name = "lblFromAcc";
            lblFromAcc.Size = new Size(83, 35);
            lblFromAcc.TabIndex = 0;
            lblFromAcc.Text = "From:";
            lblFromAcc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRowTTime
            // 
            pnlRowTTime.AutoSize = true;
            pnlRowTTime.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowTTime.Controls.Add(lblTime);
            pnlRowTTime.Controls.Add(lblTtime);
            pnlRowTTime.Dock = DockStyle.Top;
            pnlRowTTime.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowTTime.Location = new Point(3, 226);
            pnlRowTTime.Name = "pnlRowTTime";
            pnlRowTTime.Padding = new Padding(5);
            pnlRowTTime.Size = new Size(901, 45);
            pnlRowTTime.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(401, 6);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(189, 32);
            lblTime.TabIndex = 0;
            lblTime.Text = "Transaction time";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTtime
            // 
            lblTtime.AutoSize = true;
            lblTtime.Location = new Point(122, 5);
            lblTtime.Margin = new Padding(4, 0, 4, 0);
            lblTtime.Name = "lblTtime";
            lblTtime.Size = new Size(222, 35);
            lblTtime.TabIndex = 0;
            lblTtime.Text = "Transaction Time:";
            lblTtime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRowNote
            // 
            pnlRowNote.AutoSize = true;
            pnlRowNote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowNote.Controls.Add(lblDescription);
            pnlRowNote.Controls.Add(lblNotes);
            pnlRowNote.Dock = DockStyle.Top;
            pnlRowNote.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowNote.Location = new Point(3, 429);
            pnlRowNote.Name = "pnlRowNote";
            pnlRowNote.Padding = new Padding(5);
            pnlRowNote.Size = new Size(901, 45);
            pnlRowNote.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(401, 6);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.RightToLeft = RightToLeft.No;
            lblDescription.Size = new Size(67, 32);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Note";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(263, 5);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(81, 35);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Note:";
            lblNotes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRowStatus
            // 
            pnlRowStatus.AutoSize = true;
            pnlRowStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowStatus.Controls.Add(lblSta);
            pnlRowStatus.Controls.Add(lblStatus);
            pnlRowStatus.Dock = DockStyle.Top;
            pnlRowStatus.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowStatus.Location = new Point(3, 328);
            pnlRowStatus.Name = "pnlRowStatus";
            pnlRowStatus.Padding = new Padding(5);
            pnlRowStatus.Size = new Size(901, 45);
            pnlRowStatus.TabIndex = 7;
            // 
            // lblSta
            // 
            lblSta.AutoSize = true;
            lblSta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSta.Location = new Point(401, 6);
            lblSta.Margin = new Padding(4, 0, 4, 0);
            lblSta.Name = "lblSta";
            lblSta.RightToLeft = RightToLeft.No;
            lblSta.Size = new Size(78, 32);
            lblSta.TabIndex = 0;
            lblSta.Text = "Status";
            lblSta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(250, 5);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 35);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRowAmount
            // 
            pnlRowAmount.AutoSize = true;
            pnlRowAmount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowAmount.Controls.Add(lblMoney);
            pnlRowAmount.Controls.Add(lblAmount);
            pnlRowAmount.Dock = DockStyle.Top;
            pnlRowAmount.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowAmount.Location = new Point(3, 175);
            pnlRowAmount.Name = "pnlRowAmount";
            pnlRowAmount.Padding = new Padding(5);
            pnlRowAmount.Size = new Size(901, 45);
            pnlRowAmount.TabIndex = 8;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(401, 6);
            lblMoney.Margin = new Padding(4, 0, 4, 0);
            lblMoney.Name = "lblMoney";
            lblMoney.RightToLeft = RightToLeft.No;
            lblMoney.Size = new Size(100, 32);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "Amount";
            lblMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(226, 5);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(118, 35);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            btnFinish.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            btnFinish.Location = new Point(372, 624);
            btnFinish.Margin = new Padding(4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(132, 46);
            btnFinish.TabIndex = 1;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(pnlRowFrom, 0, 0);
            tableLayoutPanel.Controls.Add(pnlRowTo, 0, 1);
            tableLayoutPanel.Controls.Add(pnlRowAmount, 0, 2);
            tableLayoutPanel.Controls.Add(pnlRowTTime, 0, 3);
            tableLayoutPanel.Controls.Add(pnlRowTType, 0, 4);
            tableLayoutPanel.Controls.Add(pnlRowStatus, 0, 5);
            tableLayoutPanel.Controls.Add(pnlRowTID, 0, 6);
            tableLayoutPanel.Controls.Add(pnlRowNote, 0, 7);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 108);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 8;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(907, 491);
            tableLayoutPanel.TabIndex = 11;
            // 
            // pnlRowTType
            // 
            pnlRowTType.AutoSize = true;
            pnlRowTType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRowTType.Controls.Add(lblTransactionType);
            pnlRowTType.Controls.Add(lblTType);
            pnlRowTType.Dock = DockStyle.Top;
            pnlRowTType.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlRowTType.Location = new Point(3, 277);
            pnlRowTType.Name = "pnlRowTType";
            pnlRowTType.Padding = new Padding(5);
            pnlRowTType.Size = new Size(901, 45);
            pnlRowTType.TabIndex = 5;
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionType.Location = new Point(401, 6);
            lblTransactionType.Margin = new Padding(4, 0, 4, 0);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.RightToLeft = RightToLeft.No;
            lblTransactionType.Size = new Size(192, 32);
            lblTransactionType.TabIndex = 0;
            lblTransactionType.Text = "Transaction Type";
            lblTransactionType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTType
            // 
            lblTType.AutoSize = true;
            lblTType.Location = new Point(122, 5);
            lblTType.Margin = new Padding(4, 0, 4, 0);
            lblTType.Name = "lblTType";
            lblTType.Size = new Size(220, 35);
            lblTType.TabIndex = 0;
            lblTType.Text = "Transaction Type:";
            lblTType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBill
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 707);
            Controls.Add(btnFinish);
            Controls.Add(tableLayoutPanel);
            Controls.Add(pnlTittle);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBill";
            Load += FormBill_Load;
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
            pnlRowTo.ResumeLayout(false);
            pnlRowTo.PerformLayout();
            pnlRowTID.ResumeLayout(false);
            pnlRowTID.PerformLayout();
            pnlRowFrom.ResumeLayout(false);
            pnlRowFrom.PerformLayout();
            pnlRowTTime.ResumeLayout(false);
            pnlRowTTime.PerformLayout();
            pnlRowNote.ResumeLayout(false);
            pnlRowNote.PerformLayout();
            pnlRowStatus.ResumeLayout(false);
            pnlRowStatus.PerformLayout();
            pnlRowAmount.ResumeLayout(false);
            pnlRowAmount.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            pnlRowTType.ResumeLayout(false);
            pnlRowTType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTittle;
        private Label lblTitle;
        private Panel pnlRowFrom;
        private Label lblFromAccNum;
        private Label lblFrom;
        private Label lblFromAcc;
        private Panel pnlRowTo;
        private Label lblToAccNum;
        private Label lblTo;
        private Label lblToAcc;
        private Panel pnlRowAmount;
        private Label lblMoney;
        private Label lblAmount;
        private Panel pnlRowTTime;
        private Label lblTime;
        private Label lblTtime;
        private Panel pnlRowTType;
        private Label lblTransactionType;
        private Label lblTType;
        private Panel pnlRowStatus;
        private Label lblSta;
        private Label lblStatus;
        private Panel pnlRowTID;
        private Label lblID;
        private Label lblTid;
        private Panel pnlRowNote;
        private Label lblDescription;
        private Label lblNotes;
        private Button btnFinish;
        private TableLayoutPanel tableLayoutPanel;
    }
}