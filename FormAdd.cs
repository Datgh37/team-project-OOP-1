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

            // ✅ Sử dụng trực tiếp reference, KHÔNG tạo copy
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
                            ? "Vui lòng nhập đầy đủ số CCCD, Họ và Tên."
                            : "Vui lòng nhập đầy đủ số CCCD, Họ, Tên và Số dư.",
                        "Thiếu thông tin",
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
                            $"Họ tên không khớp với dữ liệu!\n\n" +
                            $"Trong hệ thống:\n" +
                            $"  • Họ: {existingCustomer.LastName}\n" +
                            $"  • Tên: {existingCustomer.FirstName}\n\n" +
                            $"Bạn nhập:\n" +
                            $"  • Họ: {inputLastName}\n" +
                            $"  • Tên: {inputFirstName}\n\n" +
                            "Vui lòng kiểm tra lại!",
                            "Thông tin không khớp",
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
                            $"Khách hàng đã có tài khoản {accType}!\n\n" +
                            $"Thông tin khách hàng:\n" +
                            $"  • Tên: {existingCustomer.FirstName} {existingCustomer.LastName}\n" +
                            $"  • CID: {existingCustomer.CID}\n\n" +
                            $"Thông tin tài khoản hiện có:\n" +
                            $"  • Số tài khoản: {existingAccount?.AccountNumber}\n" +
                            $"  • Loại: {accType}\n" +
                            $"  • Số dư: {existingAccount?.Balance:N0} VND\n\n" +
                            "Mỗi khách hàng chỉ được có MỘT tài khoản mỗi loại.\n" +
                            "Vui lòng chọn loại tài khoản khác hoặc sử dụng tài khoản hiện có.",
                            "Tài khoản đã tồn tại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        comboType.Focus();
                        return;
                    }

                    // Customer exists and name matches
                    DialogResult confirm = MessageBox.Show(
                        $"Đã tồn tại khách hàng với CID: {cid}\n" +
                        $"Tên: {existingCustomer.FirstName} {existingCustomer.LastName}\n\n" +
                        $"Khách hàng này chưa có tài khoản {accType}.\n" +
                        "Bạn có muốn tạo tài khoản mới cho khách hàng này?",
                        "Tạo tài khoản mới",
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
                        MessageBox.Show("Số dư phải là số dương hợp lệ.", "Lỗi nhập liệu",
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
                            $"Tạo tài khoản thành công!\n\n" +
                            $"Số tài khoản: {createdAccount.AccountNumber}\n" +
                            $"Loại tài khoản: {accType}\n" +
                            $"Chủ tài khoản: {createdCustomer.FirstName} {createdCustomer.LastName}\n" +
                            $"Số dư ban đầu: {balance:N0} VND",
                            "Thành công",
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
                            $"Lỗi khi lưu dữ liệu:\n{ex.Message}",
                            "Lỗi",
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
                MessageBox.Show($"Lỗi khi tạo: {ex.Message}", "Error",
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
