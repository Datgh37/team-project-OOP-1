namespace BankManagement
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            statusStrip = new StatusStrip();
            tslblStatus = new ToolStripStatusLabel();
            tslblDateTime = new ToolStripStatusLabel();
            tsiForms = new ToolStripMenuItem();
            tsmiMainForm = new ToolStripMenuItem();
            tsmiAddForm = new ToolStripMenuItem();
            tsmiTransactionForm = new ToolStripMenuItem();
            tsiMenu = new ToolStripMenuItem();
            tsmiCascade = new ToolStripMenuItem();
            tsmiTileHorizontal = new ToolStripMenuItem();
            tsmiTileVertical = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            btnHome = new Button();
            btnTransfer = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelDesktop = new Panel();
            statusStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.AutoSize = false;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tslblStatus, tslblDateTime });
            statusStrip.Location = new Point(200, 640);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 11, 0);
            statusStrip.Size = new Size(1284, 21);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Status Bar";
            // 
            // tslblStatus
            // 
            tslblStatus.Name = "tslblStatus";
            tslblStatus.Size = new Size(39, 16);
            tslblStatus.Text = "Ready";
            // 
            // tslblDateTime
            // 
            tslblDateTime.Name = "tslblDateTime";
            tslblDateTime.Size = new Size(58, 16);
            tslblDateTime.Text = "DateTime";
            // 
            // tsiForms
            // 
            tsiForms.DropDownItems.AddRange(new ToolStripItem[] { tsmiMainForm, tsmiAddForm, tsmiTransactionForm });
            tsiForms.Name = "tsiForms";
            tsiForms.Size = new Size(68, 25);
            tsiForms.Text = "Forms";
            // 
            // tsmiMainForm
            // 
            tsmiMainForm.Name = "tsmiMainForm";
            tsmiMainForm.Size = new Size(135, 22);
            tsmiMainForm.Text = "Main";
            // 
            // tsmiAddForm
            // 
            tsmiAddForm.Name = "tsmiAddForm";
            tsmiAddForm.Size = new Size(135, 22);
            tsmiAddForm.Text = "Add";
            // 
            // tsmiTransactionForm
            // 
            tsmiTransactionForm.Name = "tsmiTransactionForm";
            tsmiTransactionForm.Size = new Size(135, 22);
            tsmiTransactionForm.Text = "Transaction";
            // 
            // tsiMenu
            // 
            tsiMenu.DropDownItems.AddRange(new ToolStripItem[] { tsmiCascade, tsmiTileHorizontal, tsmiTileVertical });
            tsiMenu.Name = "tsiMenu";
            tsiMenu.Size = new Size(82, 25);
            tsiMenu.Text = "Window";
            // 
            // tsmiCascade
            // 
            tsmiCascade.Name = "tsmiCascade";
            tsmiCascade.Size = new Size(151, 22);
            tsmiCascade.Text = "Cascade";
            // 
            // tsmiTileHorizontal
            // 
            tsmiTileHorizontal.Name = "tsmiTileHorizontal";
            tsmiTileHorizontal.Size = new Size(151, 22);
            tsmiTileHorizontal.Text = "Tile Horizontal";
            // 
            // tsmiTileVertical
            // 
            tsmiTileVertical.Name = "tsmiTileVertical";
            tsmiTileVertical.Size = new Size(151, 22);
            tsmiTileVertical.Text = "Tile Vertical";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 52, 76);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnTransfer);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 599);
            panel1.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.FromArgb(67, 69, 94);
            pictureBoxClose.BackgroundImageLayout = ImageLayout.None;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(162, 24);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(20, 20);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(50, 52, 76);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(200, 63);
            btnHome.TabIndex = 5;
            btnHome.Text = "  Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.FromArgb(50, 52, 76);
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Image = (Image)resources.GetObject("btnTransfer.Image");
            btnTransfer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransfer.Location = new Point(0, 63);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Padding = new Padding(10, 0, 0, 0);
            btnTransfer.Size = new Size(200, 63);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = " Transfer";
            btnTransfer.TextAlign = ContentAlignment.MiddleLeft;
            btnTransfer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 52, 76);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(0, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(200, 63);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "  Add User";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 39, 59);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1484, 62);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(36, 39, 59);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 5;
            label1.Text = "Bank Management\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDesktop.BackColor = Color.FromArgb(221, 221, 235);
            panelDesktop.Location = new Point(200, 62);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1284, 575);
            panelDesktop.TabIndex = 5;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1484, 661);
            Controls.Add(statusStrip);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(panel2);
            IsMdiContainer = true;
            Margin = new Padding(2);
            MinimumSize = new Size(1500, 700);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel tslblStatus;
        private ToolStripStatusLabel tslblDateTime;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsiForms;
        private ToolStripMenuItem tsiMenu;
        private ToolStripMenuItem tsmiCascade;
        private ToolStripMenuItem tsmiTileHorizontal;
        private ToolStripMenuItem tsmiTileVertical;
        private ToolStripMenuItem tsmiMainForm;
        private ToolStripMenuItem tsmiAddForm;
        private ToolStripMenuItem tsmiTransactionForm;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnHome;
        private Button btnAdd;
        private Button btnTransfer;
        private Panel panelDesktop;
        private PictureBox pictureBoxClose;
    }
}