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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
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
            pnlButton = new Panel();
            panelBase = new Panel();
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
            pnlButton.SuspendLayout();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittle
            // 
            pnlTittle.BackColor = Color.FromArgb(221, 221, 235);
            pnlTittle.Controls.Add(lblTitle);
            pnlTittle.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            pnlTittle.Location = new Point(6, 6);
            pnlTittle.Name = "pnlTittle";
            pnlTittle.Size = new Size(705, 77);
            pnlTittle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(237, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(236, 28);
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
            pnlRowTo.Location = new Point(2, 65);
            pnlRowTo.Margin = new Padding(2, 2, 2, 2);
            pnlRowTo.Name = "pnlRowTo";
            pnlRowTo.Padding = new Padding(4, 4, 4, 4);
            pnlRowTo.Size = new Size(701, 59);
            pnlRowTo.TabIndex = 4;
            // 
            // lblToAccNum
            // 
            lblToAccNum.AutoSize = true;
            lblToAccNum.Font = new Font("Segoe UI", 12F);
            lblToAccNum.Location = new Point(312, 34);
            lblToAccNum.Name = "lblToAccNum";
            lblToAccNum.RightToLeft = RightToLeft.No;
            lblToAccNum.Size = new Size(128, 21);
            lblToAccNum.TabIndex = 0;
            lblToAccNum.Text = "Account Number";
            lblToAccNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(312, 4);
            lblTo.Name = "lblTo";
            lblTo.RightToLeft = RightToLeft.No;
            lblTo.Size = new Size(105, 25);
            lblTo.TabIndex = 0;
            lblTo.Text = "To Account";
            lblTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblToAcc
            // 
            lblToAcc.AutoSize = true;
            lblToAcc.Location = new Point(229, 3);
            lblToAcc.Name = "lblToAcc";
            lblToAcc.Size = new Size(39, 28);
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
            pnlRowTID.Location = new Point(2, 288);
            pnlRowTID.Margin = new Padding(2, 2, 2, 2);
            pnlRowTID.Name = "pnlRowTID";
            pnlRowTID.Padding = new Padding(4, 4, 4, 4);
            pnlRowTID.Size = new Size(701, 35);
            pnlRowTID.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(312, 4);
            lblID.Name = "lblID";
            lblID.RightToLeft = RightToLeft.No;
            lblID.Size = new Size(131, 25);
            lblID.TabIndex = 0;
            lblID.Text = "Transaction ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTid
            // 
            lblTid.AutoSize = true;
            lblTid.Location = new Point(121, 3);
            lblTid.Name = "lblTid";
            lblTid.Size = new Size(153, 28);
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
            pnlRowFrom.Location = new Point(2, 2);
            pnlRowFrom.Margin = new Padding(2, 2, 2, 2);
            pnlRowFrom.Name = "pnlRowFrom";
            pnlRowFrom.Padding = new Padding(4, 4, 4, 4);
            pnlRowFrom.Size = new Size(701, 59);
            pnlRowFrom.TabIndex = 3;
            // 
            // lblFromAccNum
            // 
            lblFromAccNum.AutoSize = true;
            lblFromAccNum.Font = new Font("Segoe UI", 12F);
            lblFromAccNum.Location = new Point(312, 34);
            lblFromAccNum.Name = "lblFromAccNum";
            lblFromAccNum.RightToLeft = RightToLeft.No;
            lblFromAccNum.Size = new Size(128, 21);
            lblFromAccNum.TabIndex = 0;
            lblFromAccNum.Text = "Account Number";
            lblFromAccNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(312, 4);
            lblFrom.Name = "lblFrom";
            lblFrom.RightToLeft = RightToLeft.No;
            lblFrom.Size = new Size(129, 25);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From Account";
            lblFrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFromAcc
            // 
            lblFromAcc.AutoSize = true;
            lblFromAcc.Location = new Point(203, 4);
            lblFromAcc.Name = "lblFromAcc";
            lblFromAcc.Size = new Size(65, 28);
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
            pnlRowTTime.Location = new Point(2, 168);
            pnlRowTTime.Margin = new Padding(2, 2, 2, 2);
            pnlRowTTime.Name = "pnlRowTTime";
            pnlRowTTime.Padding = new Padding(4, 4, 4, 4);
            pnlRowTTime.Size = new Size(701, 36);
            pnlRowTTime.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(312, 4);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(150, 25);
            lblTime.TabIndex = 0;
            lblTime.Text = "Transaction time";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTtime
            // 
            lblTtime.AutoSize = true;
            lblTtime.Location = new Point(95, 4);
            lblTtime.Name = "lblTtime";
            lblTtime.Size = new Size(179, 28);
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
            pnlRowNote.Location = new Point(2, 327);
            pnlRowNote.Margin = new Padding(2, 2, 2, 2);
            pnlRowNote.Name = "pnlRowNote";
            pnlRowNote.Padding = new Padding(4, 4, 4, 4);
            pnlRowNote.Size = new Size(701, 36);
            pnlRowNote.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(312, 4);
            lblDescription.Name = "lblDescription";
            lblDescription.RightToLeft = RightToLeft.No;
            lblDescription.Size = new Size(53, 25);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Note";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(205, 4);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(64, 28);
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
            pnlRowStatus.Location = new Point(2, 248);
            pnlRowStatus.Margin = new Padding(2, 2, 2, 2);
            pnlRowStatus.Name = "pnlRowStatus";
            pnlRowStatus.Padding = new Padding(4, 4, 4, 4);
            pnlRowStatus.Size = new Size(701, 36);
            pnlRowStatus.TabIndex = 7;
            // 
            // lblSta
            // 
            lblSta.AutoSize = true;
            lblSta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSta.Location = new Point(312, 4);
            lblSta.Name = "lblSta";
            lblSta.RightToLeft = RightToLeft.No;
            lblSta.Size = new Size(62, 25);
            lblSta.TabIndex = 0;
            lblSta.Text = "Status";
            lblSta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(194, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(76, 28);
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
            pnlRowAmount.Location = new Point(2, 128);
            pnlRowAmount.Margin = new Padding(2, 2, 2, 2);
            pnlRowAmount.Name = "pnlRowAmount";
            pnlRowAmount.Padding = new Padding(4, 4, 4, 4);
            pnlRowAmount.Size = new Size(701, 36);
            pnlRowAmount.TabIndex = 8;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(312, 4);
            lblMoney.Name = "lblMoney";
            lblMoney.RightToLeft = RightToLeft.No;
            lblMoney.Size = new Size(79, 25);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "Amount";
            lblMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(176, 4);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(93, 28);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            btnFinish.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            btnFinish.Location = new Point(304, 16);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(103, 35);
            btnFinish.TabIndex = 1;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.FromArgb(221, 221, 235);
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
            tableLayoutPanel.Controls.Add(pnlButton, 0, 8);
            tableLayoutPanel.Location = new Point(6, 86);
            tableLayoutPanel.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(705, 446);
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
            pnlRowTType.Location = new Point(2, 208);
            pnlRowTType.Margin = new Padding(2, 2, 2, 2);
            pnlRowTType.Name = "pnlRowTType";
            pnlRowTType.Padding = new Padding(4, 4, 4, 4);
            pnlRowTType.Size = new Size(701, 36);
            pnlRowTType.TabIndex = 5;
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionType.Location = new Point(312, 4);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.RightToLeft = RightToLeft.No;
            lblTransactionType.Size = new Size(152, 25);
            lblTransactionType.TabIndex = 0;
            lblTransactionType.Text = "Transaction Type";
            lblTransactionType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTType
            // 
            lblTType.AutoSize = true;
            lblTType.Location = new Point(95, 4);
            lblTType.Name = "lblTType";
            lblTType.Size = new Size(177, 28);
            lblTType.TabIndex = 0;
            lblTType.Text = "Transaction Type:";
            lblTType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlButton
            // 
            pnlButton.AutoSize = true;
            pnlButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlButton.Controls.Add(btnFinish);
            pnlButton.Dock = DockStyle.Fill;
            pnlButton.Location = new Point(2, 367);
            pnlButton.Margin = new Padding(2, 2, 2, 2);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(701, 77);
            pnlButton.TabIndex = 9;
            // 
            // panelBase
            // 
            panelBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBase.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBase.BackColor = Color.FromArgb(157, 157, 194);
            panelBase.Controls.Add(pnlTittle);
            panelBase.Controls.Add(tableLayoutPanel);
            panelBase.Location = new Point(0, 0);
            panelBase.Margin = new Padding(2, 2, 2, 2);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(717, 541);
            panelBase.TabIndex = 12;
            // 
            // FormBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 221, 235);
            ClientSize = new Size(717, 541);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            pnlButton.ResumeLayout(false);
            panelBase.ResumeLayout(false);
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
        private Panel panelBase;
        private Panel pnlButton;
    }
}