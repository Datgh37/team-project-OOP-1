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
            panel1 = new Panel();
            btnEdit = new Button();
            cboGender = new ComboBox();
            dtpDoB = new DateTimePicker();
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
            lblBalance = new Label();
            lblUID = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cboGender);
            panel1.Controls.Add(dtpDoB);
            panel1.Controls.Add(txtBalance);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtCID);
            panel1.Controls.Add(txtUID);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblDoB);
            panel1.Controls.Add(lblCID);
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(lblUID);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblFirstName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 650);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(566, 501);
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
            cboGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(777, 331);
            cboGender.Margin = new Padding(4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(217, 40);
            cboGender.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDoB.Location = new Point(734, 263);
            dtpDoB.Margin = new Padding(4);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(490, 39);
            dtpDoB.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(781, 400);
            txtBalance.Margin = new Padding(4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(213, 39);
            txtBalance.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(228, 400);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 39);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(228, 332);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(339, 39);
            txtPhone.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(228, 263);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(339, 39);
            txtAddress.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(228, 189);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(339, 39);
            txtLastName.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCID.Location = new Point(734, 189);
            txtCID.Margin = new Padding(4);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(490, 39);
            txtCID.TabIndex = 1;
            // 
            // txtUID
            // 
            txtUID.Enabled = false;
            txtUID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUID.Location = new Point(734, 122);
            txtUID.Margin = new Padding(4);
            txtUID.Name = "txtUID";
            txtUID.ReadOnly = true;
            txtUID.Size = new Size(490, 39);
            txtUID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(228, 122);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(339, 39);
            txtFirstName.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(654, 333);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(105, 32);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoB.Location = new Point(654, 264);
            lblDoB.Margin = new Padding(4, 0, 4, 0);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(77, 32);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Birth:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCID.Location = new Point(654, 195);
            lblCID.Margin = new Padding(4, 0, 4, 0);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(62, 32);
            lblCID.TabIndex = 0;
            lblCID.Text = "CID:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(654, 402);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(109, 32);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUID.Location = new Point(654, 126);
            lblUID.Margin = new Padding(4, 0, 4, 0);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(64, 32);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(82, 402);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(82, 333);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(93, 32);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(82, 264);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(113, 32);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(82, 195);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(133, 32);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(82, 126);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(137, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 650);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            Load += FormEdit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUID;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtFirstName;
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
    }
}