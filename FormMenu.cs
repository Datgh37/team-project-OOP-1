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
        private Button? currentBtn;
        private Form? activeForm = null;
        public Action OnAddButtonClick; // Trỏ đến OpenFormAdd() của FormMain nếu được gọi
        public Action OnTransferButtonClick; // Trỏ đến OpenFormTransaction() của FormMain nếu được gọi
        private FormMain? _mainFormInstance; // Cache cho instance FormMain
        private System.Windows.Forms.Timer? _clockTimer; // Tạo bộ đếm giờ thời gian thực
        
        // FORM
        public FormMenu()
        {
            InitializeComponent();
            StartClock();
            ptbClose.Visible = false;
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain(this), btnHome);
            ptbClose.Visible = true;
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
        // Handle Closing and Checks all remains Child Form 
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra form đang embedded trong panel
            if (activeForm != null && !activeForm.IsDisposed)
            {
                // Trigger FormClosing event của child form
                var closingArgs = new FormClosingEventArgs(CloseReason.UserClosing, false);
                
                // Manually invoke FormClosing để cho phép child form xử lý unsaved changes
                // Cast để access protected method OnFormClosing
                var onFormClosingMethod = typeof(Form).GetMethod("OnFormClosing", 
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                
                if (onFormClosingMethod != null)
                {
                    onFormClosingMethod.Invoke(activeForm, new object[] { closingArgs });
                    
                    // Nếu child form cancel (có unsaved data)
                    if (closingArgs.Cancel)
                    {
                        e.Cancel = true; // Hủy đóng FormMenu
                        return;
                    }
                }
                
                // Nếu child form cho phép đóng
                activeForm.Close();
                activeForm = null;
            }
        }
        // CUSTOM METHODS
        private void StartClock()
        {
            const string dateTimeFormat = "dd-MM-yyyy HH:mm:ss";
            
            _clockTimer = new System.Windows.Forms.Timer { Interval = 1000, Enabled = true };
            _clockTimer.Tick += (_, __) => tslblDateTime.Text = DateTime.Now.ToString(dateTimeFormat);
            tslblDateTime.Text = DateTime.Now.ToString(dateTimeFormat);
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
            foreach (Control previousBtn in pnlDashBoard.Controls)
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
            // Validate parameters
            if (childForm == null)
                throw new ArgumentNullException(nameof(childForm));
            
            if (panelDesktop == null)
                throw new InvalidOperationException("panelDesktop is not initialized");

            // Close previous form
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
                
                // Nếu user cancel close (e.g., unsaved changes)
                if (!activeForm.IsDisposed)
                {
                    childForm.Dispose(); // Cleanup the new form
                    return; // Không mở form mới
                }
            }

            ActivateButton(btnSender);
            activeForm = childForm;

            // Prepare embedded form
            childForm.TopLevel = false;
            childForm.ShowInTaskbar = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Normal;
            childForm.Dock = DockStyle.Fill;

            // Add to panel
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            
            // Update status
            tslblStatus.Text = $"Opened {childForm.GetType().Name.Replace("Form", "")}";
        }

        // EVENTS
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Nếu đã có instance và đang hiển thị
            if (activeForm is FormMain)
            {
                return;
            }
            // Nếu instance đã bị dispose hoặc chưa tạo
            if (_mainFormInstance == null || _mainFormInstance.IsDisposed)
            {
                _mainFormInstance = new FormMain(this);
            }
            
            OpenChildForm(_mainFormInstance, sender);
            ptbClose.Visible = true;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OnTransferButtonClick?.Invoke();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAddButtonClick?.Invoke();
        }

        private void Reset()
        {
            DisableButton();
            currentBtn = null;
            ptbClose.Visible = false;
            panelDesktop.Controls.Clear(); // ✅ Clear panel khi reset
            activeForm = null;
            tslblStatus.Text = "Ready";
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            Reset();
        }

        
    }
}

