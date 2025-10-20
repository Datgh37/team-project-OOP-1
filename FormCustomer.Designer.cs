namespace BankManagement
{
    partial class FormCustomer
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
            btnCancel = new Button();
            btnEdit = new Button();
            lbl_uid = new Label();
            lbl_cid = new Label();
            lbl_phone = new Label();
            lbl_email = new Label();
            lbl_address = new Label();
            lbl_lastname = new Label();
            lbl_firstname = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblCID = new Label();
            lblUID = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lbl_uid);
            panel1.Controls.Add(lbl_cid);
            panel1.Controls.Add(lbl_phone);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(lbl_address);
            panel1.Controls.Add(lbl_lastname);
            panel1.Controls.Add(lbl_firstname);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblCID);
            panel1.Controls.Add(lblUID);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 511);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(585, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(76, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbl_uid
            // 
            lbl_uid.AutoSize = true;
            lbl_uid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_uid.Location = new Point(189, 96);
            lbl_uid.Name = "lbl_uid";
            lbl_uid.Size = new Size(47, 25);
            lbl_uid.TabIndex = 0;
            lbl_uid.Text = "/////";
            // 
            // lbl_cid
            // 
            lbl_cid.AutoSize = true;
            lbl_cid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cid.Location = new Point(189, 136);
            lbl_cid.Name = "lbl_cid";
            lbl_cid.Size = new Size(47, 25);
            lbl_cid.TabIndex = 0;
            lbl_cid.Text = "/////";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_phone.Location = new Point(189, 351);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(47, 25);
            lbl_phone.TabIndex = 0;
            lbl_phone.Text = "/////";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(189, 308);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(47, 25);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "/////";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(189, 265);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(47, 25);
            lbl_address.TabIndex = 0;
            lbl_address.Text = "/////";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastname.Location = new Point(189, 219);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(47, 25);
            lbl_lastname.TabIndex = 0;
            lbl_lastname.Text = "/////";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstname.Location = new Point(189, 176);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(47, 25);
            lbl_firstname.TabIndex = 0;
            lbl_firstname.Text = "/////";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(76, 351);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(74, 25);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 308);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(76, 265);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(88, 25);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(76, 219);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 25);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(76, 176);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Location = new Point(76, 136);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(49, 25);
            lblCID.TabIndex = 0;
            lblCID.Text = "CID:";
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Location = new Point(76, 96);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(51, 25);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID:";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 511);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUID;
        private Label lblFirstName;
        private Label lblCID;
        private Label lblAddress;
        private Label lblLastName;
        private Label lbl_email;
        private Label lbl_address;
        private Label lbl_lastname;
        private Label lbl_firstname;
        private Label lblPhone;
        private Label lblEmail;
        private Label lbl_cid;
        private Label lbl_phone;
        private Label lbl_uid;
        private Button btnEdit;
        private Button btnCancel;
    }
}