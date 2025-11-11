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
            panelContent = new Panel();
            grpActions = new GroupBox();
            btnCancel = new Button();
            btnEdit = new Button();
            lblTitle = new Label();
            grpAccountInfo = new GroupBox();
            lblAccTypeInfo = new Label();
            lblInterestRatePercentage = new Label();
            txtInterestRate = new TextBox();
            txtBalance = new TextBox();
            lblAccType = new Label();
            lblInterestRate = new Label();
            lblBalance = new Label();
            grpCustomerInfo = new GroupBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            dtpDoB = new DateTimePicker();
            lblDoB = new Label();
            cboGender = new ComboBox();
            lblGender = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtCID = new TextBox();
            lblCID = new Label();
            txtUID = new TextBox();
            lblUID = new Label();
            panelBase.SuspendLayout();
            panelContent.SuspendLayout();
            grpActions.SuspendLayout();
            grpAccountInfo.SuspendLayout();
            grpCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(157, 157, 194);
            panelBase.Controls.Add(panelContent);
            panelBase.Dock = DockStyle.Fill;
            panelBase.Location = new Point(0, 0);
            panelBase.Name = "panelBase";
            panelBase.Padding = new Padding(16, 14, 16, 14);
            panelBase.Size = new Size(665, 630);
            panelBase.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.BackColor = Color.FromArgb(221, 221, 235);
            panelContent.Controls.Add(grpActions);
            panelContent.Controls.Add(lblTitle);
            panelContent.Controls.Add(grpAccountInfo);
            panelContent.Controls.Add(grpCustomerInfo);
            panelContent.Location = new Point(10, 9);
            panelContent.Margin = new Padding(2, 2, 2, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(646, 612);
            panelContent.TabIndex = 6;
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpActions.Controls.Add(btnCancel);
            grpActions.Controls.Add(btnEdit);
            grpActions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpActions.ForeColor = Color.FromArgb(50, 52, 76);
            grpActions.Location = new Point(12, 517);
            grpActions.Name = "grpActions";
            grpActions.Padding = new Padding(16, 7, 16, 11);
            grpActions.Size = new Size(622, 81);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "⚡ Actions";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.FromArgb(220, 220, 235);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(67, 69, 94);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(50, 52, 76);
            btnCancel.Location = new Point(325, 32);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 39);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "✖ CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.BackColor = Color.FromArgb(67, 69, 94);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(150, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 39);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "✓ SAVE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(50, 52, 76);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(646, 59);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Edit Profile";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpAccountInfo
            // 
            grpAccountInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAccountInfo.Controls.Add(lblAccTypeInfo);
            grpAccountInfo.Controls.Add(lblInterestRatePercentage);
            grpAccountInfo.Controls.Add(txtInterestRate);
            grpAccountInfo.Controls.Add(txtBalance);
            grpAccountInfo.Controls.Add(lblAccType);
            grpAccountInfo.Controls.Add(lblInterestRate);
            grpAccountInfo.Controls.Add(lblBalance);
            grpAccountInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAccountInfo.ForeColor = Color.FromArgb(50, 52, 76);
            grpAccountInfo.Location = new Point(12, 412);
            grpAccountInfo.Name = "grpAccountInfo";
            grpAccountInfo.Padding = new Padding(23, 7, 23, 14);
            grpAccountInfo.Size = new Size(622, 94);
            grpAccountInfo.TabIndex = 1;
            grpAccountInfo.TabStop = false;
            grpAccountInfo.Text = " Account Information";
            // 
            // lblAccTypeInfo
            // 
            lblAccTypeInfo.AutoSize = true;
            lblAccTypeInfo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccTypeInfo.ForeColor = Color.FromArgb(67, 69, 94);
            lblAccTypeInfo.Location = new Point(455, 48);
            lblAccTypeInfo.Name = "lblAccTypeInfo";
            lblAccTypeInfo.Size = new Size(20, 25);
            lblAccTypeInfo.TabIndex = 6;
            lblAccTypeInfo.Text = "/";
            // 
            // lblInterestRatePercentage
            // 
            lblInterestRatePercentage.AutoSize = true;
            lblInterestRatePercentage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterestRatePercentage.ForeColor = Color.FromArgb(50, 52, 76);
            lblInterestRatePercentage.Location = new Point(401, 49);
            lblInterestRatePercentage.Name = "lblInterestRatePercentage";
            lblInterestRatePercentage.Size = new Size(23, 21);
            lblInterestRatePercentage.TabIndex = 5;
            lblInterestRatePercentage.Text = "%";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Font = new Font("Microsoft Sans Serif", 12F);
            txtInterestRate.Location = new Point(325, 48);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(70, 26);
            txtInterestRate.TabIndex = 1;
            txtInterestRate.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Microsoft Sans Serif", 12F);
            txtBalance.Location = new Point(55, 48);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(219, 26);
            txtBalance.TabIndex = 0;
            // 
            // lblAccType
            // 
            lblAccType.AutoSize = true;
            lblAccType.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAccType.ForeColor = Color.FromArgb(50, 52, 76);
            lblAccType.Location = new Point(455, 26);
            lblAccType.Name = "lblAccType";
            lblAccType.Size = new Size(103, 19);
            lblAccType.TabIndex = 4;
            lblAccType.Text = "Account Type:";
            // 
            // lblInterestRate
            // 
            lblInterestRate.AutoSize = true;
            lblInterestRate.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblInterestRate.ForeColor = Color.FromArgb(50, 52, 76);
            lblInterestRate.Location = new Point(325, 26);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(97, 19);
            lblInterestRate.TabIndex = 3;
            lblInterestRate.Text = "Interest Rate:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBalance.ForeColor = Color.FromArgb(50, 52, 76);
            lblBalance.Location = new Point(55, 26);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(65, 19);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance:";
            // 
            // grpCustomerInfo
            // 
            grpCustomerInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCustomerInfo.Controls.Add(txtPhone);
            grpCustomerInfo.Controls.Add(lblPhone);
            grpCustomerInfo.Controls.Add(txtEmail);
            grpCustomerInfo.Controls.Add(lblEmail);
            grpCustomerInfo.Controls.Add(dtpDoB);
            grpCustomerInfo.Controls.Add(lblDoB);
            grpCustomerInfo.Controls.Add(cboGender);
            grpCustomerInfo.Controls.Add(lblGender);
            grpCustomerInfo.Controls.Add(txtAddress);
            grpCustomerInfo.Controls.Add(lblAddress);
            grpCustomerInfo.Controls.Add(txtLastName);
            grpCustomerInfo.Controls.Add(lblLastName);
            grpCustomerInfo.Controls.Add(txtFirstName);
            grpCustomerInfo.Controls.Add(lblFirstName);
            grpCustomerInfo.Controls.Add(txtCID);
            grpCustomerInfo.Controls.Add(lblCID);
            grpCustomerInfo.Controls.Add(txtUID);
            grpCustomerInfo.Controls.Add(lblUID);
            grpCustomerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCustomerInfo.ForeColor = Color.FromArgb(50, 52, 76);
            grpCustomerInfo.Location = new Point(12, 61);
            grpCustomerInfo.Name = "grpCustomerInfo";
            grpCustomerInfo.Padding = new Padding(23, 7, 23, 14);
            grpCustomerInfo.Size = new Size(622, 339);
            grpCustomerInfo.TabIndex = 0;
            grpCustomerInfo.TabStop = false;
            grpCustomerInfo.Text = " Customer Information";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhone.Location = new Point(364, 284);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 26);
            txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(50, 52, 76);
            lblPhone.Location = new Point(364, 262);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(55, 19);
            lblPhone.TabIndex = 17;
            lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(55, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 26);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(50, 52, 76);
            lblEmail.Location = new Point(55, 262);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email:";
            // 
            // dtpDoB
            // 
            dtpDoB.CustomFormat = "dd/MM/yyyy";
            dtpDoB.Font = new Font("Microsoft Sans Serif", 12F);
            dtpDoB.Format = DateTimePickerFormat.Custom;
            dtpDoB.Location = new Point(364, 167);
            dtpDoB.MaxDate = new DateTime(2025, 11, 5, 0, 0, 0, 0);
            dtpDoB.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(200, 26);
            dtpDoB.TabIndex = 7;
            dtpDoB.Value = new DateTime(2025, 11, 5, 0, 0, 0, 0);
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDoB.ForeColor = Color.FromArgb(50, 52, 76);
            lblDoB.Location = new Point(364, 146);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(80, 19);
            lblDoB.TabIndex = 13;
            lblDoB.Text = "Birth Date:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Microsoft Sans Serif", 12F);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(55, 167);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(93, 28);
            cboGender.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(50, 52, 76);
            lblGender.Location = new Point(55, 146);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 19);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 12F);
            txtAddress.Location = new Point(55, 226);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(509, 26);
            txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(50, 52, 76);
            lblAddress.Location = new Point(55, 204);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(67, 19);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName.Location = new Point(364, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 26);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(50, 52, 76);
            lblLastName.Location = new Point(364, 89);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(83, 19);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F);
            txtFirstName.Location = new Point(55, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(238, 26);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(50, 52, 76);
            lblFirstName.Location = new Point(55, 89);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(85, 19);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Microsoft Sans Serif", 12F);
            txtCID.Location = new Point(376, 54);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(188, 26);
            txtCID.TabIndex = 2;
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblCID.ForeColor = Color.FromArgb(50, 52, 76);
            lblCID.Location = new Point(376, 32);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(113, 19);
            lblCID.TabIndex = 3;
            lblCID.Text = "Citizen ID (CID):";
            // 
            // txtUID
            // 
            txtUID.BackColor = Color.FromArgb(240, 240, 250);
            txtUID.Enabled = false;
            txtUID.Font = new Font("Microsoft Sans Serif", 12F);
            txtUID.ForeColor = Color.FromArgb(67, 69, 94);
            txtUID.Location = new Point(55, 54);
            txtUID.Name = "txtUID";
            txtUID.ReadOnly = true;
            txtUID.Size = new Size(310, 26);
            txtUID.TabIndex = 1;
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblUID.ForeColor = Color.FromArgb(50, 52, 76);
            lblUID.Location = new Point(55, 32);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(61, 19);
            lblUID.TabIndex = 1;
            lblUID.Text = "User ID:";
            // 
            // FormEdit
            // 
            AcceptButton = btnEdit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 157, 194);
            ClientSize = new Size(665, 630);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            Load += FormEdit_Load;
            panelBase.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            grpActions.ResumeLayout(false);
            grpAccountInfo.ResumeLayout(false);
            grpAccountInfo.PerformLayout();
            grpCustomerInfo.ResumeLayout(false);
            grpCustomerInfo.PerformLayout();
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
        private Label lblInterestRatePercentage;
        private Button btnCancel;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblTitle;
        private GroupBox grpCustomerInfo;
        private GroupBox grpAccountInfo;
        private GroupBox grpActions;
        private Panel panelContent;
    }
}