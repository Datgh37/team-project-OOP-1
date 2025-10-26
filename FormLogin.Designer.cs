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
            btnCancel = new Button();
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
            pnlLogin.Controls.Add(btnCancel);
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
            pnlLogin.Margin = new Padding(4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(969, 505);
            pnlLogin.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(620, 324);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(294, 324);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnlForgot
            // 
            lnlForgot.AutoSize = true;
            lnlForgot.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnlForgot.Location = new Point(294, 239);
            lnlForgot.Margin = new Padding(4, 0, 4, 0);
            lnlForgot.Name = "lnlForgot";
            lnlForgot.Size = new Size(141, 23);
            lnlForgot.TabIndex = 3;
            lnlForgot.TabStop = true;
            lnlForgot.Text = "Forgot Pasword ?";
            lnlForgot.LinkClicked += lnlForgot_LinkClicked;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShow.Location = new Point(667, 237);
            chkShow.Margin = new Padding(4);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(73, 27);
            chkShow.TabIndex = 2;
            chkShow.Text = "Show";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(294, 186);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(446, 39);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(294, 122);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(446, 39);
            txtUsername.TabIndex = 1;
            // 
            // lblShutDownMessage
            // 
            lblShutDownMessage.AutoSize = true;
            lblShutDownMessage.Font = new Font("Segoe UI", 10F);
            lblShutDownMessage.Location = new Point(294, 278);
            lblShutDownMessage.Margin = new Padding(4, 0, 4, 0);
            lblShutDownMessage.Name = "lblShutDownMessage";
            lblShutDownMessage.Size = new Size(0, 23);
            lblShutDownMessage.TabIndex = 0;
            lblShutDownMessage.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(156, 190);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 32);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(150, 126);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(135, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 505);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
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
        private Button btnCancel;
        private Button btnLogin;
        private ErrorProvider errorProvider1;
        private Label lblShutDownMessage;
        private LinkLabel lnlForgot;
    }
}