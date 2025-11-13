using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
namespace BankManagement
{
    public partial class FormMain : Form
    {
        private AccountManagement AccountList = new AccountManagement(); // danh sách thao tác 
        private CustomerManagement CustomerList = new CustomerManagement();
        private TransactionManagement TransactionList = new TransactionManagement(); // Lịch sử giao dịch
        private List<Account> initAccountList = new();  // danh sách khi khởi tạo form hoặc tạo giao dịch (để đối chiếu thay đổi và save file)
        private bool isChanged = false;
        private FormMenu formMenu;

        // Transaction view mode tracking
        private bool _showAllTransactions = true; // Default: show all
        private string? _currentAccountNumber = null; // Track selected account

        // Dùng cho chức năng sort
        private enum SortState { None, Asc, Desc };
        private SortState accountNumberSort = SortState.None;
        private SortState balanceSort = SortState.None;
        private SortState interestRateSort = SortState.None;
        private SortState openAtSort = SortState.None;
        private bool accountTypeSorted = false;
        private bool isNormalState = true;
        
        // Dùng cho chức năng highlight search keyword
        private string _searchKeyword = string.Empty;
        
        // CUSTOM METHODS
        private bool IsAccountListChanged()
        {
            if (initAccountList.Count != AccountList.Accounts.Count)
                return true;
            for (int i = 0; i < initAccountList.Count; i++)
            {
                var a = initAccountList[i];
                var b = AccountList.Accounts[i];
                if (a.AccountNumber != b.AccountNumber ||
                    a.Balance != b.Balance ||
                    a.InterestRate != b.InterestRate ||
                    a.Type.Type != b.Type.Type ||
                    a.CustomerID != b.CustomerID)
                    return true;
            }
            return false;
        }
        // Cập nhật số thứ tự cho DataGridView
        private void UpdateRowNumbers(DataGridView dgv, string columnName = "STT")
        {
            if (dgv.Columns.Contains(columnName))
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells[columnName].Value = (i + 1).ToString();
                }
            }
        }
        // Reload Account List
        private void ReloadAccountGrid(List<Account> list)
        {
            dgvMain.DataSource = null;
            dgvMain.DataSource = list;
            isNormalState = ReferenceEquals(list, AccountList.Accounts);

            (int dc, int cc, int sc) = AccountList.GetTotalItemsEachAccountType();
            tslblDataRowCount.Text = "Total Items: " + AccountList.GetTotalItemsInList().ToString();
            tslblDebitCount.Text = "Debit: " + dc;
            tslblCreditCount.Text = "Credit: " + cc;
            tslblSavingsCount.Text = "Savings: " + sc;
        }

        // Thêm method mới để đồng bộ UI với trạng thái view mode
        private void UpdateViewModeUI()
        {
            if (_showAllTransactions)
            {
                // View All mode
                btnViewMode.Image = Properties.Resources.view_selected;
                toolTip.SetToolTip(btnViewMode, "Click to show filtered view");
                lblSubText.Text = "Showing All Transaction History";
                lblAccountNumberDisplay.Text = "";
            }
            else
            {
                // Filtered mode
                btnViewMode.Image = Properties.Resources.view_all;
                toolTip.SetToolTip(btnViewMode, "Click to show all transactions");
                
                if (!string.IsNullOrEmpty(_currentAccountNumber))
                {
                    lblSubText.Text = "Showing Transaction history of";
                    lblAccountNumberDisplay.Text = $"Account: {_currentAccountNumber}";
                }
                else
                {
                    lblSubText.Text = "Showing Transaction history of";
                    lblAccountNumberDisplay.Text = "Account: N/A";
                }
            }
        }

        // Load Transaction History cho Account được chọn
        private void LoadTransactionHistory(string? accountNumber = null)
        {
            // Update current account tracking
            if (!string.IsNullOrEmpty(accountNumber))
            {
                _currentAccountNumber = accountNumber;
            }

            // If showing all transactions (toggle mode)
            if (_showAllTransactions)
            {
                TransactionList.ResetFilter(); // Show all

                dgvSub.DataSource = null;
                dgvSub.DataSource = TransactionList.Transactions;
                dgvSub.Refresh();

                // Format columns
                if (dgvSub.Columns["Amount"] != null)
                    dgvSub.Columns["Amount"].DefaultCellStyle.Format = "N0";

                // Cập nhật số thứ tự cho dgvSub
                UpdateRowNumbers(dgvSub, "SubSTT");

                // Statistics for ALL transactions
                (int depositCountAll, int withdrawCountAll, int transferCountAll) = TransactionList.GetTotalItemsEachTransactionType(all: true);
                tslblSubDataRowCount.Text = $"Total: {TransactionList.GetTotalItemsInList(all: true)}";
                tslblDeposit.Text = $"Deposit: {depositCountAll}";
                tslblWithdraw.Text = $"Withdraw: {withdrawCountAll}";
                tslblTransfer.Text = $"Transfer: {transferCountAll}";

                return;
            }

            // Original logic: filtered by account
            if (string.IsNullOrEmpty(accountNumber))
            {
                dgvSub.DataSource = null;
                tslblSubDataRowCount.Text = "Total: 0";
                tslblDeposit.Text = "Deposit: 0";
                tslblWithdraw.Text = "Withdraw: 0";
                tslblTransfer.Text = "Transfer: 0";
                return;
            }

            // DEBUG: In ra RAW data của transactions
            /*
            System.Diagnostics.Debug.WriteLine("\n=== RAW Transaction Data ===");
            foreach (var trans in TransactionList.Transactions)
            {
                System.Diagnostics.Debug.WriteLine($"TransactionID: {trans.TransactionID}");
                System.Diagnostics.Debug.WriteLine($"  FromAccountNumber: '{trans.FromAccountNumber}' (Length: {trans.FromAccountNumber?.Length ?? 0})");
                System.Diagnostics.Debug.WriteLine($"  ToAccountNumber: '{trans.ToAccountNumber}' (Length: {trans.ToAccountNumber?.Length ?? 0})");
                System.Diagnostics.Debug.WriteLine($"  Amount: {trans.Amount}");
                System.Diagnostics.Debug.WriteLine($"  Sender: '{trans.Sender}'");
                System.Diagnostics.Debug.WriteLine($"  Receiver: '{trans.Receiver}'");
                System.Diagnostics.Debug.WriteLine($"  Type: {trans.Type}");
                System.Diagnostics.Debug.WriteLine($"  Type: {trans.TransactionTime}");
                System.Diagnostics.Debug.WriteLine("");
            }
            //System.Diagnostics.Debug.WriteLine("=============================\n");
            */
            // Lọc transactions theo account number
            TransactionList.UpdateFilteredTransaction(accountNumber);

            // Bind vào dgvSub
            dgvSub.DataSource = null;
            dgvSub.DataSource = TransactionList.Transactions;
            dgvSub.Refresh();

            // Format lại columns
            if (dgvSub.Columns["Amount"] != null)
                dgvSub.Columns["Amount"].DefaultCellStyle.Format = "N0";

            // Cập nhật số thứ tự cho dgvSub
            UpdateRowNumbers(dgvSub, "SubSTT");

            // Statistics for FILTERED transactions
            (int depositCount, int withdrawCount, int transferCount) = TransactionList.GetTotalItemsEachTransactionType(all: false);
            tslblSubDataRowCount.Text = $"Total: {TransactionList.GetTotalItemsInList(all: false)}";
            tslblDeposit.Text = $"Deposit: {depositCount}";
            tslblWithdraw.Text = $"Withdraw: {withdrawCount}";
            tslblTransfer.Text = $"Transfer: {transferCount}";
        }
        
        // Xử lý mở Form Add thông qua invoke từ Form Menu
        private void OpenFormAdd()
        {
            try
            {
                using var formAdd = new FormAdd(AccountList, CustomerList);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    // Data đã được add vào list trong FormAdd
                    ReloadAccountGrid(AccountList.Accounts);

                    isChanged = true;

                    // Khôi phục lại trạng thái hiển thị của dgvSub
                    UpdateViewModeUI(); // Đồng bộ UI trước
                    
                    if (_showAllTransactions)
                    {
                        LoadTransactionHistory(null); // Giữ nguyên chế độ "view all"
                    }
                    else
                    {
                        // Giữ nguyên chế độ filtered, load lại account hiện tại nếu có
                        LoadTransactionHistory(string.IsNullOrEmpty(_currentAccountNumber) ? "" : _currentAccountNumber);
                    }

                    MessageBox.Show(
                        $"Account added: {formAdd.NewAccount?.AccountNumber}\n" +
                        $"Customer: {formAdd.NewCustomer?.LastName} {formAdd.NewCustomer?.FirstName}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Xử lý mở Form Transaction thông qua invoke từ Form Menu
        private void OpenFormTransfer()
        {
            using FormTransaction ftransfer = new FormTransaction();
            ftransfer.ShowDialog();

            try
            {
                // Tạo instance mới để tránh conflict
                AccountManagement tempAccountMgr = new AccountManagement();
                CustomerManagement tempCustomerMgr = new CustomerManagement();

                tempAccountMgr.ImportAccountListFromCSV();
                tempCustomerMgr.ImportCustomerListFromCSV();

                // Clear và copy lại data
                AccountList.ClearList();
                foreach (Account acc in tempAccountMgr.Accounts)
                {
                    AccountList.AddAccount(acc);
                }

                CustomerList.ClearList();
                foreach (Customer cust in tempCustomerMgr.Customers)
                {
                    CustomerList.AddCustomer(cust);
                }

                // Reload transaction list
                TransactionList.ImportTransactionListFromCSV();

                // Reset init list
                initAccountList = AccountList.Accounts.Select(a => new Account(a)).ToList();
                isChanged = false;

                // Refresh DataGridView
                ReloadAccountGrid(AccountList.Accounts);

                // Khôi phục lại trạng thái hiển thị của dgvSub
                UpdateViewModeUI(); // Đồng bộ UI trước
                
                if (_showAllTransactions)
                {
                    LoadTransactionHistory(null); // Giữ nguyên chế độ "view all"
                }
                else
                {
                    // Giữ nguyên chế độ filtered, load lại account hiện tại nếu có
                    LoadTransactionHistory(string.IsNullOrEmpty(_currentAccountNumber) ? "" : _currentAccountNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error reloading data after transaction:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // FORM, EVENTS
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(FormMenu menu)
        {
            InitializeComponent();
            this.formMenu = menu;
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            AccountList.ImportAccountListFromCSV();
            CustomerList.ImportCustomerListFromCSV();
            TransactionList.ImportTransactionListFromCSV();

            // Tạo bản sao độc lập để so sánh về sau
            initAccountList = AccountList.Accounts.Select(a => new Account(a)).ToList();

            dgvMain.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvMain.AutoGenerateColumns = false;
            dgvMain.Columns["Balance"].DefaultCellStyle.Format = "N0";
            dgvMain.Columns["OpenAt"].DefaultCellStyle.Format = "dd/MM/yyyy";

            ReloadAccountGrid(AccountList.Accounts);

            dgvSub.AutoGenerateColumns = false;
            dgvSub.RowsDefaultCellStyle.BackColor = Color.White;
            dgvSub.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            //LoadTransactionHistory(""); // Clear dgvSub khi khởi động

            // Initialize sub status bar
            //tslblSubDataRowCount.Text = "Total: 0";
            //tslblDeposit.Text = "Deposit: 0";
            //tslblWithdraw.Text = "Withdraw: 0";
            //tslblTransfer.Text = "Transfer: 0";

            // Setup button with Resources
            btnViewMode.Image = Properties.Resources.view_all;
            //btnViewMode.Image = Properties.Resources.view_selected;
            btnViewMode.Text = "";
            btnViewMode.ImageAlign = ContentAlignment.MiddleCenter;
            btnViewMode.TextAlign = ContentAlignment.MiddleCenter;

            // Đồng bộ UI theo trạng thái mặc định
            UpdateViewModeUI();
            
            // Load transaction history
            LoadTransactionHistory(null);

            // Tạo và liên kết FormMenu
            if (formMenu != null)
            {
                formMenu.OnAddButtonClick = OpenFormAdd;
                formMenu.OnTransferButtonClick = OpenFormTransfer;
            }

            dgvMain.DataBindingComplete += (_, __) => UpdateRowNumbers(dgvMain, "MainSTT");
            dgvSub.DataBindingComplete += (_, __) => UpdateRowNumbers(dgvSub, "SubSTT");

           
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsAccountListChanged() || isChanged)
            {
                var result = MessageBox.Show(
                    "Data has changed. Do you want to save it?",
                    "Save Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Lưu Account List vào CSV
                        AccountList.SaveAccountsToCSV();

                        // Lưu Customer List vào CSV (nếu có thay đổi)
                        CustomerList.SaveCustomersToCSV();

                        MessageBox.Show(
                            "Data saved successfully!",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        isChanged = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error while saving data:\n{ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        e.Cancel = true; // Không đóng form nếu lưu thất bại
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Ở lại form
                }
                // Nếu No -> thoát mà không lưu
            }
        }

        // Xử lý Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Xóa keyword và refresh để hủy highlight
                _searchKeyword = string.Empty;
                
                // Nếu đã ở trạng thái bình thường thì không reload nữa
                if (!isNormalState)
                    ReloadAccountGrid(AccountList.Accounts);
                else
                    dgvMain.Invalidate(); // Refresh để xóa highlight
                return;
            }
            
            // Lưu keyword để highlight
            _searchKeyword = keyword;
            
            // Lọc list theo bất kỳ input nào được tìm thấy trong table
            var filtered = AccountList.FindByStringInput(keyword);
            
            // Bind lại DataGridView
            ReloadAccountGrid(filtered);
            isNormalState = false;
            
            // Trigger repaint để highlight
            dgvMain.Invalidate();
        }
        // Xử lý phụ cho Search, reload table
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _searchKeyword = string.Empty;
                ReloadAccountGrid(AccountList.Accounts);
                dgvMain.Invalidate();
            }
        }
        // Xử lý ViewMode cho dgvSub: All/Filtered transaction view
        private void btnViewMode_Click(object sender, EventArgs e)
        {
            // Toggle mode
            _showAllTransactions = !_showAllTransactions;

            // Đồng bộ UI với trạng thái mới
            UpdateViewModeUI();

            if (_showAllTransactions)
            {
                // Load all transactions
                LoadTransactionHistory(null);
            }
            else
            {
                // Restore filtered view
                if (!string.IsNullOrEmpty(_currentAccountNumber))
                {
                    LoadTransactionHistory(_currentAccountNumber);
                }
                else
                {
                    // No account selected, clear view
                    LoadTransactionHistory("");
                }
            }
        }
        // Xử lý Edit, Delete
        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string colName = dgvMain.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                // Lấy object Account từ DataBoundItem
                if (dgvMain.Rows[e.RowIndex].DataBoundItem is Account acc)
                {
                    // Lấy Customer liên kết với Account
                    Customer? customer = CustomerList[acc.CustomerID];
                    if (customer != null)
                    {
                        using FormEdit fedit = new FormEdit(acc, customer);
                        if (fedit.ShowDialog() == DialogResult.OK)
                        {
                            // Cập nhật lại dữ liệu gốc từ form edit
                            acc.SetBalance(fedit.SelectedAccount.Balance);
                            acc.ChangeInterestRate(fedit.SelectedAccount.InterestRate); // Nếu cho phép thay đổi lãi suất
                            customer.UpdateInfo(
                                fedit.SelectedCustomer.LastName,
                                fedit.SelectedCustomer.FirstName,
                                fedit.SelectedCustomer.CID,
                                fedit.SelectedCustomer.Address,
                                fedit.SelectedCustomer.Email,
                                fedit.SelectedCustomer.Phone,
                                fedit.SelectedCustomer.BirthDate.ToString("dd/MM/yyyy"),
                                fedit.SelectedCustomer.Gender
                            );
                            ReloadAccountGrid(AccountList.Accounts);
                            isChanged = true;
                        }
                    }
                }
            }
            else if (colName == "Delete")
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this row?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    // Lấy object Account đang hiển thị trên dòng được chọn
                    Account? acc = dgvMain.Rows[e.RowIndex].DataBoundItem as Account; // DataBoundItem trỏ đến danh sách gốc (chưa lọc)
                    if (acc != null)
                    {
                        AccountList.RemoveAccount(acc);
                        isChanged = true;
                        // Sau khi xóa, nếu đang tìm kiếm thì lọc lại, nếu không thì hiển thị toàn bộ
                        ReloadAccountGrid(AccountList.Accounts);

                        // Clear dgvSub khi xóa account
                        LoadTransactionHistory("");
                    }
                }
            }
        }
        // Xử lý query lịch sử cho TẤT CẢ các cell
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string colName = dgvMain.Columns[e.ColumnIndex].Name;

            // Lấy Account từ row được chọn
            if (colName != "Edit" && colName != "Delete")
            {
                Account? acc = dgvMain.Rows[e.RowIndex].DataBoundItem as Account;
                if (acc != null)
                {
                    // Chỉ đối sang filtered mode khi đang ở filtered mode
                    if (!_showAllTransactions)
                    {
                        LoadTransactionHistory(acc.AccountNumber);
                        UpdateViewModeUI(); // Cập nhật label sau khi load
                    }
                    else
                    {
                        // Lưu tài khoản được chọn hiện tại nhưng không đổi view
                        _currentAccountNumber = acc.AccountNumber;
                    }
                }
            }
        }

        // Xử lý Sort = Column Header
        private void dgvMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dgvMain.Columns[e.ColumnIndex].Name;
            List<Account>? sorted = null;
            // Xoay vòng sort None->Asc->Desc->None
            if (colName == "AccountNumber")
            {
                accountNumberSort = accountNumberSort == SortState.None ? SortState.Asc :
                                    accountNumberSort == SortState.Asc ? SortState.Desc : SortState.None;
                // Reset các sort khác
                balanceSort = SortState.None;
                interestRateSort = SortState.None;
                openAtSort = SortState.None;
                accountTypeSorted = false;

                if (accountNumberSort == SortState.Asc)
                    sorted = [.. AccountList.Accounts.OrderBy(a => a.AccountNumber.ToInt())];
                else if (accountNumberSort == SortState.Desc)
                    sorted = [.. AccountList.Accounts.OrderByDescending(a => a.AccountNumber.ToInt())];
            }
            else if (colName == "Balance")
            {
                balanceSort = balanceSort == SortState.None ? SortState.Asc :
                              balanceSort == SortState.Asc ? SortState.Desc : SortState.None;
                // Reset các sort khác
                accountNumberSort = SortState.None;
                interestRateSort = SortState.None;
                openAtSort = SortState.None;
                accountTypeSorted = false;

                if (balanceSort == SortState.Asc)
                    sorted = [.. AccountList.Accounts.OrderBy(a => a.Balance)];
                else if (balanceSort == SortState.Desc)
                    sorted = [.. AccountList.Accounts.OrderByDescending(a => a.Balance)];
            }
            else if (colName == "InterestRate")
            {
                interestRateSort = interestRateSort == SortState.None ? SortState.Asc :
                                   interestRateSort == SortState.Asc ? SortState.Desc : SortState.None;
                // Reset các sort khác
                accountNumberSort = SortState.None;
                balanceSort = SortState.None;
                openAtSort = SortState.None;
                accountTypeSorted = false;

                if (interestRateSort == SortState.Asc)
                    sorted = [.. AccountList.Accounts.OrderBy(a => a.InterestRate)];
                else if (interestRateSort == SortState.Desc)
                    sorted = [.. AccountList.Accounts.OrderByDescending(a => a.InterestRate)];
            }
            else if (colName == "OpenAt")
            {
                openAtSort = openAtSort == SortState.None ? SortState.Asc :
                             openAtSort == SortState.Asc ? SortState.Desc : SortState.None;
                // Reset các sort khác
                accountNumberSort = SortState.None;
                balanceSort = SortState.None;
                interestRateSort = SortState.None;
                accountTypeSorted = false;

                if (openAtSort == SortState.Asc)
                    sorted = [.. AccountList.Accounts.OrderBy(a => a.OpenAt)];
                else if (openAtSort == SortState.Desc)
                    sorted = [.. AccountList.Accounts.OrderByDescending(a => a.OpenAt)];
            }
            else if (colName == "AccountType" || colName == "AccountTypeName")
            {
                accountTypeSorted = !accountTypeSorted;
                // Reset các sort khác
                accountNumberSort = SortState.None;
                balanceSort = SortState.None;
                interestRateSort = SortState.None;
                openAtSort = SortState.None;

                if (accountTypeSorted)
                    sorted = [.. AccountList.Accounts.OrderBy(a => (int)a.Type.Type)]; // Debit=0, Credit=1, Savings=2
            }

            if (sorted != null)
                ReloadAccountGrid(sorted);
            else
            {
                if (!isNormalState)
                {
                    ReloadAccountGrid(AccountList.Accounts); // Hủy sort
                    isNormalState = true; // Trả về trạng thái bình thường để tránh reload liên tục
                }
            }
        }
        // Xử lý Liên kết Form Customer
        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string colName = dgvMain.Columns[e.ColumnIndex].Name;
            if (colName == "Edit" || colName == "Delete") return;

            Account? acc = dgvMain.Rows[e.RowIndex].DataBoundItem as Account;
            if (acc != null)
            {
                Customer? customer = CustomerList[acc.CustomerID];
                if (customer != null)
                {
                    using FormCustomer fCustomer = new FormCustomer(acc, customer);
                    if (fCustomer.ShowDialog() == DialogResult.OK)
                    {
                        // Tìm lại object GỐC trong list để đảm bảo cập nhật đúng
                        Account? originalAccount = AccountList[acc.AccountNumber];
                        Customer? originalCustomer = CustomerList[acc.CustomerID];

                        if (originalAccount != null && originalCustomer != null)
                        {
                            // Cập nhật Account gốc
                            originalAccount.SetBalance(fCustomer.SelectedAccount.Balance);
                            originalAccount.ChangeInterestRate(fCustomer.SelectedAccount.InterestRate);

                            // Cập nhật Customer gốc
                            originalCustomer.UpdateInfo(
                                fCustomer.SelectedCustomer.LastName,
                                fCustomer.SelectedCustomer.FirstName,
                                fCustomer.SelectedCustomer.CID,
                                fCustomer.SelectedCustomer.Address,
                                fCustomer.SelectedCustomer.Email,
                                fCustomer.SelectedCustomer.Phone,
                                fCustomer.SelectedCustomer.BirthDate.ToString("dd/MM/yyyy"),
                                fCustomer.SelectedCustomer.Gender
                            );

                            ReloadAccountGrid(AccountList.Accounts);
                            isChanged = true;

                            // Reload transaction history nếu đang hiển thị account này
                            LoadTransactionHistory(acc.AccountNumber);
                        }
                    }
                }
            }
        }

        // Event handler double-click cho dgvSub để mở FormBill
        private void dgvSub_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy Transaction object từ dòng được chọn
            Transaction? trans = dgvSub.Rows[e.RowIndex].DataBoundItem as Transaction;
            if (trans != null)
            {
                try
                {
                    using FormBill fBill = new FormBill(trans);
                    fBill.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error displaying transaction details:\n{ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        // Event handler chung: Căn lề header cho tất cả DataGridView
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Kiểm tra nếu là ô header
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, false);
                string headerText = e.FormattedValue?.ToString() ?? string.Empty;
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    using (Brush textBrush = new SolidBrush(Color.FromArgb(50, 52, 76)))
                    {
                        e.Graphics.DrawString(headerText, e.CellStyle.Font, textBrush, e.CellBounds, sf);
                    }
                }

                e.Handled = true;
            }
        }
    }
}
