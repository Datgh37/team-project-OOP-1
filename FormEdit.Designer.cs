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
            panel1 = new Panel();
            btnEdit = new Button();
            cboGender = new ComboBox();
            dtpDoB = new DateTimePicker();
            txtBalance = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            txtCID = new TextBox();
            txtUID = new TextBox();
            txtFirstName = new TextBox();
            lblGender = new Label();
            lblDoB = new Label();
            lblCID = new Label();
            lblUID = new Label();
            lblBalance = new Label();
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
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtCID);
            panel1.Controls.Add(txtUID);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblDoB);
            panel1.Controls.Add(lblCID);
            panel1.Controls.Add(lblUID);
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblFirstName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 464);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(550, 385);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 33);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(814, 286);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(302, 33);
            cboGender.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDoB.Location = new Point(814, 234);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(302, 33);
            dtpDoB.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(177, 286);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(377, 33);
            txtBalance.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(177, 237);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(377, 33);
            txtPhone.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(177, 188);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(377, 33);
            txtAddress.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(177, 135);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(377, 33);
            txtLastName.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCID.Location = new Point(781, 135);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(335, 33);
            txtCID.TabIndex = 1;
            // 
            // txtUID
            // 
            txtUID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUID.Location = new Point(781, 87);
            txtUID.Name = "txtUID";
            txtUID.Size = new Size(335, 33);
            txtUID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(177, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(377, 33);
            txtFirstName.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(724, 289);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(84, 25);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoB.Location = new Point(724, 240);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(61, 25);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Birth:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCID.Location = new Point(724, 138);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(49, 25);
            lblCID.TabIndex = 0;
            lblCID.Text = "CID:";
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUID.Location = new Point(724, 90);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(51, 25);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(64, 289);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(85, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(64, 240);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(74, 25);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(64, 191);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(88, 25);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(64, 138);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 25);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(64, 90);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 464);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEdit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUID;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblBalance;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox textBox1;
        private TextBox txtBalance;
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
    }
}