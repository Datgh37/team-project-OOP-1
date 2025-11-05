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
            btnCancel = new Button();
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
            panel1.Controls.Add(pnlAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1594, 649);
            panel1.TabIndex = 0;
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(btnCancel);
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
            pnlAdd.Dock = DockStyle.Fill;
            pnlAdd.Location = new Point(0, 0);
            pnlAdd.Margin = new Padding(3, 4, 3, 4);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(1594, 649);
            pnlAdd.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1343, 511);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(172, 49);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1080, 511);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 49);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "CREATE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Debit", "Credit", "Savings" });
            comboType.Location = new Point(1164, 378);
            comboType.Margin = new Padding(3, 4, 3, 4);
            comboType.Name = "comboType";
            comboType.Size = new Size(280, 40);
            comboType.TabIndex = 3;
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(1224, 270);
            cboGender.Margin = new Padding(3, 4, 3, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(154, 40);
            cboGender.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDoB.Location = new Point(1106, 171);
            dtpDoB.Margin = new Padding(3, 4, 3, 4);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(389, 39);
            dtpDoB.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(240, 423);
            txtBalance.Margin = new Padding(3, 4, 3, 4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(712, 39);
            txtBalance.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(240, 326);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(712, 39);
            txtLastName.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCID.Location = new Point(240, 132);
            txtCID.Margin = new Padding(3, 4, 3, 4);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(712, 39);
            txtCID.TabIndex = 1;
            txtCID.TextChanged += txtCID_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(240, 229);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(712, 39);
            txtFirstName.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(78, 426);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(155, 32);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Init Balance:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(100, 329);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(133, 32);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(1253, 231);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(105, 32);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(1216, 341);
            lblType.Name = "lblType";
            lblType.Size = new Size(177, 32);
            lblType.TabIndex = 0;
            lblType.Text = "Account Type:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoB.Location = new Point(1216, 132);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(162, 32);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Day Of Birth:";
            // 
            // lblCID
            // 
            lblCID.AutoSize = true;
            lblCID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCID.Location = new Point(101, 135);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(132, 32);
            lblCID.TabIndex = 0;
            lblCID.Text = "Citizen ID:";
            // 
            // lblNote
            // 
            lblNote.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(96, 511);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(856, 78);
            lblNote.TabIndex = 0;
            lblNote.Text = "Note: This Form only creates most basic information required to create an account, others can be added later";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(96, 232);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(137, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 649);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAdd";
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
        private Button btnCancel;
    }
}