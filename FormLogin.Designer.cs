namespace BankManagement
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            pnlLogin = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            lnlForgot = new LinkLabel();
            chkShow = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblShutDownMessage = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.Control;
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lnlForgot);
            pnlLogin.Controls.Add(chkShow);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblShutDownMessage);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(475, 370);
            pnlLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 40);
            label1.Name = "label1";
            label1.Size = new Size(114, 34);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(50, 52, 76);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(140, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnlForgot
            // 
            lnlForgot.AutoSize = true;
            lnlForgot.DisabledLinkColor = Color.Black;
            lnlForgot.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnlForgot.LinkVisited = true;
            lnlForgot.Location = new Point(48, 226);
            lnlForgot.Name = "lnlForgot";
            lnlForgot.Size = new Size(111, 17);
            lnlForgot.TabIndex = 3;
            lnlForgot.TabStop = true;
            lnlForgot.Text = "Forgot Pasword ?";
            lnlForgot.VisitedLinkColor = Color.Black;
            lnlForgot.LinkClicked += lnlForgot_LinkClicked;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShow.Location = new Point(338, 226);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(58, 21);
            chkShow.TabIndex = 2;
            chkShow.Text = "Show";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(221, 221, 235);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(48, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(348, 26);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(221, 221, 235);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(48, 123);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(348, 26);
            txtUsername.TabIndex = 1;
            // 
            // lblShutDownMessage
            // 
            lblShutDownMessage.AutoSize = true;
            lblShutDownMessage.Font = new Font("Segoe UI", 10F);
            lblShutDownMessage.Location = new Point(222, 252);
            lblShutDownMessage.Name = "lblShutDownMessage";
            lblShutDownMessage.Size = new Size(0, 19);
            lblShutDownMessage.TabIndex = 0;
            lblShutDownMessage.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(48, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(48, 105);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(67, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 370);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private CheckBox chkShow;
        private Button btnLogin;
        private ErrorProvider errorProvider1;
        private Label lblShutDownMessage;
        private LinkLabel lnlForgot;
        private Label label1;
    }
}