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
        private Panel panelMenu;
        private Button currentBtn;
        private Form activeForm = null;
        public Action OnAddButtonClick;
        public Action OnTransferButtonClick;
        private System.Windows.Forms.Timer? _clockTimer;
        public FormMenu()
        {
            InitializeComponent();
            StartClock();
            pictureBoxClose.Visible = false;
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Start the parent form fullscreen
            this.WindowState = FormWindowState.Maximized;

            // Ensure child visibility follows parent window state
            this.Resize += FormMenu_Resize;
        }
        private void StartClock()
        {
            _clockTimer = new System.Windows.Forms.Timer { Interval = 1000, Enabled = true };
            _clockTimer.Tick += (_, __) => tslblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tslblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            tslblStatus.Text = "Ready";
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(67, 69, 94);
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(50, 52, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                // Đóng form con trước đó
                activeForm.Close();
            }

            ActivateButton(btnSender);

            activeForm = childForm;

            // Prepare the form for embedding inside panelDesktop.
            // Important: ensure the child is in Normal state so Dock = Fill behaves correctly
            childForm.TopLevel = false; // Đảm bảo không là cửa sổ riêng
            childForm.ShowInTaskbar = false; // avoid separate taskbar entry
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Normal; // reset any designer Maximized
            childForm.Dock = DockStyle.Fill;
            //childForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Gắn form con vào panel cha
            panelDesktop.Controls.Clear(); // Nên clear tránh chồng form
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        // Keep child visibility/sizing in sync when parent is minimized/restored
        private void FormMenu_Resize(object? sender, EventArgs e)
        {
            if (activeForm == null) return;

            if (this.WindowState == FormWindowState.Minimized)
            {
                // Hide embedded form (prevents it appearing in taskbar or staying visible)
                activeForm.Visible = false;
            }
            else
            {
                // Restore visibility and ensure layout is correct
                activeForm.Visible = true;
                activeForm.WindowState = FormWindowState.Normal;
                // Ensure docking/size recomputed
                activeForm.Dock = DockStyle.Fill;
                activeForm.BringToFront();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain(this), sender);
            pictureBoxClose.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnTransferButtonClick?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnAddButtonClick?.Invoke();
        }
        private void Reset()
        {
            DisableButton();
            currentBtn = null;
            pictureBoxClose.Visible = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        
    }
}

