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
            panel1.Location = new Point(15, 17);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 787);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 85);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(440, 671);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 45);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(188, 671);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 45);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbl_uid
            // 
            lbl_uid.AutoSize = true;
            lbl_uid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_uid.Location = new Point(260, 102);
            lbl_uid.Margin = new Padding(4, 0, 4, 0);
            lbl_uid.Name = "lbl_uid";
            lbl_uid.Size = new Size(59, 32);
            lbl_uid.TabIndex = 0;
            lbl_uid.Text = "/////";
            // 
            // lbl_cid
            // 
            lbl_cid.AutoSize = true;
            lbl_cid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cid.Location = new Point(260, 150);
            lbl_cid.Margin = new Padding(4, 0, 4, 0);
            lbl_cid.Name = "lbl_cid";
            lbl_cid.Size = new Size(59, 32);
            lbl_cid.TabIndex = 0;
            lbl_cid.Text = "/////";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_gender.Location = new Point(492, 266);
            lbl_gender.Margin = new Padding(4, 0, 4, 0);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(59, 32);
            lbl_gender.TabIndex = 0;
            lbl_gender.Text = "/////";
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dob.Location = new Point(492, 344);
            lbl_dob.Margin = new Padding(4, 0, 4, 0);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(59, 32);
            lbl_dob.TabIndex = 0;
            lbl_dob.Text = "/////";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_phone.Location = new Point(492, 463);
            lbl_phone.Margin = new Padding(4, 0, 4, 0);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(59, 32);
            lbl_phone.TabIndex = 0;
            lbl_phone.Text = "/////";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(174, 546);
            lbl_email.Margin = new Padding(4, 0, 4, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(59, 32);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "/////";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(174, 463);
            lbl_address.Margin = new Padding(4, 0, 4, 0);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(59, 32);
            lbl_address.TabIndex = 0;
            lbl_address.Text = "/////";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastname.Location = new Point(174, 344);
            lbl_lastname.Margin = new Padding(4, 0, 4, 0);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(59, 32);
            lbl_lastname.TabIndex = 0;
            lbl_lastname.Text = "/////";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstname.Location = new Point(174, 266);
            lbl_firstname.Margin = new Padding(4, 0, 4, 0);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(59, 32);
            lbl_firstname.TabIndex = 0;
            lbl_firstname.Text = "/////";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGender.Location = new Point(492, 237);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(86, 28);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDOB.Location = new Point(492, 315);
            lblDOB.Margin = new Padding(4, 0, 4, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(142, 28);
            lblDOB.TabIndex = 0;
            lblDOB.Text = "Date of Birth:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.Location = new Point(492, 434);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(76, 28);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(174, 517);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 28);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddress.Location = new Point(174, 434);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(92, 28);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLastName.Location = new Point(174, 315);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(111, 28);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstName.Location = new Point(174, 237);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(114, 28);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCID.Location = new Point(199, 154);
            lblCID.Margin = new Padding(4, 0, 4, 0);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(50, 28);
            lblCID.TabIndex = 0;
            lblCID.Text = "CID:";
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUID.Location = new Point(197, 106);
            lblUID.Margin = new Padding(4, 0, 4, 0);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(52, 28);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID:";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 157, 194);
            ClientSize = new Size(831, 820);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
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