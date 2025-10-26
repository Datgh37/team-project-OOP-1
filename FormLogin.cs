using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormLogin : Form
    {
        // Tạo dữ liệu tài khoản mẫu
        private readonly Dictionary<string, string> accounts = new()
        {
            { "Dat", "1" },
            { "Bao", "2" },
            { "Khang", "3" },
            { "Sau", "4" }
        };

        private int remainingAttempts = 5;

        public FormLogin()
        {
            InitializeComponent();

            txtUsername.Focus(); // Đặt con trỏ vào ô Username khi form mở
            this.ActiveControl = txtUsername;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;
            bool usernameError = false;
            bool passwordError = false;

            // Kiểm tra Username / Password có rỗng hay không
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập");
                isValid = false;
                usernameError = true;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu");
                isValid = false;
                passwordError = true;
            }
            // Đối chiếu dữ liệu tài khoản
            if (isValid)
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                try
                {
                    bool userExists = accounts.TryGetValue(username, out string correctPassword);
                    bool passCorrect = userExists && password == correctPassword;

                    if (userExists && passCorrect)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        remainingAttempts--;

                        // Kiểm tra lỗi từng trường
                        if (!userExists)
                        {
                            errorProvider1.SetError(txtUsername, "Tên đăng nhập không đúng");
                            txtUsername.Focus();
                            txtUsername.SelectAll();
                        }
                        if (userExists && password != correctPassword)
                        {
                            errorProvider1.SetError(txtPassword, "Mật khẩu không đúng");
                            txtPassword.Focus();
                            txtPassword.SelectAll();
                        }
                        if (!userExists && password != correctPassword)
                        {
                            // Nếu cả hai đều sai, báo lỗi cả hai, đặt focus vào username
                            txtUsername.Focus();
                            txtUsername.SelectAll();
                        }

                        if (remainingAttempts > 0)
                        {
                            MessageBox.Show($"Sai thông tin đăng nhập.\nBạn còn {remainingAttempts} lần thử.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else // Hết số lần thử là hiện thông báo, đóng thông báo sau 1s tự đóng ct
                        {
                            var dialog = MessageBox.Show($"Sai thông tin đăng nhập.\n" +
                                $"Bạn đã hết lần thử.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (dialog == DialogResult.OK)
                            {
                                btnLogin.Enabled = false;
                                lblShutDownMessage.Text = "Used All Attempt, Exiting...";
                                lblShutDownMessage.Visible = true;
                                var shutdownTimer = new System.Windows.Forms.Timer();
                                shutdownTimer.Interval = 1000; // 1 seconds
                                shutdownTimer.Tick += (s, args) =>
                                {
                                    shutdownTimer.Stop();
                                    Application.Exit();
                                };
                                shutdownTimer.Start();
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Đặt focus vào trường đầu tiên bị lỗi
                if (usernameError)
                {
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                }
                else if (passwordError)
                {
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                }
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            // Khi checkbox được chọn, hiển thị mật khẩu
            chkShow.Text = chkShow.Checked == true ? "Hide" : "Show";
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnlForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hãy liên hệ admin để đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
