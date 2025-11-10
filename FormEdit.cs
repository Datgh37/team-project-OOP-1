using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormEdit : Form
    {
        public Account SelectedAccount { get; private set; }
        public Customer SelectedCustomer { get; private set; }
        // Track Name changes to sync with all account owned by 1 customer
        private string _originalFirstName;
        private string _originalLastName;

        public FormEdit(Account account, Customer customer)
        {
            InitializeComponent();
            SelectedAccount = new Account(account);
            SelectedCustomer = new Customer(customer);

            // Lưu tên gốc để so sánh
            _originalFirstName = customer.FirstName;
            _originalLastName = customer.LastName;

            this.ActiveControl = txtFirstName;
            txtFirstName.Focus();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            txtUID.Text = SelectedCustomer.UID.ToString();
            txtCID.Text = SelectedCustomer.CID;
            txtFirstName.Text = SelectedCustomer.FirstName;
            txtLastName.Text = SelectedCustomer.LastName;
            txtAddress.Text = SelectedCustomer.Address;
            txtEmail.Text = SelectedCustomer.Email;
            txtPhone.Text = SelectedCustomer.Phone;
            dtpDoB.Text = SelectedCustomer.BirthDate.ToString();
            cboGender.Text = SelectedCustomer.Gender.ToString();
            txtBalance.Text = SelectedAccount.Balance.ToString("N2");
            txtInterestRate.Text = SelectedAccount.InterestRate.ToString();
            lblAccTypeInfo.Text = SelectedAccount.GetAccountType();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtBalance.Text) ||
                    string.IsNullOrWhiteSpace(dtpDoB.Text))
                {
                    MessageBox.Show("Please fill in all required fields!", "Missing Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem họ tên có thay đổi không
                bool nameChanged = txtFirstName.Text.Trim() != _originalFirstName ||
                                   txtLastName.Text.Trim() != _originalLastName;

                // Update Customer
                SelectedCustomer.UpdateInfo(
                    txtLastName.Text.Trim(),
                    txtFirstName.Text.Trim(),
                    txtCID.Text,
                    txtAddress.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    dtpDoB.Value.ToString("dd/MM/yyyy"),
                    Enum.TryParse(cboGender.Text, out Gender g) ? g : Gender.None
                );

                // Update Account
                if (!double.TryParse(txtBalance.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double balance))
                {
                    MessageBox.Show("Số dư không hợp lệ!", "Lỗi nhập liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(txtInterestRate.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double rate))
                {
                    MessageBox.Show("Mức lãi không hợp lệ!, Kiểm tra input", "Lỗi nhập liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SelectedAccount.SetBalance(balance);
                SelectedAccount.ChangeInterestRate(rate);

                // Nếu tên đã thay đổi, hiển thị cảnh báo
                if (nameChanged)
                {
                    DialogResult result = MessageBox.Show(
                        $"Bạn đã thay đổi họ tên khách hàng:\n\n" +
                        $"Từ: {_originalLastName} {_originalFirstName}\n" +
                        $"Thành: {txtLastName.Text.Trim()} {txtFirstName.Text.Trim()}\n\n" +
                        "LƯU Ý: Tên sẽ được cập nhật cho TẤT CẢ tài khoản của khách hàng này!\n\n" +
                        "Bạn có chắc chắn muốn tiếp tục?",
                        "Xác nhận thay đổi họ tên",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                        return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
