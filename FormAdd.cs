using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormAdd : Form
    {
        private AccountManagement _accList;
        private CustomerManagement _custList;
        private readonly bool _isStandaloneMode;
        public Account? NewAccount { get; private set; }
        public Customer? NewCustomer { get; private set; }
        // FORM
        public FormAdd()
        {
            InitializeComponent();
            _isStandaloneMode = true;

            _accList = new AccountManagement();
            _custList = new CustomerManagement();

            try
            {
                _accList.ImportAccountListFromCSV();
                _custList.ImportCustomerListFromCSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            this.ActiveControl = txtFirstName;
        }

        public FormAdd(AccountManagement accountMgmt, CustomerManagement customerMgmt)
        {
            InitializeComponent();
            _isStandaloneMode = false;

            _accList = accountMgmt;
            _custList = customerMgmt;

            this.ActiveControl = txtFirstName;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            comboType.SelectedIndex = 0; // Default to Debit
            cboGender.SelectedIndex = -1; // No default gender
            txtBalance.Text = "0"; // Default Balance
        }
        // EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse account type
                AccountTypeEnum accType = comboType.SelectedIndex switch
                {
                    1 => AccountTypeEnum.Credit,
                    2 => AccountTypeEnum.Savings,
                    _ => AccountTypeEnum.Debit,
                };

                bool isCreditAccount = accType == AccountTypeEnum.Credit;

                // Empty Input Validation
                if (string.IsNullOrEmpty(txtCID.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    (!isCreditAccount && string.IsNullOrWhiteSpace(txtBalance.Text)))
                {
                    MessageBox.Show(
                        isCreditAccount
                            ? "Please enter all required fields: Citizen ID, Last Name, and First Name."
                            : "Please enter all required fields: Citizen ID, Last Name, First Name, and Balance.",
                        "Missing Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check duplicate CID and AccountType
                string cid = txtCID.Text.Trim();
                Customer? existingCustomer = _custList.FindByCID(cid);
                bool isNewCustomer = existingCustomer == null;

                // Kiểm tra họ tên khớp với data nếu customer đã tồn tại
                if (existingCustomer != null)
                {
                    string inputFirstName = txtFirstName.Text.Trim();
                    string inputLastName = txtLastName.Text.Trim();

                    if (existingCustomer.FirstName != inputFirstName ||
                        existingCustomer.LastName != inputLastName)
                    {
                        MessageBox.Show(
                            $"Name does not match existing data!\n\n" +
                            $"In the system:\n" +
                            $"  • Last name: {existingCustomer.LastName}\n" +
                            $"  • First name: {existingCustomer.FirstName}\n\n" +
                            $"You entered:\n" +
                            $"  • Last name: {inputLastName}\n" +
                            $"  • First name: {inputFirstName}\n\n" +
                            "Please check again!",
                            "Information Mismatch",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        txtFirstName.Focus();
                        return;
                    }

                    // Kiểm tra trùng loại tài khoản
                    if (_accList.HasAccountType(existingCustomer.UID, accType))
                    {
                        Account? existingAccount = _accList.GetAccountByCustomerAndType(existingCustomer.UID, accType);

                        MessageBox.Show(
                            $"The customer already has a {accType} account!\n\n" +
                            $"Customer information:\n" +
                            $"  • Name: {existingCustomer.FirstName} {existingCustomer.LastName}\n" +
                            $"  • CID: {existingCustomer.CID}\n\n" +
                            $"Existing account information:\n" +
                            $"  • Account number: {existingAccount?.AccountNumber}\n" +
                            $"  • Type: {accType}\n" +
                            $"  • Balance: {existingAccount?.Balance:N0} VND\n\n" +
                            "Each customer can only have ONE account of each type.\n" +
                            "Please select a different account type or use the existing account.",
                            "Account Already Exists",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        comboType.Focus();
                        return;
                    }

                    // Customer exists and name matches
                    DialogResult confirm = MessageBox.Show(
                        $"A customer with CID: {cid} already exists\n" +
                        $"Name: {existingCustomer.FirstName} {existingCustomer.LastName}\n\n" +
                        $"This customer does not have a {accType} account yet.\n" +
                        "Do you want to create a new account for this customer?",
                        "Create New Account",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.No)
                        return;
                }

                // Parse gender
                Gender gender = Enum.TryParse(cboGender.SelectedItem?.ToString() ?? cboGender.Text, out Gender genderValue)
                    ? genderValue
                    : Gender.None;

                // Parse balance
                double balance = 0;
                if (!isCreditAccount)
                {
                    if (!double.TryParse(txtBalance.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out balance) || balance < 0)
                    {
                        MessageBox.Show("Balance must be a valid positive number.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBalance.Focus();
                        return;
                    }
                }

                // Create or reuse Customer
                Customer createdCustomer;

                if (isNewCustomer)
                {
                    createdCustomer = new Customer(txtLastName.Text.Trim(), txtFirstName.Text.Trim(),
                        cid, "", "", "", dtpDoB.Value, gender);
                }
                else
                {
                    createdCustomer = existingCustomer!;
                }

                // Create Account
                Account createdAccount = new Account(accType, balance, createdCustomer);

                // LOGIC PHÂN NHÁNH: Standalone vs Called from FormMain
                if (_isStandaloneMode)
                {
                    try
                    {
                        if (isNewCustomer)
                            _custList.AddCustomer(createdCustomer);

                        _accList.AddAccount(createdAccount);

                        // Save to CSV in standalone mode
                        _custList.SaveCustomersToCSV();
                        _accList.SaveAccountsToCSV();

                        MessageBox.Show(
                            $"Account created successfully!\n\n" +
                            $"Account number: {createdAccount.AccountNumber}\n" +
                            $"Account type: {accType}\n" +
                            $"Account holder: {createdCustomer.FirstName} {createdCustomer.LastName}\n" +
                            $"Initial balance: {balance:N0} VND",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        // Rollback on error
                        if (isNewCustomer)
                            _custList.RemoveCustomer(createdCustomer);
                        _accList.RemoveAccount(createdAccount);

                        MessageBox.Show(
                            $"Error while saving data:\n{ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                }
                else
                {
                    // Called from FormMain: Add directly to shared reference
                    // No need to copy lists or expose them
                    if (isNewCustomer)
                        _custList.AddCustomer(createdCustomer);

                    _accList.AddAccount(createdAccount);
                }

                // Expose created objects for caller
                NewCustomer = createdCustomer;
                NewAccount = createdAccount;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while creating: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountTypeEnum selectedType = comboType.SelectedIndex switch
            {
                1 => AccountTypeEnum.Credit,
                2 => AccountTypeEnum.Savings,
                _ => AccountTypeEnum.Debit
            };

            bool isCreditAccount = selectedType == AccountTypeEnum.Credit;

            txtBalance.Enabled = !isCreditAccount;
            lblBalance.Enabled = !isCreditAccount;

            if (isCreditAccount)
            {
                txtBalance.Text = "0";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtBalance.Text))
                    txtBalance.Text = "0";
            }
        }
        private void txtCID_TextChanged(object sender, EventArgs e)
        {
            string cid = txtCID.Text.Trim();

            // Chỉ query khi đủ 9 ký tự
            if (cid.Length != 9)
            {
                txtCID.BackColor = SystemColors.Window;

                // Reset lại trạng thái khi chưa đủ 9 ký tự
                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                dtpDoB.Enabled = true;
                cboGender.Enabled = true;

                return;
            }

            // Tìm customer theo CID
            Customer? existingCustomer = _custList.FindByCID(cid);

            if (existingCustomer != null)
            {
                // Autofill thông tin
                txtFirstName.Text = existingCustomer.FirstName;
                txtLastName.Text = existingCustomer.LastName;

                dtpDoB.Value = existingCustomer.BirthDate;

                // Set theo SelectedIndex (Vì DropDownStyle = DropDownList)
                cboGender.SelectedIndex = (int)existingCustomer.Gender;

                // Đổi màu nền để báo hiệu đã tìm thấy
                txtCID.BackColor = Color.LightGreen;

                // Lock các field để không cho sửa
                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                dtpDoB.Enabled = false;
                cboGender.Enabled = false;

                // Reset balance
                txtBalance.Text = "0";
            }
            else
            {
                // Không tìm thấy -> cho phép nhập mới
                txtCID.BackColor = Color.LightYellow;

                // Clear các field
                txtFirstName.Clear();
                txtLastName.Clear();
                dtpDoB.Value = DateTime.Now;
                cboGender.SelectedIndex = -1;

                // Unlock các field
                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                dtpDoB.Enabled = true;
                cboGender.Enabled = true;

                // Reset balance
                txtBalance.Text = "0";
            }
        }
        private void ResetForm()
        {
            // Reset các field về trạng thái ban đầu
            txtCID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBalance.Text = "0";
            dtpDoB.Value = DateTime.Now;

            comboType.SelectedIndex = 0; // Debit
            cboGender.SelectedIndex = -1; // None

            // Reset màu nền
            txtCID.BackColor = SystemColors.Window;

            // Unlock tất cả fields
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            dtpDoB.Enabled = true;
            cboGender.Enabled = true;
            txtBalance.Enabled = true;
            lblBalance.Enabled = true;

            // Focus vào field đầu tiên
            txtCID.Focus();
        }
    }
}
