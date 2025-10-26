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
            // Ẩn ký tự mật khẩu
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;
            bool usernameError = false;
            bool passwordError = false;

            // kiểm tra Username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập");
                isValid = false;
                usernameError = true;
            }

            // kiểm tra Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu");
                isValid = false;
                passwordError = true;
            }

            // Nếu đã hết số lần thử, bấm login là sập chương trình ngay
            if (remainingAttempts <= 0)
            {
                Application.Exit();
                return;
            }

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
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
