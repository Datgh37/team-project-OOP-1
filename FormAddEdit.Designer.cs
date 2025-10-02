namespace BankManagement
{
    partial class FormAddEdit
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
            label1 = new Label();
            cboGender = new ComboBox();
            btnUser = new Button();
            dtpDoB = new DateTimePicker();
            lblDoB = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtFirstName = new TextBox();
            lblEmail = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboGender);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(dtpDoB);
            panel1.Controls.Add(lblDoB);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 648);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(848, 314);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 6;
            label1.Text = "Gender:";
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(938, 311);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(181, 33);
            cboGender.TabIndex = 5;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(583, 473);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(126, 42);
            btnUser.TabIndex = 4;
            btnUser.Text = "ADD";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // dtpDoB
            // 
            dtpDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDoB.Location = new Point(848, 207);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(271, 33);
            dtpDoB.TabIndex = 3;
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoB.Location = new Point(917, 143);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(126, 25);
            lblDoB.TabIndex = 2;
            lblDoB.Text = "Day Of Birth:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(132, 311);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(609, 33);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(167, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(574, 33);
            textBox1.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(175, 140);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(566, 33);
            txtFirstName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(62, 314);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(62, 210);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(62, 143);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // FormAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 672);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDoB;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtFirstName;
        private Label lblEmail;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnUser;
        private DateTimePicker dtpDoB;
        private ComboBox cboGender;
        private Label label1;
    }
}