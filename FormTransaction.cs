using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormTransaction : Form
    {
        // FIELD & PROPERTIES
        public Account? TransferAccount { get; set; } // optional pre-filled account
        private readonly AccountManagement _accountMgr; // added to lookup balances
        private readonly CustomerManagement _customerMgr; // added to lookup names
        private TransactionType _mode = TransactionType.Transfer; // Default mode
        // FORM
        public FormTransaction()
        {
            InitializeComponent();

            this.ActiveControl = txtFromAcc;
            txtFromAcc.Focus();

            // initialize account manager and try to load accounts (silent on error)
            _accountMgr = new AccountManagement();
            _customerMgr = new CustomerManagement();
            try
            {
                _accountMgr.ImportAccountListFromCSV();
                _customerMgr.ImportCustomerListFromCSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while trying to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormTransaction(Account account) : this()
        {
            TransferAccount = new Account(account);
            txtFromAcc.Text = account.AccountNumber;
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            ClearAllLabels();
        }

        // METHODS
        // Helper method để clear tất cả labels
        private void ClearAllLabels()
        {
            lblSender.Text = "";
            lblReceiver.Text = "";
            lblFromAccType.Text = "";
            lblToAccType.Text = "";
            lblMoney.Text = "";
        }

        // Helper method để update và display thông tin tài khoản nguồn
        private void DisplayFromAccountInfo(string accNum)
        {
            if (string.IsNullOrEmpty(accNum))
            {
                lblSender.Text = "";
                lblFromAccType.Text = "";
                lblMoney.Text = "";
                return;
            }

            Account? acc = _accountMgr[accNum];
            if (acc != null)
            {
                // Hiển thị số dư
                lblMoney.Text = $"{acc.Balance:N0} VND";
                
                // Hiển thị loại tài khoản
                lblFromAccType.Text = "Type: " + acc.Type.AccType;

                // Lấy thông tin khách hàng
                Customer? customer = _customerMgr.FindById(acc.CustomerID);
                if (customer != null)
                {
                    lblSender.Text = $"{customer.LastName} {customer.FirstName}";
                }
                else
                {
                    lblSender.Text = "Unknown";
                }
            }
            else
            {
                lblMoney.Text = "Account not found";
                lblSender.Text = "";
                lblFromAccType.Text = "";
            }
        }

        // Helper method để update và display thông tin tài khoản đích
        private void DisplayToAccountInfo(string accNum)
        {
            if (string.IsNullOrEmpty(accNum))
            {
                lblReceiver.Text = "";
                lblToAccType.Text = "";
                return;
            }

            Account? acc = _accountMgr[accNum];
            if (acc != null)
            {
                // Hiển thị loại tài khoản
                lblToAccType.Text = "Type: " + acc.Type.AccType;

                // Lấy thông tin khách hàng
                Customer? customer = _customerMgr.FindById(acc.CustomerID);
                if (customer != null)
                {
                    lblReceiver.Text = $"{customer.LastName} {customer.FirstName}";
                }
                else
                {
                    lblReceiver.Text = "Unknown";
                }
            }
            else
            {
                lblReceiver.Text = "";
                lblToAccType.Text = "";
            }
        }
        // Validate method
        private bool ValidateDepositTransaction(string toAcc, out Account? toAccount, out Customer? receiverCustomer)
        {
            toAccount = null;
            receiverCustomer = null;

            if (string.IsNullOrEmpty(toAcc))
            {
                MessageBox.Show("Vui lòng nhập tài khoản nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToAcc.Focus();
                return false;
            }

            toAccount = _accountMgr[toAcc];
            if (toAccount == null)
            {
                MessageBox.Show("Tài khoản nhận không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToAcc.Focus();
                return false;
            }

            receiverCustomer = _customerMgr.FindById(toAccount.CustomerID);
            return true;
        }

        private bool ValidateWithdrawTransaction(string fromAcc, double amount, out Account? fromAccount, out Customer? senderCustomer)
        {
            fromAccount = null;
            senderCustomer = null;

            if (string.IsNullOrEmpty(fromAcc))
            {
                MessageBox.Show("Vui lòng nhập tài khoản nguồn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFromAcc.Focus();
                return false;
            }

            fromAccount = _accountMgr[fromAcc];
            if (fromAccount == null)
            {
                MessageBox.Show("Tài khoản nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFromAcc.Focus();
                return false;
            }

            // Kiểm tra cho Debit/Savings - Số dư không đủ
            if (!fromAccount.Type.AllowOverdraft && fromAccount.Balance < amount)
            {
                MessageBox.Show(
                    $"Số dư không đủ cho giao dịch này.\n\n" +
                    $"Số dư hiện tại: {fromAccount.Balance:N0} VND\n" +
                    $"Số tiền cần rút: {amount:N0} VND\n" +
                    $"Còn thiếu: {(amount - fromAccount.Balance):N0} VND",
                    "Số dư không đủ", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtAmount.Focus();
                return false;
            }

            // Kiểm tra cho Credit - Vượt hạn mức tín dụng
            if (fromAccount.Type.AllowOverdraft && (fromAccount.Balance - amount) < -fromAccount.Type.CreditLimit)
            {
                double currentDebt = Math.Max(0, -fromAccount.Balance); 
                double availableCredit = fromAccount.Type.CreditLimit - currentDebt;
                double totalAvailable = fromAccount.Balance + fromAccount.Type.CreditLimit;
                double exceededAmount = amount - totalAvailable;
                
                MessageBox.Show(
                    $"Vượt quá hạn mức tín dụng!\n\n" +
                    $"Thông tin tài khoản Credit:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Số dư hiện tại: {fromAccount.Balance:N0} VND\n" +
                    $"Nợ hiện tại: {currentDebt:N0} VND\n" +
                    $"Hạn mức tín dụng: {fromAccount.Type.CreditLimit:N0} VND\n" +
                    $"Số tiền khả dụng: {availableCredit:N0} VND\n\n" +
                    $"Giao dịch:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Số tiền muốn rút: {amount:N0} VND\n" +
                    $"Vượt quá: {exceededAmount:N0} VND",
                    "Vượt hạn mức tín dụng", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            senderCustomer = _customerMgr.FindById(fromAccount.CustomerID);
            return true;
        }

        private bool ValidateTransferTransaction(string fromAcc, string toAcc, double amount,
            out Account? fromAccount, out Account? toAccount, out Customer? senderCustomer, out Customer? receiverCustomer)
        {
            fromAccount = null;
            toAccount = null;
            senderCustomer = null;
            receiverCustomer = null;

            if (string.IsNullOrEmpty(fromAcc) || string.IsNullOrEmpty(toAcc))
            {
                MessageBox.Show("Vui lòng nhập cả tài khoản nguồn và tài khoản đích.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fromAcc == toAcc)
            {
                MessageBox.Show("Không thể chuyển tiền cho cùng một tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            fromAccount = _accountMgr[fromAcc];
            if (fromAccount == null)
            {
                MessageBox.Show("Tài khoản nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFromAcc.Focus();
                return false;
            }

            toAccount = _accountMgr[toAcc];
            if (toAccount == null)
            {
                MessageBox.Show("Tài khoản nhận không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToAcc.Focus();
                return false;
            }


            if (!fromAccount.Type.CanTransfer)
            {
                MessageBox.Show(
                    $"Tài khoản {fromAccount.Type.AccType} không được phép chuyển tiền.\n\n" +
                    $"Chỉ tài khoản Debit và Credit mới có thể thực hiện chuyển khoản.",
                    "Không có quyền chuyển tiền", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số dư cho Debit/Savings
            if (!fromAccount.Type.AllowOverdraft && fromAccount.Balance < amount)
            {
                MessageBox.Show(
                    $"Số dư không đủ cho giao dịch này.\n\n" +
                    $"Số dư hiện tại: {fromAccount.Balance:N0} VND\n" +
                    $"Số tiền chuyển: {amount:N0} VND\n" +
                    $"Còn thiếu: {(amount - fromAccount.Balance):N0} VND",
                    "Số dư không đủ", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtAmount.Focus();
                return false;
            }

            // Kiểm tra hạn mức Credit
            if (fromAccount.Type.AllowOverdraft && (fromAccount.Balance - amount) < -fromAccount.Type.CreditLimit)
            {
                double currentDebt = Math.Max(0, -fromAccount.Balance);
                double availableCredit = fromAccount.Type.CreditLimit - currentDebt;
                double totalAvailable = fromAccount.Balance + fromAccount.Type.CreditLimit;
                double exceededAmount = amount - totalAvailable;
                
                MessageBox.Show(
                    $"Vượt quá hạn mức tín dụng!\n\n" +
                    $"Thông tin tài khoản Nguồn:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Số dư hiện tại: {fromAccount.Balance:N0} VND\n" +
                    $"Nợ hiện tại: {currentDebt:N0} VND\n" +
                    $"Hạn mức tín dụng: {fromAccount.Type.CreditLimit:N0} VND\n" +
                    $"Tín dụng khả dụng: {availableCredit:N0} VND\n" +
                    $"Tổng khả dụng: {totalAvailable:N0} VND\n\n" +
                    $"Giao dịch chuyển khoản:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Người nhận: {toAcc}\n" +
                    $"Số tiền muốn chuyển: {amount:N0} VND\n" +
                    $"Vượt quá hạn mức: {exceededAmount:N0} VND\n\n" +
                    $"Gợi ý: Bạn chỉ có thể chuyển tối đa {totalAvailable:N0} VND",
                    "Vượt hạn mức tín dụng", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            senderCustomer = _customerMgr.FindById(fromAccount.CustomerID);
            receiverCustomer = _customerMgr.FindById(toAccount.CustomerID);
            return true;
        }
        // Method xuất hóa đơn
        private void ShowBillAndClose(Transaction transaction)
        {
            using FormBill billForm = new FormBill(transaction, txtNotes.Text);
            billForm.PopulateTransaction();
            billForm.ShowDialog(this);
            this.Close();
        }
        // Method lưu dữ liệu trực tiếp vào CSV file
        private void SaveTransactionData(Transaction transaction)
        {
            try
            {
                // 1. Lưu danh sách accounts đã cập nhật
                _accountMgr.SaveAccountsToCSV();

                // 2. Lưu transaction vào lịch sử
                var transactionMgr = new TransactionManagement();
                try
                {
                    transactionMgr.ImportTransactionListFromCSV();
                }
                catch
                {
                    // File chưa tồn tại hoặc rỗng, bỏ qua
                }

                transactionMgr.AddTransaction(transaction);
                transactionMgr.SaveTransactionListToCSV();
            }
            catch (IOException ioEx)
            {
                throw new Exception($"Không thể ghi file: {ioEx.Message}\nVui lòng kiểm tra quyền truy cập hoặc đóng file nếu đang mở.");
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception("Không có quyền ghi file. Vui lòng chạy ứng dụng với quyền Administrator.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi không xác định khi lưu dữ liệu: {ex.Message}");
            }
        }
        // Method xây dựng message xác nhận
        private string ConfirmationMessage(string fromAcc, string toAcc, double amount)
        {
            string message = "";

            switch (_mode)
            {
                case TransactionType.Deposit:
                    message = $"Xác nhận nạp tiền:\n\n" +
                             $"Tài khoản nhận: {toAcc}\n" +
                             $"Người nhận: {lblReceiver.Text}\n" +
                             $"Số tiền: {amount:N0} VND\n\n" +
                             $"Bạn có chắc chắn muốn thực hiện giao dịch này?";
                    break;

                case TransactionType.Withdraw:
                    message = $"Xác nhận rút tiền:\n\n" +
                             $"Tài khoản nguồn: {fromAcc}\n" +
                             $"Người rút: {lblSender.Text}\n" +
                             $"Số tiền: {amount:N0} VND\n\n" +
                             $"Bạn có chắc chắn muốn thực hiện giao dịch này?";
                    break;

                case TransactionType.Transfer:
                    message = $"Xác nhận chuyển khoản:\n\n" +
                             $"Từ tài khoản: {fromAcc} ({lblSender.Text})\n" +
                             $"Đến tài khoản: {toAcc} ({lblReceiver.Text})\n" +
                             $"Số tiền: {amount:N0} VND\n" +
                             $"Ghi chú: {txtNotes.Text}\n\n" +
                             $"Bạn có chắc chắn muốn thực hiện giao dịch này?";
                    break;
            }

            return message;
        }
        // EVENT HANDLING
        private void txtFromAcc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string? accNum = txtFromAcc?.Text?.Trim();
                
                // Chỉ tra cứu khi nhập đủ 5 ký tự
                if (!string.IsNullOrEmpty(accNum) && accNum.Length >= 5)
                {
                    DisplayFromAccountInfo(accNum);
                }
                else if (string.IsNullOrEmpty(accNum))
                {
                    // Clear labels khi xóa hết text
                    lblSender.Text = "";
                    lblFromAccType.Text = "";
                    lblMoney.Text = "";
                }
            }
            catch
            {
                // Silent
            }
        }
        private void txtFromAcc_Leave(object? sender, EventArgs e)
        {
            try
            {
                string? fromAcc = txtFromAcc?.Text?.Trim();
                if (string.IsNullOrEmpty(fromAcc)) return;

                if (_accountMgr[fromAcc] == null)
                {
                    MessageBox.Show("Tài khoản nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFromAcc.Focus();
                }
            }
            catch
            {
                // Silent
            }
        }
        private void txtToAcc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string? accNum = txtToAcc?.Text?.Trim();
                
                if (!string.IsNullOrEmpty(accNum) && accNum.Length >= 5)
                {
                    DisplayToAccountInfo(accNum);
                }
                else if (string.IsNullOrEmpty(accNum))
                {
                    lblReceiver.Text = "";
                    lblToAccType.Text = "";
                }
            }
            catch
            {
                // Silent
            }
        }
        private void txtToAcc_Leave(object? sender, EventArgs e)
        {
            try
            {
                string? toAcc = txtToAcc?.Text?.Trim();
                if (string.IsNullOrEmpty(toAcc)) return;

                DisplayToAccountInfo(toAcc); // Hiển thị thông tin

                if (_accountMgr[toAcc] == null) // Kiểm tra và thông báo lỗi
                {
                    MessageBox.Show("Tài khoản nhận không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtToAcc.Focus();
                }
            }
            catch
            {
                // Silent
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string fromAccInput = txtFromAcc.Text.Trim();
            string toAccInput = txtToAcc.Text.Trim();
            
            if (!double.TryParse(txtAmount.Text.Trim(), out double amount) || amount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }

            Account? fromAccount = null;
            Account? toAccount = null;
            Customer? senderCustomer = null;
            Customer? receiverCustomer = null;
            Transaction? transaction = null;

            // Lưu số dư ban đầu để rollback nếu cần
            double? originalFromBalance = null;
            double? originalToBalance = null;

            try
            {
                // DOUBLE CHECK: Xác nhận trước khi thực hiện
                string confirmMessage = ConfirmationMessage(fromAccInput, toAccInput, amount);
                DialogResult confirm = MessageBox.Show(
                    confirmMessage,
                    "Xác nhận giao dịch",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                {
                    return; // User hủy giao dịch
                }

                // Xử lý theo từng mode
                if (_mode == TransactionType.Deposit)
                {
                    if (!ValidateDepositTransaction(toAccInput, out toAccount, out receiverCustomer))
                        return;

                    // Lưu số dư ban đầu
                    originalToBalance = toAccount.Balance;

                    string receiverName = receiverCustomer != null 
                        ? $"{receiverCustomer.LastName} {receiverCustomer.FirstName}" 
                        : "Unknown";
            
                    // Thực hiện giao dịch
                    toAccount.Deposit(amount);
                    transaction = new Transaction(null, toAccInput, null, receiverName, amount, TransactionType.Deposit);
                }
                else if (_mode == TransactionType.Withdraw)
                {
                    if (!ValidateWithdrawTransaction(fromAccInput, amount, out fromAccount, out senderCustomer))
                        return;

                    // Lưu số dư ban đầu
                    originalFromBalance = fromAccount.Balance;

                    string senderName = senderCustomer != null 
                        ? $"{senderCustomer.LastName} {senderCustomer.FirstName}" 
                        : "Unknown";
            
                    // Thực hiện giao dịch
                    fromAccount.Withdraw(amount);
                    transaction = new Transaction(fromAccInput, null, senderName, null, amount, TransactionType.Withdraw);
                }
                else // Transfer
                {
                    if (!ValidateTransferTransaction(fromAccInput, toAccInput, amount, out fromAccount, out toAccount, out senderCustomer, out receiverCustomer))
                        return;

                    // Lưu số dư ban đầu
                    originalFromBalance = fromAccount.Balance;
                    originalToBalance = toAccount.Balance;

                    string senderName = senderCustomer != null 
                        ? $"{senderCustomer.LastName} {senderCustomer.FirstName}" 
                        : "Unknown";
                    string receiverName = receiverCustomer != null 
                        ? $"{receiverCustomer.LastName} {receiverCustomer.FirstName}" 
                        : "Unknown";
            
                    // Thực hiện giao dịch
                    fromAccount.Withdraw(amount);
                    toAccount.Deposit(amount);
                    transaction = new Transaction(fromAccInput, toAccInput, senderName, receiverName, amount, TransactionType.Transfer);
                }

                // Lưu dữ liệu vào file
                SaveTransactionData(transaction);

                // Thông báo thành công
                MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị hóa đơn và đóng form
                ShowBillAndClose(transaction);
            }
            catch (Exception ex)
            {
                // ROLLBACK: Hoàn lại số dư ban đầu nếu có lỗi
                try
                {
                    if (fromAccount != null && originalFromBalance.HasValue)
                    {
                        fromAccount.SetBalance(originalFromBalance.Value);
                    }
                    if (toAccount != null && originalToBalance.HasValue)
                    {
                        toAccount.SetBalance(originalToBalance.Value);
                    }
                }
                catch
                {
                    // Nếu rollback cũng lỗi, thông báo nghiêm trọng
                    MessageBox.Show(
                        "Lỗi nghiêm trọng: Không thể hoàn tác giao dịch!\nVui lòng kiểm tra dữ liệu",
                        "Lỗi nghiêm trọng",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                MessageBox.Show(
                    $"Giao dịch thất bại:\n{ex.Message}\n\nSố dư đã được hoàn lại.",
                    "Lỗi giao dịch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (radTransfer.Checked)
            {
                _mode = TransactionType.Transfer;
                lblTitle.Text = "TRANSFER";
                lblFromAcc.Enabled = true;
                txtFromAcc.Enabled = true;
                lblToAcc.Enabled = true;
                txtToAcc.Enabled = true;
                lblSender.Enabled = true;
                lblReceiver.Enabled = true;
                lblFromAccType.Enabled = true;
                lblToAccType.Enabled = true;
                lblMoney.Enabled = true;
            }
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (radDeposit.Checked)
            {
                _mode = TransactionType.Deposit;
                lblTitle.Text = "DEPOSIT";
                lblFromAcc.Enabled = false;
                txtFromAcc.Enabled = false;
                txtFromAcc.Clear();
                lblToAcc.Enabled = true;
                txtToAcc.Enabled = true;
                lblSender.Enabled = false;
                lblSender.Text = "";
                lblReceiver.Enabled = true;
                lblFromAccType.Enabled = false;
                lblFromAccType.Text = "";
                lblToAccType.Enabled = true;
                lblMoney.Enabled = false;
                lblMoney.Text = "";
            }
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (radWithdraw.Checked)
            {
                _mode = TransactionType.Withdraw;
                lblTitle.Text = "WITHDRAW";
                lblFromAcc.Enabled = true;
                txtFromAcc.Enabled = true;
                lblToAcc.Enabled = false;
                txtToAcc.Enabled = false;
                txtToAcc.Clear();
                lblSender.Enabled = true;
                lblReceiver.Enabled = false;
                lblReceiver.Text = "";
                lblFromAccType.Enabled = true;
                lblToAccType.Enabled = false;
                lblToAccType.Text = "";
                lblMoney.Enabled = true;
            }
        }

    }
}
