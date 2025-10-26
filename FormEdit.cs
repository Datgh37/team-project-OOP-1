using BankManagement.Models;
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
    public partial class FormEdit : Form
    {
        public Account SelectedAccount { get; private set; }
        public Customer SelectedCustomer { get; private set; }

        public FormEdit(Account account, Customer customer)
        {
            InitializeComponent();
            // Clone để tránh sửa trực tiếp object gốc
            SelectedAccount = new Account(account);
            SelectedCustomer = new Customer(customer);
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
                    MessageBox.Show("Please fill in all required fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Cập nhật lại thông tin từ control vào object
                // Update Customer
                SelectedCustomer.UpdateInfo(
                    txtLastName.Text,
                    txtFirstName.Text,
                    txtCID.Text,
                    txtAddress.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    dtpDoB.Value.ToString("dd/MM/yyyy"),
                    Enum.TryParse(cboGender.Text, out Gender g) ? g : Gender.None
                );
                // Update Account
                if (!double.TryParse(txtBalance.Text, out double balance))
                {
                    MessageBox.Show("Số dư không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(txtInterestRate.Text, out double rate))
                {
                    MessageBox.Show("Mức lãi không hợp lệ!, Kiểm tra input", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SelectedAccount.SetBalance(balance);
                SelectedAccount.ChangeInterestRate(rate);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
