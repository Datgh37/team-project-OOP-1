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
            pnlLogin.Margin = new Padding(4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(730, 518);
            pnlLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 20F, FontStyle.Bold);
            label1.Location = new Point(303, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(50, 52, 76);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(251, 388);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnlForgot
            // 
            lnlForgot.AutoSize = true;
            lnlForgot.DisabledLinkColor = Color.Black;
            lnlForgot.Font = new Font("Lato", 10F);
            lnlForgot.ForeColor = SystemColors.ControlText;
            lnlForgot.LinkVisited = true;
            lnlForgot.Location = new Point(133, 306);
            lnlForgot.Margin = new Padding(4, 0, 4, 0);
            lnlForgot.Name = "lnlForgot";
            lnlForgot.Size = new Size(137, 21);
            lnlForgot.TabIndex = 3;
            lnlForgot.TabStop = true;
            lnlForgot.Text = "Forgot Pasword ?";
            lnlForgot.VisitedLinkColor = Color.Black;
            lnlForgot.LinkClicked += lnlForgot_LinkClicked;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Cursor = Cursors.Hand;
            chkShow.Font = new Font("Lato", 10F);
            chkShow.ForeColor = SystemColors.ControlText;
            chkShow.Location = new Point(506, 306);
            chkShow.Margin = new Padding(4);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(72, 25);
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
            txtPassword.Font = new Font("Source Sans 3", 13F);
            txtPassword.Location = new Point(133, 254);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(447, 31);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(221, 221, 235);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Source Sans 3", 13F);
            txtUsername.Location = new Point(133, 170);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(447, 31);
            txtUsername.TabIndex = 1;
            // 
            // lblShutDownMessage
            // 
            lblShutDownMessage.AutoSize = true;
            lblShutDownMessage.Font = new Font("Segoe UI", 10F);
            lblShutDownMessage.Location = new Point(356, 351);
            lblShutDownMessage.Margin = new Padding(4, 0, 4, 0);
            lblShutDownMessage.Name = "lblShutDownMessage";
            lblShutDownMessage.Size = new Size(0, 23);
            lblShutDownMessage.TabIndex = 0;
            lblShutDownMessage.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Lato", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(127, 229);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Lato", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(127, 145);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
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
            ClientSize = new Size(730, 518);
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
        private Button btnLogin;
        private ErrorProvider errorProvider1;
        private Label lblShutDownMessage;
        private LinkLabel lnlForgot;
        private Label label1;
    }
}