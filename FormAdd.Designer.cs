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
            pnlAdd = new Panel();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBalance = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtBalance = new TextBox();
            lblDoB = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblGender = new Label();
            comboBox1 = new ComboBox();
            btnAdd = new Button();
            pnlAdd.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(btnAdd);
            pnlAdd.Controls.Add(comboBox1);
            pnlAdd.Controls.Add(dateTimePicker1);
            pnlAdd.Controls.Add(txtBalance);
            pnlAdd.Controls.Add(txtLastName);
            pnlAdd.Controls.Add(txtFirstName);
            pnlAdd.Controls.Add(lblBalance);
            pnlAdd.Controls.Add(lblLastName);
            pnlAdd.Controls.Add(lblGender);
            pnlAdd.Controls.Add(lblDoB);
            pnlAdd.Controls.Add(lblFirstName);
            pnlAdd.Dock = DockStyle.Fill;
            pnlAdd.Location = new Point(0, 0);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(1280, 580);
            pnlAdd.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(74, 156);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(74, 226);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 25);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(74, 305);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(85, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(187, 153);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(554, 33);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(187, 223);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(554, 33);
            txtLastName.TabIndex = 1;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(187, 302);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(554, 33);
            txtBalance.TabIndex = 1;
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoB.Location = new Point(958, 156);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(126, 25);
            lblDoB.TabIndex = 0;
            lblDoB.Text = "Day Of Birth:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(918, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 33);
            dateTimePicker1.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(976, 250);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(84, 25);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox1.Location = new Point(958, 278);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(645, 433);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 580);
            Controls.Add(pnlAdd);
            MaximizeBox = false;
            Name = "FormAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdd";
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdd;
        private Label lblBalance;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtBalance;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnAdd;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label lblGender;
        private Label lblDoB;
    }
}