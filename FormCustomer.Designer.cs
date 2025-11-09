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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnEdit = new Button();
            lbl_uid = new Label();
            lbl_cid = new Label();
            lbl_gender = new Label();
            lbl_dob = new Label();
            lbl_phone = new Label();
            lbl_email = new Label();
            lbl_address = new Label();
            lbl_lastname = new Label();
            lbl_firstname = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblCID = new Label();
            lblUID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 221, 235);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lbl_uid);
            panel1.Controls.Add(lbl_cid);
            panel1.Controls.Add(lbl_gender);
            panel1.Controls.Add(lbl_dob);
            panel1.Controls.Add(lbl_phone);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(lbl_address);
            panel1.Controls.Add(lbl_lastname);
            panel1.Controls.Add(lbl_firstname);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblDOB);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblCID);
            panel1.Controls.Add(lblUID);
            panel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 562);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(342, 479);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(146, 479);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbl_uid
            // 
            lbl_uid.AutoSize = true;
            lbl_uid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_uid.Location = new Point(202, 73);
            lbl_uid.Name = "lbl_uid";
            lbl_uid.Size = new Size(47, 25);
            lbl_uid.TabIndex = 0;
            lbl_uid.Text = "/////";
            // 
            // lbl_cid
            // 
            lbl_cid.AutoSize = true;
            lbl_cid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cid.Location = new Point(202, 107);
            lbl_cid.Name = "lbl_cid";
            lbl_cid.Size = new Size(47, 25);
            lbl_cid.TabIndex = 0;
            lbl_cid.Text = "/////";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_gender.Location = new Point(383, 190);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(47, 25);
            lbl_gender.TabIndex = 0;
            lbl_gender.Text = "/////";
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dob.Location = new Point(383, 246);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(47, 25);
            lbl_dob.TabIndex = 0;
            lbl_dob.Text = "/////";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_phone.Location = new Point(383, 331);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(47, 25);
            lbl_phone.TabIndex = 0;
            lbl_phone.Text = "/////";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(135, 390);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(47, 25);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "/////";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(135, 331);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(47, 25);
            lbl_address.TabIndex = 0;
            lbl_address.Text = "/////";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastname.Location = new Point(135, 246);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(47, 25);
            lbl_lastname.TabIndex = 0;
            lbl_lastname.Text = "/////";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstname.Location = new Point(135, 190);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(47, 25);
            lbl_firstname.TabIndex = 0;
            lbl_firstname.Text = "/////";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGender.Location = new Point(383, 169);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 21);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDOB.Location = new Point(383, 225);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(111, 21);
            lblDOB.TabIndex = 0;
            lblDOB.Text = "Date of Birth:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.Location = new Point(383, 310);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 21);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(135, 369);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddress.Location = new Point(135, 310);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 21);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLastName.Location = new Point(135, 225);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(90, 21);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstName.Location = new Point(135, 169);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCID.Location = new Point(155, 110);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(41, 21);
            lblCID.TabIndex = 0;
            lblCID.Text = "CID:";
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUID.Location = new Point(153, 76);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(43, 21);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID:";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 157, 194);
            ClientSize = new Size(646, 586);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Information";
            FormClosing += FormCustomer_FormClosing;
            Load += FormCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnExit;
        private Label lbl_dob;
        private Label lblDOB;
        private Label lbl_gender;
        private Label lblGender;
        private PictureBox pictureBox1;
    }
}