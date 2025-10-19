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
            // Attach event handler for Main Form menu item
            tsiMainForm.Click += (_, __) => OpenChild<FormMain>();

            // Attach event handlers for MDI layout menu items
            tsiCascade.Click += (_, __) => LayoutMdi(MdiLayout.Cascade);
            tsiTileHorizontal.Click += (_, __) => LayoutMdi(MdiLayout.TileHorizontal);
            tsiTileVertical.Click += (_, __) => LayoutMdi(MdiLayout.TileVertical);
            //tsiArrange.Click += (_, __) => LayoutMdi(MdiLayout.ArrangeIcons);

            // Attach event handler for Exit menu item
            //miExit.Click += (_, __) => Close();

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
            else
            {
                // Có thể đặt lại icon mặc định nếu không có form con hoặc không maximize
                // this.Icon = Properties.Resources.DefaultIcon; // Nếu có icon mặc định
            }
        }
    }
}

