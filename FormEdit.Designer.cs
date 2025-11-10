namespace BankManagement
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            panelBase = new Panel();
            label2 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            cboGender = new ComboBox();
            dtpDoB = new DateTimePicker();
            txtInterestRate = new TextBox();
            txtBalance = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            txtCID = new TextBox();
            txtUID = new TextBox();
            txtFirstName = new TextBox();
            lblGender = new Label();
            lblDoB = new Label();
            lblCID = new Label();
            lblInterestRate = new Label();
            lblAccTypeInfo = new Label();
            label1 = new Label();
            lblAccType = new Label();
            lblBalance = new Label();
            lblUID = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(221, 221, 235);
            panelBase.Controls.Add(label2);
            panelBase.Controls.Add(btnCancel);
            panelBase.Controls.Add(btnEdit);
            panelBase.Controls.Add(cboGender);
            panelBase.Controls.Add(dtpDoB);
            panelBase.Controls.Add(txtInterestRate);
            panelBase.Controls.Add(txtBalance);
            panelBase.Controls.Add(txtEmail);
            panelBase.Controls.Add(txtPhone);
            panelBase.Controls.Add(txtAddress);
            panelBase.Controls.Add(txtLastName);
            panelBase.Controls.Add(txtCID);
            panelBase.Controls.Add(txtUID);
            panelBase.Controls.Add(txtFirstName);
            panelBase.Controls.Add(lblGender);
            panelBase.Controls.Add(lblDoB);
            panelBase.Controls.Add(lblCID);
            panelBase.Controls.Add(lblInterestRate);
            panelBase.Controls.Add(lblAccTypeInfo);
            panelBase.Controls.Add(label1);
            panelBase.Controls.Add(lblAccType);
            panelBase.Controls.Add(lblBalance);
            panelBase.Controls.Add(lblUID);
            panelBase.Controls.Add(lblEmail);
            panelBase.Controls.Add(lblPhone);
            panelBase.Controls.Add(lblAddress);
            panelBase.Controls.Add(lblLastName);
            panelBase.Controls.Add(lblFirstName);
            panelBase.Location = new Point(15, 17);
            panelBase.Margin = new Padding(4);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(775, 1099);
            panelBase.TabIndex = 0;
            panelBase.Paint += panelBase_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(300, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 46);
            label2.TabIndex = 5;
            label2.Text = "Edit Profile";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(393, 983);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(184, 983);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(456, 381);
            cboGender.Margin = new Padding(4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(181, 40);
            cboGender.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.CustomFormat = "dd/MM/yyyy";
            dtpDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDoB.Format = DateTimePickerFormat.Custom;
            dtpDoB.Location = new Point(456, 459);
            dtpDoB.Margin = new Padding(4);
            dtpDoB.MaxDate = new DateTime(2025, 11, 5, 0, 0, 0, 0);
            dtpDoB.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(181, 39);
            dtpDoB.TabIndex = 2;
            dtpDoB.Value = new DateTime(2025, 11, 5, 0, 0, 0, 0);
            // 
            // txtInterestRate
            // 
            txtInterestRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInterestRate.Location = new Point(456, 760);
            txtInterestRate.Margin = new Padding(4);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(139, 39);
            txtInterestRate.TabIndex = 1;
            txtInterestRate.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(98, 801);
            txtBalance.Margin = new Padding(4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(217, 39);
            txtBalance.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(98, 672);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 39);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(456, 587);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(181, 39);
            txtPhone.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(98, 587);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(271, 39);
            txtAddress.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(98, 463);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(156, 39);
            txtLastName.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCID.Location = new Point(150, 248);
            txtCID.Margin = new Padding(4);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(490, 39);
            txtCID.TabIndex = 1;
            // 
            // txtUID
            // 
            txtUID.Enabled = false;
            txtUID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUID.Location = new Point(150, 179);
            txtUID.Margin = new Padding(4);
            txtUID.Name = "txtUID";
            txtUID.ReadOnly = true;
            txtUID.Size = new Size(490, 39);
            txtUID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(98, 382);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(156, 39);
            txtFirstName.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblGender.Location = new Point(456, 353);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 23);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDoB.Location = new Point(456, 431);
            lblDoB.Margin = new Padding(4, 0, 4, 0);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(55, 23);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Birth:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCID.Location = new Point(98, 260);
            lblCID.Margin = new Padding(4, 0, 4, 0);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(44, 23);
            lblCID.TabIndex = 0;
            lblCID.Text = "CID:";
            // 
            // lblInterestRate
            // 
            lblInterestRate.AutoSize = true;
            lblInterestRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblInterestRate.Location = new Point(456, 732);
            lblInterestRate.Margin = new Padding(4, 0, 4, 0);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(117, 23);
            lblInterestRate.TabIndex = 0;
            lblInterestRate.Text = "Interest Rate:";
            // 
            // lblAccTypeInfo
            // 
            lblAccTypeInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccTypeInfo.Location = new Point(428, 878);
            lblAccTypeInfo.Margin = new Padding(4, 0, 4, 0);
            lblAccTypeInfo.Name = "lblAccTypeInfo";
            lblAccTypeInfo.Size = new Size(184, 32);
            lblAccTypeInfo.TabIndex = 0;
            lblAccTypeInfo.Text = "/";
            lblAccTypeInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(599, 763);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 32);
            label1.TabIndex = 0;
            label1.Text = "%";
            // 
            // lblAccType
            // 
            lblAccType.AutoSize = true;
            lblAccType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAccType.Location = new Point(456, 837);
            lblAccType.Margin = new Padding(4, 0, 4, 0);
            lblAccType.Name = "lblAccType";
            lblAccType.Size = new Size(128, 23);
            lblAccType.TabIndex = 0;
            lblAccType.Text = "Account Type: ";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblBalance.Location = new Point(98, 773);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(76, 23);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblUID.Location = new Point(98, 192);
            lblUID.Margin = new Padding(4, 0, 4, 0);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(45, 23);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(98, 644);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPhone.Location = new Point(456, 559);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(64, 23);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAddress.Location = new Point(98, 559);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 23);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblLastName.Location = new Point(100, 435);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 23);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFirstName.Location = new Point(98, 354);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // FormEdit
            // 
            AcceptButton = btnEdit;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 157, 194);
            ClientSize = new Size(806, 1133);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            Load += FormEdit_Load;
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBase;
        private Label lblUID;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtUID;
        private Label lblCID;
        private ComboBox cboGender;
        private DateTimePicker dtpDoB;
        private TextBox txtCID;
        private Label lblGender;
        private Label lblDoB;
        private Button btnEdit;
        private TextBox txtBalance;
        private Label lblBalance;
        private TextBox txtInterestRate;
        private Label lblInterestRate;
        private Label lblAccType;
        private Label lblAccTypeInfo;
        private Label label1;
        private Button btnCancel;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private Label label2;
    }
}