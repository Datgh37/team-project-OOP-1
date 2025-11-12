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
            panelBase = new Panel();
            pnlAdd = new Panel();
            cboGender = new ComboBox();
            comboType = new ComboBox();
            dtpDoB = new DateTimePicker();
            btnCancel = new Button();
            btnAdd = new Button();
            txtLastName = new TextBox();
            txtBalance = new TextBox();
            txtCID = new TextBox();
            txtFirstName = new TextBox();
            lblNote = new Label();
            lblLastName = new Label();
            lblBalance = new Label();
            lblGender = new Label();
            lblDoB = new Label();
            lblType = new Label();
            lblCID = new Label();
            lblTitle = new Label();
            lblFirstName = new Label();
            panelBase.SuspendLayout();
            pnlAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelBase
            // 
            panelBase.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBase.BackColor = Color.FromArgb(157, 157, 194);
            panelBase.Controls.Add(pnlAdd);
            panelBase.Dock = DockStyle.Fill;
            panelBase.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelBase.Location = new Point(0, 0);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(854, 727);
            panelBase.TabIndex = 0;
            // 
            // pnlAdd
            // 
            pnlAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlAdd.BackColor = Color.FromArgb(221, 221, 235);
            pnlAdd.Controls.Add(cboGender);
            pnlAdd.Controls.Add(comboType);
            pnlAdd.Controls.Add(dtpDoB);
            pnlAdd.Controls.Add(btnCancel);
            pnlAdd.Controls.Add(btnAdd);
            pnlAdd.Controls.Add(txtLastName);
            pnlAdd.Controls.Add(txtBalance);
            pnlAdd.Controls.Add(txtCID);
            pnlAdd.Controls.Add(txtFirstName);
            pnlAdd.Controls.Add(lblNote);
            pnlAdd.Controls.Add(lblLastName);
            pnlAdd.Controls.Add(lblBalance);
            pnlAdd.Controls.Add(lblGender);
            pnlAdd.Controls.Add(lblDoB);
            pnlAdd.Controls.Add(lblType);
            pnlAdd.Controls.Add(lblCID);
            pnlAdd.Controls.Add(lblTitle);
            pnlAdd.Controls.Add(lblFirstName);
            pnlAdd.Location = new Point(14, 14);
            pnlAdd.Margin = new Padding(3, 4, 3, 4);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(826, 694);
            pnlAdd.TabIndex = 1;
            // 
            // cboGender
            // 
            cboGender.Cursor = Cursors.Hand;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Source Sans 3", 13F);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(123, 325);
            cboGender.Margin = new Padding(3, 4, 3, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(154, 35);
            cboGender.TabIndex = 3;
            // 
            // comboType
            // 
            comboType.Cursor = Cursors.Hand;
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.Font = new Font("Source Sans 3", 13F);
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Debit", "Credit", "Savings" });
            comboType.Location = new Point(498, 443);
            comboType.Margin = new Padding(3, 4, 3, 4);
            comboType.Name = "comboType";
            comboType.Size = new Size(199, 35);
            comboType.TabIndex = 3;
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // dtpDoB
            // 
            dtpDoB.Cursor = Cursors.Hand;
            dtpDoB.Font = new Font("Source Sans 3", 12F);
            dtpDoB.Location = new Point(323, 324);
            dtpDoB.Margin = new Padding(3, 4, 3, 4);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(374, 36);
            dtpDoB.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 220, 235);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(67, 69, 94);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Source Sans 3", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(50, 52, 76);
            btnCancel.Location = new Point(514, 525);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 49);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "✖ CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(67, 69, 94);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Source Sans 3", 14.25F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(123, 525);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 49);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "✓ CREATE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Source Sans 3", 12F);
            txtLastName.Location = new Point(432, 228);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 36);
            txtLastName.TabIndex = 1;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Source Sans 3", 12F);
            txtBalance.Location = new Point(123, 443);
            txtBalance.Margin = new Padding(3, 4, 3, 4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(329, 36);
            txtBalance.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Source Sans 3", 12F);
            txtCID.Location = new Point(123, 142);
            txtCID.Margin = new Padding(3, 4, 3, 4);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(575, 36);
            txtCID.TabIndex = 1;
            txtCID.TextChanged += txtCID_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Source Sans 3", 12F);
            txtFirstName.Location = new Point(123, 228);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(265, 36);
            txtFirstName.TabIndex = 1;
            // 
            // lblNote
            // 
            lblNote.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(117, 580);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(576, 78);
            lblNote.TabIndex = 0;
            lblNote.Text = "Note: This Form is only for creating the most basic information required for an account, other information can be added later";
            lblNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLastName.Location = new Point(427, 198);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(106, 25);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBalance.Location = new Point(118, 412);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(118, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Init Balance:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblGender.Location = new Point(117, 296);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 25);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDoB.Location = new Point(319, 296);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(124, 25);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Day Of Birth:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblType.Location = new Point(493, 412);
            lblType.Name = "lblType";
            lblType.Size = new Size(134, 25);
            lblType.TabIndex = 0;
            lblType.Text = "Account Type:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblCID.Location = new Point(117, 111);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(99, 25);
            lblCID.TabIndex = 0;
            lblCID.Text = "Citizen ID:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(238, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 41);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "CREATE NEW ACCOUNT";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFirstName.Location = new Point(117, 198);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(108, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 727);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdd";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account Information";
            Load += FormAdd_Load;
            panelBase.ResumeLayout(false);
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBase;
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
        private Label lblTitle;
        private Button btnCancel;
    }
}