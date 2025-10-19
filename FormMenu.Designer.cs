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
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            tslblStatus = new ToolStripStatusLabel();
            tslblDateTime = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            tsiForms = new ToolStripMenuItem();
            tsiMainForm = new ToolStripMenuItem();
            tsiMenu = new ToolStripMenuItem();
            tsiCascade = new ToolStripMenuItem();
            tsiTileHorizontal = new ToolStripMenuItem();
            tsiTileVertical = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tslblStatus, tslblDateTime });
            statusStrip.Location = new Point(0, 539);
            statusStrip.Name = "statusStrip";
            statusStrip.RightToLeft = RightToLeft.Yes;
            statusStrip.Size = new Size(1084, 27);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Status Bar";
            // 
            // tslblStatus
            // 
            tslblStatus.Name = "tslblStatus";
            tslblStatus.Size = new Size(53, 21);
            tslblStatus.Text = "Ready";
            // 
            // tslblDateTime
            // 
            tslblDateTime.Name = "tslblDateTime";
            tslblDateTime.Size = new Size(76, 21);
            tslblDateTime.Text = "DateTime";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsiForms, tsiMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsiForms
            // 
            tsiForms.DropDownItems.AddRange(new ToolStripItem[] { tsiMainForm });
            tsiForms.Name = "tsiForms";
            tsiForms.Size = new Size(68, 25);
            tsiForms.Text = "Forms";
            // 
            // tsiMainForm
            // 
            tsiMainForm.Name = "tsiMainForm";
            tsiMainForm.Size = new Size(224, 26);
            tsiMainForm.Text = "Main";
            // 
            // tsiMenu
            // 
            tsiMenu.DropDownItems.AddRange(new ToolStripItem[] { tsiCascade, tsiTileHorizontal, tsiTileVertical });
            tsiMenu.Name = "tsiMenu";
            tsiMenu.Size = new Size(82, 25);
            tsiMenu.Text = "Window";
            // 
            // tsiCascade
            // 
            tsiCascade.Name = "tsiCascade";
            tsiCascade.Size = new Size(194, 26);
            tsiCascade.Text = "Cascade";
            // 
            // tsiTileHorizontal
            // 
            tsiTileHorizontal.Name = "tsiTileHorizontal";
            tsiTileHorizontal.Size = new Size(194, 26);
            tsiTileHorizontal.Text = "Tile Horizontal";
            // 
            // tsiTileVertical
            // 
            tsiTileVertical.Name = "tsiTileVertical";
            tsiTileVertical.Size = new Size(194, 26);
            tsiTileVertical.Text = "Tile Vertical";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1084, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 10);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 566);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            MdiChildActivate += FormMenu_MdiChildActivate;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel tslblStatus;
        private ToolStripStatusLabel tslblDateTime;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsiForms;
        private ToolStripMenuItem tsiMenu;
        private ToolStripMenuItem tsiCascade;
        private ToolStripMenuItem tsiTileHorizontal;
        private ToolStripMenuItem tsiTileVertical;
        private ToolStripMenuItem tsiMainForm;
    }
}