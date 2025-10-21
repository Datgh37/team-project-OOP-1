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
            tsmiMainForm = new ToolStripMenuItem();
            tsmiAddForm = new ToolStripMenuItem();
            tsmiEditForm = new ToolStripMenuItem();
            tsmiCustomerForm = new ToolStripMenuItem();
            tsmiTransactionForm = new ToolStripMenuItem();
            tsmiTransactionBillForm = new ToolStripMenuItem();
            tsiMenu = new ToolStripMenuItem();
            tsmiCascade = new ToolStripMenuItem();
            tsmiTileHorizontal = new ToolStripMenuItem();
            tsmiTileVertical = new ToolStripMenuItem();
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
            tsiForms.DropDownItems.AddRange(new ToolStripItem[] { tsmiMainForm, tsmiAddForm, tsmiEditForm, tsmiCustomerForm, tsmiTransactionForm, tsmiTransactionBillForm });
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
            // tsmiEditForm
            // 
            tsmiEditForm.Name = "tsmiEditForm";
            tsmiEditForm.Size = new Size(173, 26);
            tsmiEditForm.Text = "Edit";
            // 
            // tsmiCustomerForm
            // 
            tsmiCustomerForm.Name = "tsmiCustomerForm";
            tsmiCustomerForm.Size = new Size(173, 26);
            tsmiCustomerForm.Text = "Customer";
            // 
            // tsmiTransactionForm
            // 
            tsmiTransactionForm.Name = "tsmiTransactionForm";
            tsmiTransactionForm.Size = new Size(173, 26);
            tsmiTransactionForm.Text = "Transaction";
            // 
            // tsmiTransactionBillForm
            // 
            tsmiTransactionBillForm.Name = "tsmiTransactionBillForm";
            tsmiTransactionBillForm.Size = new Size(173, 26);
            tsmiTransactionBillForm.Text = "Bill";
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
            FormClosing += FormMenu_FormClosing;
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
        private ToolStripMenuItem tsmiCascade;
        private ToolStripMenuItem tsmiTileHorizontal;
        private ToolStripMenuItem tsmiTileVertical;
        private ToolStripMenuItem tsmiMainForm;
        private ToolStripMenuItem tsmiAddForm;
        private ToolStripMenuItem tsmiEditForm;
        private ToolStripMenuItem tsmiTransactionForm;
        private ToolStripMenuItem tsmiTransactionBillForm;
        private ToolStripMenuItem tsmiCustomerForm;
    }
}