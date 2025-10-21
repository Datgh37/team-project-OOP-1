using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BankManagement
{
    public partial class FormMenu : Form
    {
        private System.Windows.Forms.Timer? _clockTimer;
        public FormMenu()
        {
            InitializeComponent();
            ConfigureMenu();
            StartClock();

            // Open FormMain on startup (optional)
            OpenChild<FormMain>();
        }
        private void ConfigureMenu()
        {
            // Attach event handler for Main Form menu item, using lambda expression
            tsmiMainForm.Click += (_, __) => OpenChild<FormMain>();
            //tsmiAddForm.Click += (_, __) => OpenChild<FormAdd>();
            //tsmiEditForm.Click += (_, __) => OpenChild<FormEdit>();
            //tsmiCustomerForm.Click += (_, __) => OpenChild<FormCustomer>();
            //tsmiTransactionForm.Click += (_, __) => OpenChild<FormTransaction>();
            //tsmiTransactionBillForm.Click += (_, __) => OpenChild<FormTransactionBill>();

            // Attach event handlers for MDI layout menu items
            tsmiCascade.Click += (_, __) => LayoutMdi(MdiLayout.Cascade);
            tsmiTileHorizontal.Click += (_, __) => LayoutMdi(MdiLayout.TileHorizontal);
            tsmiTileVertical.Click += (_, __) => LayoutMdi(MdiLayout.TileVertical);
            //tsiArrange.Click += (_, __) => LayoutMdi(MdiLayout.ArrangeIcons);

            // Set the MDI window list item for the Window menu
            //menuStrip1.MdiWindowListItem = windowMenu;
        }

        private void StartClock()
        {
            _clockTimer = new System.Windows.Forms.Timer { Interval = 1000, Enabled = true };
            _clockTimer.Tick += (_, __) => tslblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tslblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            tslblStatus.Text = "Ready";
        }
        // Ensures a single instance per form type and activates if already open
        private void OpenChild<TForm>() where TForm : Form, new()
        {
            var existing = MdiChildren.FirstOrDefault(f => f is TForm);
            if (existing != null)
            {
                existing.WindowState = FormWindowState.Maximized;
                existing.Activate();
                return;
            }

            var form = new TForm
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent
            };
            form.WindowState = FormWindowState.Normal;
            form.FormClosed += (_, __) => tslblStatus.Text = "Ready";
            // Change Status of the status label
            tslblStatus.Text = $"Opened {typeof(TForm).Name}";
            form.Show();
        }
        // Handle Icon for Maximized Child Form
        private void FormMenu_MdiChildActivate(object? sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.WindowState == FormWindowState.Maximized)
            {
                if (this.ActiveMdiChild.Icon != null)
                    this.Icon = this.ActiveMdiChild.Icon;
            }
        }
        // Handle Closing and Checks all remains Child Form 
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng tất cả form con
            foreach (var child in MdiChildren)
            {
                if (!child.IsDisposed)
                {
                    child.Close(); // Will call FormClosing/Closed in Child form
                    if (!child.IsDisposed) // If child form refuses to close (e.Cancel = true)
                    {
                        e.Cancel = true; // Cancel
                        return;
                    }
                }
            }
        }
    }
}

