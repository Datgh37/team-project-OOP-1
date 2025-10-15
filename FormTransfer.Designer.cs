namespace BankManagement
{
    partial class FormTransfer
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
            btnCancel = new Button();
            btnConfirm = new Button();
            txtFromAcc = new TextBox();
            txtAmount = new TextBox();
            txtReceiver = new TextBox();
            txtToAcc = new TextBox();
            txtNotes = new TextBox();
            lblAmount = new Label();
            lblNotes = new Label();
            lblToAcc = new Label();
            lblReceiver = new Label();
            lblFromAcc = new Label();
            lblMoney = new Label();
            lblBalance = new Label();
            lblTransfer = new Label();
            panelTransfer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTransfer
            // 
            panelTransfer.Controls.Add(btnCancel);
            panelTransfer.Controls.Add(btnConfirm);
            panelTransfer.Controls.Add(txtFromAcc);
            panelTransfer.Controls.Add(txtAmount);
            panelTransfer.Controls.Add(txtReceiver);
            panelTransfer.Controls.Add(txtToAcc);
            panelTransfer.Controls.Add(txtNotes);
            panelTransfer.Controls.Add(lblAmount);
            panelTransfer.Controls.Add(lblNotes);
            panelTransfer.Controls.Add(lblToAcc);
            panelTransfer.Controls.Add(lblReceiver);
            panelTransfer.Controls.Add(lblFromAcc);
            panelTransfer.Controls.Add(lblMoney);
            panelTransfer.Controls.Add(lblBalance);
            panelTransfer.Controls.Add(lblTransfer);
            panelTransfer.Dock = DockStyle.Fill;
            panelTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTransfer.Location = new Point(0, 0);
            panelTransfer.Name = "panelTransfer";
            panelTransfer.Size = new Size(780, 524);
            panelTransfer.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(612, 433);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(223, 433);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(128, 36);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtFromAcc
            // 
            txtFromAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFromAcc.Location = new Point(223, 136);
            txtFromAcc.Name = "txtFromAcc";
            txtFromAcc.Size = new Size(517, 33);
            txtFromAcc.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(223, 183);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(517, 33);
            txtAmount.TabIndex = 1;
            // 
            // txtReceiver
            // 
            txtReceiver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceiver.Location = new Point(223, 232);
            txtReceiver.Name = "txtReceiver";
            txtReceiver.Size = new Size(517, 33);
            txtReceiver.TabIndex = 1;
            // 
            // txtToAcc
            // 
            txtToAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToAcc.Location = new Point(223, 288);
            txtToAcc.Name = "txtToAcc";
            txtToAcc.Size = new Size(517, 33);
            txtToAcc.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(223, 339);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(517, 33);
            txtNotes.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(35, 186);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(90, 25);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(35, 342);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(182, 25);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Description (Note):";
            // 
            // lblToAcc
            // 
            lblToAcc.AutoSize = true;
            lblToAcc.Location = new Point(35, 291);
            lblToAcc.Name = "lblToAcc";
            lblToAcc.Size = new Size(117, 25);
            lblToAcc.TabIndex = 0;
            lblToAcc.Text = "To Account:";
            // 
            // lblReceiver
            // 
            lblReceiver.AutoSize = true;
            lblReceiver.Location = new Point(35, 235);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(171, 25);
            lblReceiver.TabIndex = 0;
            lblReceiver.Text = "Receiver Number:";
            // 
            // lblFromAcc
            // 
            lblFromAcc.AutoSize = true;
            lblFromAcc.Location = new Point(35, 139);
            lblFromAcc.Name = "lblFromAcc";
            lblFromAcc.Size = new Size(143, 25);
            lblFromAcc.TabIndex = 0;
            lblFromAcc.Text = "From Account:";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(223, 88);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(70, 25);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "Money";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(35, 88);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(85, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.Location = new Point(337, 34);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(106, 25);
            lblTransfer.TabIndex = 0;
            lblTransfer.Text = "TRANSFER";
            // 
            // FormTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 524);
            Controls.Add(panelTransfer);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTransfer";
            panelTransfer.ResumeLayout(false);
            panelTransfer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTransfer;
        private Label lblFromAcc;
        private Label lblBalance;
        private Label lblTransfer;
        private Label lblAmount;
        private Label lblReceiver;
        private TextBox txtFromAcc;
        private TextBox txtAmount;
        private TextBox txtReceiver;
        private TextBox txtToAcc;
        private TextBox txtNotes;
        private Label lblNotes;
        private Label lblToAcc;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblMoney;
        private Label lblTittle;
    }
}