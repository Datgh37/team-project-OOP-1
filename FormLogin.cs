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
        public FormLogin()
        {
            InitializeComponent();

            // Ẩn nút phóng to
            this.MaximizeBox = false;

            // (tuỳ chọn) không cho resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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
            // xóa lỗi cũ trước khi kiểm tra
            errorProvider1.Clear();
            bool isValid = true;

            //kiểm tra Username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập");
                isValid = false;
            }

            //kiểm tra Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu");
                isValid = false;
            }

            //nếu hợp lệ, kiểm tra thông tin đăng nhập
            if (isValid)
            {
                MessageBox.Show("Đăng nhập hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
