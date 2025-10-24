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
            cboType = new ComboBox();
            cboGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtBalance = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblBalance = new Label();
            lblLastName = new Label();
            lblGender = new Label();
            lblType = new Label();
            lblDoB = new Label();
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
            panel1.Size = new Size(1594, 812);
            panel1.TabIndex = 0;
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(btnAdd);
            pnlAdd.Controls.Add(cboType);
            pnlAdd.Controls.Add(cboGender);
            pnlAdd.Controls.Add(dateTimePicker1);
            pnlAdd.Controls.Add(txtBalance);
            pnlAdd.Controls.Add(txtLastName);
            pnlAdd.Controls.Add(txtFirstName);
            pnlAdd.Controls.Add(lblBalance);
            pnlAdd.Controls.Add(lblLastName);
            pnlAdd.Controls.Add(lblGender);
            pnlAdd.Controls.Add(lblType);
            pnlAdd.Controls.Add(lblDoB);
            pnlAdd.Controls.Add(lblFirstName);
            pnlAdd.Dock = DockStyle.Fill;
            pnlAdd.Location = new Point(0, 0);
            pnlAdd.Margin = new Padding(3, 4, 3, 4);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(1594, 812);
            pnlAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(829, 606);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 49);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboType
            // 
            cboType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Debit", "Credit", "Savings" });
            cboType.Location = new Point(1180, 422);
            cboType.Margin = new Padding(3, 4, 3, 4);
            cboType.Name = "cboType";
            cboType.Size = new Size(280, 40);
            cboType.TabIndex = 3;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(1246, 308);
            cboGender.Margin = new Padding(3, 4, 3, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(155, 40);
            cboGender.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(1180, 214);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(280, 39);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(241, 423);
            txtBalance.Margin = new Padding(3, 4, 3, 4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(712, 39);
            txtBalance.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(241, 312);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(712, 39);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(241, 214);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(712, 39);
            txtFirstName.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(96, 427);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(109, 32);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(96, 316);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(133, 32);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(1269, 275);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(105, 32);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(1232, 384);
            lblType.Name = "lblType";
            lblType.Size = new Size(177, 32);
            lblType.TabIndex = 0;
            lblType.Text = "Account Type:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoB.Location = new Point(1232, 175);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(162, 32);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Day Of Birth:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(96, 218);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(137, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 812);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Information";
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
        private DateTimePicker dateTimePicker1;
        private TextBox txtBalance;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblBalance;
        private Label lblLastName;
        private Label lblGender;
        private Label lblDoB;
        private Label lblFirstName;
        private ComboBox cboType;
        private Label lblType;
    }
}