namespace BankManagement
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            panel1 = new Panel();
            pnlAdd = new Panel();
            btnAdd = new Button();
            comboType = new ComboBox();
            cboGender = new ComboBox();
            dtpDoB = new DateTimePicker();
            txtBalance = new TextBox();
            txtLastName = new TextBox();
            txtCID = new TextBox();
            txtFirstName = new TextBox();
            lblBalance = new Label();
            lblLastName = new Label();
            lblGender = new Label();
            lblType = new Label();
            lblDoB = new Label();
            lblCID = new Label();
            lblNote = new Label();
            lblFirstName = new Label();
            panel1.SuspendLayout();
            pnlAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 157, 194);
            panel1.Controls.Add(pnlAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 448);
            panel1.TabIndex = 0;
            // 
            // pnlAdd
            // 
            pnlAdd.BackColor = Color.FromArgb(221, 221, 235);
            pnlAdd.Controls.Add(btnAdd);
            pnlAdd.Controls.Add(comboType);
            pnlAdd.Controls.Add(cboGender);
            pnlAdd.Controls.Add(dtpDoB);
            pnlAdd.Controls.Add(txtBalance);
            pnlAdd.Controls.Add(txtLastName);
            pnlAdd.Controls.Add(txtCID);
            pnlAdd.Controls.Add(txtFirstName);
            pnlAdd.Controls.Add(lblBalance);
            pnlAdd.Controls.Add(lblLastName);
            pnlAdd.Controls.Add(lblGender);
            pnlAdd.Controls.Add(lblType);
            pnlAdd.Controls.Add(lblDoB);
            pnlAdd.Controls.Add(lblCID);
            pnlAdd.Controls.Add(lblNote);
            pnlAdd.Controls.Add(lblFirstName);
            pnlAdd.Location = new Point(11, 12);
            pnlAdd.Margin = new Padding(2, 3, 2, 3);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(615, 424);
            pnlAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnAdd.Location = new Point(233, 330);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "CREATE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.Font = new Font("Microsoft Sans Serif", 12F);
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Debit", "Credit", "Savings" });
            comboType.Location = new Point(375, 257);
            comboType.Margin = new Padding(2, 3, 2, 3);
            comboType.Name = "comboType";
            comboType.Size = new Size(156, 28);
            comboType.TabIndex = 3;
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Microsoft Sans Serif", 12F);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(410, 181);
            cboGender.Margin = new Padding(2, 3, 2, 3);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 28);
            cboGender.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.Font = new Font("Microsoft Sans Serif", 12F);
            dtpDoB.Location = new Point(83, 181);
            dtpDoB.Margin = new Padding(2, 3, 2, 3);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(292, 26);
            dtpDoB.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Microsoft Sans Serif", 12F);
            txtBalance.Location = new Point(83, 257);
            txtBalance.Margin = new Padding(2, 3, 2, 3);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(257, 26);
            txtBalance.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName.Location = new Point(324, 111);
            txtLastName.Margin = new Padding(2, 3, 2, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(207, 26);
            txtLastName.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Microsoft Sans Serif", 12F);
            txtCID.Location = new Point(83, 49);
            txtCID.Margin = new Padding(2, 3, 2, 3);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(448, 26);
            txtCID.TabIndex = 1;
            txtCID.TextChanged += txtCID_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F);
            txtFirstName.Location = new Point(83, 111);
            txtFirstName.Margin = new Padding(2, 3, 2, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(207, 26);
            txtFirstName.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBalance.Location = new Point(83, 233);
            lblBalance.Margin = new Padding(2, 0, 2, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(104, 21);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Init Balance:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLastName.Location = new Point(324, 87);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 21);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGender.Location = new Point(410, 157);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 21);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblType.Location = new Point(375, 233);
            lblType.Margin = new Padding(2, 0, 2, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(117, 21);
            lblType.TabIndex = 0;
            lblType.Text = "Account Type:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDoB.Location = new Point(83, 157);
            lblDoB.Margin = new Padding(2, 0, 2, 0);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(107, 21);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Day Of Birth:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCID.Location = new Point(83, 25);
            lblCID.Margin = new Padding(2, 0, 2, 0);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(88, 21);
            lblCID.TabIndex = 0;
            lblCID.Text = "Citizen ID:";
            // 
            // lblNote
            // 
            lblNote.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(83, 368);
            lblNote.Margin = new Padding(2, 0, 2, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(448, 56);
            lblNote.TabIndex = 0;
            lblNote.Text = "Note: This Form only creates most basic information required to create an account, others can be added later";
            lblNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstName.Location = new Point(83, 87);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 448);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdd";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account Information";
            Load += FormAdd_Load;
            panel1.ResumeLayout(false);
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlAdd;
        private Button btnAdd;
        private ComboBox cboGender;
        private DateTimePicker dtpDoB;
        private TextBox txtBalance;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblBalance;
        private Label lblLastName;
        private Label lblGender;
        private Label lblDoB;
        private Label lblFirstName;
        private ComboBox comboType;
        private Label lblType;
        private Label lblNote;
        private TextBox txtCID;
        private Label lblCID;
    }
}