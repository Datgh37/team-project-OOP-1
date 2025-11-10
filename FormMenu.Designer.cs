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
            if (disposing)
            {
                // Dispose timer
                _clockTimer?.Stop();
                _clockTimer?.Dispose();

                // Dispose active form
                if (activeForm != null && !activeForm.IsDisposed)
                {
                    activeForm.Dispose();
                }

                // Dispose components (auto-generated)
                components?.Dispose();
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
            pnlDashBoard = new Panel();
            ptbClose = new PictureBox();
            btnHome = new Button();
            btnTransfer = new Button();
            btnAdd = new Button();
            pnlTitle = new Panel();
            ptbIcon = new PictureBox();
            lblTitle = new Label();
            panelDesktop = new Panel();
            statusStrip.SuspendLayout();
            pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbIcon).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.AutoSize = false;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tslblStatus, tslblDateTime });
            statusStrip.Location = new Point(257, 896);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1651, 29);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Status Bar";
            // 
            // tslblStatus
            // 
            tslblStatus.Name = "tslblStatus";
            tslblStatus.Size = new Size(53, 23);
            tslblStatus.Text = "Ready";
            // 
            // tslblDateTime
            // 
            tslblDateTime.Name = "tslblDateTime";
            tslblDateTime.Size = new Size(76, 23);
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
            tsmiMainForm.Size = new Size(173, 26);
            tsmiMainForm.Text = "Main";
            // 
            // tsmiAddForm
            // 
            tsmiAddForm.Name = "tsmiAddForm";
            tsmiAddForm.Size = new Size(173, 26);
            tsmiAddForm.Text = "Add";
            // 
            // tsmiTransactionForm
            // 
            tsmiTransactionForm.Name = "tsmiTransactionForm";
            tsmiTransactionForm.Size = new Size(173, 26);
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
            tsmiCascade.Size = new Size(194, 26);
            tsmiCascade.Text = "Cascade";
            // 
            // tsmiTileHorizontal
            // 
            tsmiTileHorizontal.Name = "tsmiTileHorizontal";
            tsmiTileHorizontal.Size = new Size(194, 26);
            tsmiTileHorizontal.Text = "Tile Horizontal";
            // 
            // tsmiTileVertical
            // 
            tsmiTileVertical.Name = "tsmiTileVertical";
            tsmiTileVertical.Size = new Size(194, 26);
            tsmiTileVertical.Text = "Tile Vertical";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // pnlDashBoard
            // 
            pnlDashBoard.BackColor = Color.FromArgb(50, 52, 76);
            pnlDashBoard.Controls.Add(ptbClose);
            pnlDashBoard.Controls.Add(btnHome);
            pnlDashBoard.Controls.Add(btnTransfer);
            pnlDashBoard.Controls.Add(btnAdd);
            pnlDashBoard.Dock = DockStyle.Left;
            pnlDashBoard.Location = new Point(0, 87);
            pnlDashBoard.Margin = new Padding(4);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(257, 838);
            pnlDashBoard.TabIndex = 3;
            // 
            // ptbClose
            // 
            ptbClose.BackColor = Color.FromArgb(67, 69, 94);
            ptbClose.BackgroundImageLayout = ImageLayout.None;
            ptbClose.Image = (Image)resources.GetObject("ptbClose.Image");
            ptbClose.Location = new Point(208, 34);
            ptbClose.Margin = new Padding(4);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(20, 20);
            ptbClose.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbClose.TabIndex = 0;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
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
            btnHome.Margin = new Padding(4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(13, 0, 0, 0);
            btnHome.Size = new Size(257, 88);
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
            btnTransfer.Location = new Point(0, 88);
            btnTransfer.Margin = new Padding(4);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Padding = new Padding(13, 0, 0, 0);
            btnTransfer.Size = new Size(257, 88);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = "  Transaction";
            btnTransfer.TextAlign = ContentAlignment.MiddleLeft;
            btnTransfer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
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
            btnAdd.Location = new Point(0, 176);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(13, 0, 0, 0);
            btnAdd.Size = new Size(257, 88);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "  Add User";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(36, 39, 59);
            pnlTitle.Controls.Add(ptbIcon);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Margin = new Padding(4);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1908, 87);
            pnlTitle.TabIndex = 0;
            // 
            // ptbIcon
            // 
            ptbIcon.BackColor = Color.FromArgb(36, 39, 59);
            ptbIcon.Image = (Image)resources.GetObject("ptbIcon.Image");
            ptbIcon.Location = new Point(15, 11);
            ptbIcon.Margin = new Padding(4);
            ptbIcon.Name = "ptbIcon";
            ptbIcon.Size = new Size(65, 65);
            ptbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbIcon.TabIndex = 5;
            ptbIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(96, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(321, 46);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Bank Management\r\n";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDesktop.BackColor = Color.FromArgb(221, 221, 235);
            panelDesktop.Location = new Point(257, 87);
            panelDesktop.Margin = new Padding(4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1651, 805);
            panelDesktop.TabIndex = 5;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1908, 925);
            Controls.Add(statusStrip);
            Controls.Add(panelDesktop);
            Controls.Add(pnlDashBoard);
            Controls.Add(pnlTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(1918, 961);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            Resize += FormMenu_Resize;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbIcon).EndInit();
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
        private Panel pnlDashBoard;
        private Panel pnlTitle;
        private Label lblTitle;
        private PictureBox ptbIcon;
        private Button btnHome;
        private Button btnAdd;
        private Button btnTransfer;
        private Panel panelDesktop;
        private PictureBox ptbClose;
    }
}