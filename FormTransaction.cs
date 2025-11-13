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

            // Default mode
            cboTransactionMode.SelectedIndex = 0;

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

            _comboItems = BuildAccountItems();
            BindAccountCombo(cboSender, _comboItems);
            BindAccountCombo(cboReceiver, _comboItems);

            cboSender.SelectedIndexChanged += (s, e) =>
            {
                if (cboSender.SelectedItem is AccountComboItem it)
                {
                    lblSenderNum.Text = it.AccountNumber;    
                    DisplayFromAccountInfo(it.AccountNumber); // updates Type + Money
                }
                else
                {
                    lblSenderNum.Text = "";
                    DisplayFromAccountInfo("");
                }
            };
            cboReceiver.SelectedIndexChanged += (s, e) =>
            {
                if (cboReceiver.SelectedItem is AccountComboItem it)
                {
                    lblReceiverNum.Text = it.AccountNumber;   
                    DisplayToAccountInfo(it.AccountNumber);   // updates Type
                }
                else
                {
                    lblReceiverNum.Text = "";
                    DisplayToAccountInfo("");
                }
            };

            this.ActiveControl = cboSender;
            cboSender.Focus();
        }

        public FormTransaction(Account account) : this()
        {
            TransferAccount = new Account(account);
            try { cboSender.SelectedValue = account.AccountNumber; } catch { /* ignore */ }
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            // Sender
            if (cboSender.SelectedItem is AccountComboItem s)
            {
                lblSenderNum.Text = s.AccountNumber;
                DisplayFromAccountInfo(s.AccountNumber);
            }
            else
            {
                lblSenderNum.Text = "";
                lblFromAccType.Text = "";
                lblMoney.Text = "";
            }

            // Receiver
            if (cboReceiver.SelectedItem is AccountComboItem r)
            {
                lblReceiverNum.Text = r.AccountNumber;
                DisplayToAccountInfo(r.AccountNumber);
            }
            else
            {
                lblReceiverNum.Text = "";
                lblToAccType.Text = "";
            }
        }

        // METHODS
        // Helper method để update và display thông tin tài khoản nguồn
        private void DisplayFromAccountInfo(string accNum)
        {
            if (string.IsNullOrEmpty(accNum))
            {
                lblSenderNum.Text = "";
                lblFromAccType.Text = "";
                lblMoney.Text = "";
                return;
            }

            Account? acc = _accountMgr[accNum];
            if (acc != null)
            {
                lblMoney.Text = $"{acc.Balance:N0} VND";
                lblFromAccType.Text = "Type: " + acc.Type.AccType;
                lblSenderNum.Text = acc.AccountNumber; // number instead of name
            }
            else
            {
                lblMoney.Text = "Account not found";
                lblSenderNum.Text = "";
                lblFromAccType.Text = "";
            }
        }

        // Helper method để update và display thông tin tài khoản đích
        private void DisplayToAccountInfo(string accNum)
        {
            if (string.IsNullOrEmpty(accNum))
            {
                lblReceiverNum.Text = "";
                lblToAccType.Text = "";
                return;
            }

            Account? acc = _accountMgr[accNum];
            if (acc != null)
            {
                lblToAccType.Text = "Type: " + acc.Type.AccType;
                lblReceiverNum.Text = acc.AccountNumber; // number instead of name
            }
            else
            {
                lblReceiverNum.Text = "";
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
                MessageBox.Show("Please select a destination account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReceiver.Focus();
                return false;
            }

            toAccount = _accountMgr[toAcc];
            if (toAccount == null)
            {
                MessageBox.Show("The destination account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReceiver.Focus();
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
                MessageBox.Show("Please select a source account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSender.Focus();
                return false;
            }

            fromAccount = _accountMgr[fromAcc];
            if (fromAccount == null)
            {
                MessageBox.Show("The source account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSender.Focus();
                return false;
            }

            // Kiểm tra cho Debit/Savings - Số dư không đủ
            if (!fromAccount.Type.AllowOverdraft && fromAccount.Balance < amount)
            {
                MessageBox.Show(
                    $"Insufficient balance for this transaction.\n\n" +
                    $"Current balance: {fromAccount.Balance:N0} VND\n" +
                    $"Withdrawal amount: {amount:N0} VND\n" +
                    $"Shortfall: {(amount - fromAccount.Balance):N0} VND",
                    "Insufficient Balance",
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
                    $"Credit limit exceeded!\n\n" +
                    $"Credit Account Information:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Current balance: {fromAccount.Balance:N0} VND\n" +
                    $"Current debt: {currentDebt:N0} VND\n" +
                    $"Credit limit: {fromAccount.Type.CreditLimit:N0} VND\n" +
                    $"Available credit: {availableCredit:N0} VND\n\n" +
                    $"Transaction:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Withdrawal amount: {amount:N0} VND\n" +
                    $"Exceeded by: {exceededAmount:N0} VND",
                    "Credit Limit Exceeded",
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
                MessageBox.Show("Please select both source and destination accounts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fromAcc == toAcc)
            {
                MessageBox.Show("Cannot transfer to the same account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            fromAccount = _accountMgr[fromAcc];
            if (fromAccount == null)
            {
                MessageBox.Show("The source account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSender.Focus();
                return false;
            }

            toAccount = _accountMgr[toAcc];
            if (toAccount == null)
            {
                MessageBox.Show("The destination account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReceiver.Focus();
                return false;
            }

            if (!fromAccount.Type.CanTransfer)
            {
                MessageBox.Show(
                    $"Account type {fromAccount.Type.AccType} is not allowed to transfer funds.\n\n" +
                    $"Only Debit and Credit accounts can perform transfers.",
                    "No Transfer Permission",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số dư cho Debit/Savings
            if (!fromAccount.Type.AllowOverdraft && fromAccount.Balance < amount)
            {
                MessageBox.Show(
                    $"Insufficient balance for this transaction.\n\n" +
                    $"Current balance: {fromAccount.Balance:N0} VND\n" +
                    $"Transfer amount: {amount:N0} VND\n" +
                    $"Shortfall: {(amount - fromAccount.Balance):N0} VND",
                    "Insufficient Balance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                    $"Credit limit exceeded!\n\n" +
                    $"Source Account Information:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Current balance: {fromAccount.Balance:N0} VND\n" +
                    $"Current debt: {currentDebt:N0} VND\n" +
                    $"Credit limit: {fromAccount.Type.CreditLimit:N0} VND\n" +
                    $"Available credit: {availableCredit:N0} VND\n" +
                    $"Total available: {totalAvailable:N0} VND\n\n" +
                    $"Transfer transaction:\n" +
                    $"━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                    $"Receiver: {toAcc}\n" +
                    $"Transfer amount: {amount:N0} VND\n" +
                    $"Exceeded by: {exceededAmount:N0} VND\n\n" +
                    $"Note: You can only transfer up to {totalAvailable:N0} VND",
                    "Credit Limit Exceeded",
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
                throw new Exception($"Unable to write file: {ioEx.Message}\nPlease check file permissions or close the file if it is open.");
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception("No write permission. Please run the application as Administrator.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unknown error while saving data: {ex.Message}");
            }
        }
        // Method xây dựng message xác nhận
        private string ConfirmationMessage(string fromAcc, string toAcc, double amount)
        {
            // Lấy tên hiển thị từ ComboBox, số tài khoản từ labels
            string senderName = cboSender.SelectedItem is AccountComboItem s ? s.CustomerName : "";
            string receiverName = cboReceiver.SelectedItem is AccountComboItem r ? r.CustomerName : "";

            string message = "";

            switch (_mode)
            {
                case TransactionType.Deposit:
                    message = $"Confirm deposit:\n\n" +
                              $"Destination account: {toAcc} ({receiverName})\n" +
                              $"Amount: {amount:N0} VND\n\n" +
                              $"Are you sure you want to proceed with this transaction?";
                    break;

                case TransactionType.Withdraw:
                    message = $"Confirm withdrawal:\n\n" +
                              $"Source account: {fromAcc} ({senderName})\n" +
                              $"Amount: {amount:N0} VND\n\n" +
                              $"Are you sure you want to proceed with this transaction?";
                    break;

                case TransactionType.Transfer:
                    message = $"Confirm transfer:\n\n" +
                              $"From account: {fromAcc} ({senderName})\n" +
                              $"To account: {toAcc} ({receiverName})\n" +
                              $"Amount: {amount:N0} VND\n" +
                              $"Note: {txtNotes.Text}\n\n" +
                              $"Are you sure you want to proceed with this transaction?";
                    break;
            }

            return message;
        }
        
        // Data model for ComboBox
        private sealed class AccountComboItem
        {
            public required string AccountNumber { get; init; }
            public required string CustomerName { get; init; }
            public required string AccountType { get; init; }
        }
        private List<AccountComboItem> _comboItems = new();
        private List<AccountComboItem> BuildAccountItems()
        {
            return _accountMgr.Accounts
                .Select(acc =>
                {
                    var c = _customerMgr.FindById(acc.CustomerID);
                    var name = c != null ? $"{c.LastName} {c.FirstName}" : "Unknown";
                    return new AccountComboItem
                    {
                        AccountNumber = acc.AccountNumber,
                        CustomerName = name,
                        AccountType = acc.Type.AccType
                    };
                })
                .OrderBy(i => i.CustomerName)
                .ThenBy(i => i.AccountNumber)
                .ToList();
        }

        private void BindAccountCombo(ComboBox combo, List<AccountComboItem> items)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.DisplayMember = nameof(AccountComboItem.CustomerName);
            combo.ValueMember = nameof(AccountComboItem.AccountNumber);
            combo.DataSource = new List<AccountComboItem>(items);

            // Owner-draw to show full info in dropdown, name in edit area
            combo.DrawMode = DrawMode.OwnerDrawFixed;
            combo.DrawItem += cbo_DrawItem;

            // Limit dropdown to at most 10 visible items, and allow custom height
            combo.MaxDropDownItems = 10;         // shows <= 10 items
            combo.IntegralHeight = false;        // allow DropDownHeight control
            combo.DropDown += cbo_DropDownResizeToScreen;

            // No autocomplete (as you set earlier)
            combo.AutoCompleteMode = AutoCompleteMode.None;
            combo.AutoCompleteSource = AutoCompleteSource.None;

            combo.SelectedIndex = -1;
        }

        // Ensure dropdown fits below the ComboBox and doesn’t overflow the screen
        private void cbo_DropDownResizeToScreen(object? sender, EventArgs e)
        {
            if (sender is not ComboBox combo) return;

            // Desired height for up to 10 items (plus border)
            int itemHeight = Math.Max(1, combo.ItemHeight);
            int visibleItems = Math.Min(10, combo.Items.Count);
            int desiredHeight = (itemHeight * visibleItems) + 2;

            // Compute available space below the control
            var screen = Screen.FromControl(combo).WorkingArea;
            var topLeft = combo.PointToScreen(Point.Empty);
            int spaceBelow = screen.Bottom - (topLeft.Y + combo.Height);

            // Keep dropdown within the bottom of the screen
            int safeHeight = Math.Max(itemHeight + 2, Math.Min(desiredHeight, spaceBelow - 4));
            combo.DropDownHeight = safeHeight;
        }

        private void cbo_DrawItem(object? sender, DrawItemEventArgs e)
        {
            // Vẽ nền
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            bool isFocused = (e.State & DrawItemState.Focus) == DrawItemState.Focus;

            Color backColor = isSelected
                ? Color.FromArgb(67, 69, 94)
                : (e.BackColor.IsEmpty ? Color.White : e.BackColor);

            using (SolidBrush backgroundBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            if (sender is not ComboBox combo)
                return;

            // Determine item to draw: handle edit area (e.Index == -1)
            AccountComboItem? item = null;
            bool isEditArea = (e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit || e.Index < 0;

            if (isEditArea)
            {
                item = combo.SelectedItem as AccountComboItem;
                if (item == null)
                    return;
            }
            else
            {
                item = combo.Items[e.Index] as AccountComboItem;
                if (item == null)
                    return;
            }

            // Màu chữ: trắng nếu được chọn, ngược lại dùng màu mặc định
            using var textBrush = new SolidBrush(isSelected ? Color.White : e.ForeColor);

            string text = isEditArea
                ? item.CustomerName
                : $"{item.CustomerName} — {item.AccountNumber} [{item.AccountType}]";

            // Vẽ text
            e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);

            // Vẽ focus rectangle với màu custom nếu có focus
            if (isFocused)
            {
                using (Pen focusPen = new Pen(Color.FromArgb(67, 69, 94), 2))
                {
                    Rectangle focusRect = new Rectangle(
                        e.Bounds.X + 1, e.Bounds.Y + 1,
                        e.Bounds.Width - 3, e.Bounds.Height - 3
                    );
                    e.Graphics.DrawRectangle(focusPen, focusRect);
                }
            }

            // Không gọi e.DrawFocusRectangle() để tránh viền mặc định
            // e.DrawFocusRectangle();
        }

        // EVENT HANDLING
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Lấy số tài khoản từ labels được set bởi ComboBox (không phụ thuộc txtFromAcc/txtToAcc)
            string fromAccInput = _mode == TransactionType.Deposit ? "" : lblSenderNum.Text.Trim();
            string toAccInput   = _mode == TransactionType.Withdraw ? "" : lblReceiverNum.Text.Trim();

            if (!double.TryParse(txtAmount.Text.Trim(), out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    "Transaction Confirmation",
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
                MessageBox.Show("Transaction successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        "Critical error: Unable to rollback transaction!\nPlease check your data.",
                        "Critical Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                MessageBox.Show(
                    $"Transaction failed:\n{ex.Message}\n\nBalances have been restored.",
                    "Transaction Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboTransactionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTransactionMode.SelectedIndex)
            {
                case 0: // Transfer
                    _mode = TransactionType.Transfer;
                    lblTitle.Text = "TRANSFER";

                    cboSender.Enabled = true;
                    cboReceiver.Enabled = true;

                    lblSenderNum.Enabled = true;
                    lblReceiverNum.Enabled = true;
                    lblFromAccType.Enabled = true;
                    lblToAccType.Enabled = true;
                    lblMoney.Enabled = true;
                    break;

                case 1: // Deposit
                    _mode = TransactionType.Deposit;
                    lblTitle.Text = "DEPOSIT";

                    // Sender not used
                    cboSender.Enabled = false;
                    cboSender.SelectedIndex = -1;
                    lblSenderNum.Text = "";
                    lblFromAccType.Text = "";
                    lblMoney.Text = "";

                    // Receiver used
                    cboReceiver.Enabled = true;

                    lblFromAccType.Enabled = false;
                    lblToAccType.Enabled = true;
                    lblMoney.Enabled = false;
                    break;

                case 2: // Withdraw
                    _mode = TransactionType.Withdraw;
                    lblTitle.Text = "WITHDRAW";

                    // Sender used
                    cboSender.Enabled = true;

                    // Receiver not used
                    cboReceiver.Enabled = false;
                    cboReceiver.SelectedIndex = -1;
                    lblReceiverNum.Text = "";
                    lblToAccType.Text = "";

                    lblFromAccType.Enabled = true;
                    lblToAccType.Enabled = false;
                    lblMoney.Enabled = true;
                    break;
            }
        }
    }
}
