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
        // Dùng cho chức năng sort
        private enum SortState { None, Asc, Desc };
        private SortState accountNumberSort = SortState.None;
        private SortState balanceSort = SortState.None;
        private SortState interestRateSort = SortState.None;
        private SortState openAtSort = SortState.None;
        private bool accountTypeSorted = false;
        private bool isNormalState = true;
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

        // Load Transaction History cho Account được chọn
        private void LoadTransactionHistory(string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
            {
                dgvSub.DataSource = null;
                lblAccountNumberDisplay.Text = "Account: N/A";
                tslblSubDataRowCount.Text = "Total: 0";
                tslblDeposit.Text = "Deposit: 0";
                tslblWithdraw.Text = "Withdraw: 0";
                tslblTransfer.Text = "Transfer: 0";
                return;
            }

            // DEBUG: In ra RAW data của transactions
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

            // Lọc transactions theo account number
            TransactionList.UpdateFilteredTransaction(accountNumber);

            // Bind vào dgvSub
            dgvSub.DataSource = null;
            dgvSub.DataSource = TransactionList.Transactions;
            dgvSub.Refresh();

            // Cập nhật label hiển thị account number
            lblAccountNumberDisplay.Text = $"Account: {accountNumber}";

            // Format lại columns
            if (dgvSub.Columns["Amount"] != null)
                dgvSub.Columns["Amount"].DefaultCellStyle.Format = "N0";

            // Cập nhật statistics
            (int depositCount, int withdrawCount, int transferCount) = TransactionList.GetTotalItemsEachTransactionType();
            tslblSubDataRowCount.Text = $"Total: {TransactionList.GetTotalItemsInList()}";
            tslblDeposit.Text = $"Deposit: {depositCount}";
            tslblWithdraw.Text = $"Withdraw: {withdrawCount}";
            tslblTransfer.Text = $"Transfer: {transferCount}";
        }

        // FORM, EVENTS
        public FormMain()
        {
            InitializeComponent();
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
            dgvMain.DataSource = AccountList.Accounts;
            dgvMain.Columns["Balance"].DefaultCellStyle.Format = "N0";
            dgvMain.Columns["OpenAt"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvSub.AutoGenerateColumns = false;
            dgvSub.RowsDefaultCellStyle.BackColor = Color.White;
            dgvSub.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            LoadTransactionHistory(""); // Clear dgvSub khi khởi động

            // In một vài thông số
            (int dc, int cc, int sc) = AccountList.GetTotalItemsEachAccountType();
            tslblDataRowCount.Text = "Total Items: " + AccountList.GetTotalItemsInList().ToString();
            tslblDebitCount.Text = "Debit: " + dc;
            tslblCreditCount.Text = "Credit: " + cc;
            tslblSavingsCount.Text = "Savings: " + sc;

            // Initialize sub status bar
            tslblSubDataRowCount.Text = "Total: 0";
            tslblDeposit.Text = "Deposit: 0";
            tslblWithdraw.Text = "Withdraw: 0";
            tslblTransfer.Text = "Transfer: 0";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsAccountListChanged() || isChanged)
            {
                var result = MessageBox.Show(
                    "Dữ liệu đã thay đổi. Bạn có muốn lưu lại không?",
                    "Xác nhận lưu",
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
                            "Lưu dữ liệu thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        isChanged = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Lỗi khi lưu dữ liệu:\n{ex.Message}",
                            "Lỗi",
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
        // Xử lý Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using var formAdd = new FormAdd(AccountList, CustomerList);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    // Data đã được add vào list trong FormAdd
                    ReloadAccountGrid(AccountList.Accounts);

                    isChanged = true;

                    MessageBox.Show(
                        $"Đã thêm tài khoản: {formAdd.NewAccount?.AccountNumber}\n" +
                        $"Khách hàng: {formAdd.NewCustomer?.LastName} {formAdd.NewCustomer?.FirstName}",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi phát sinh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Xử lý Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu đã ở trạng thái bình thường thì không reload nữa
                if (!isNormalState)
                    ReloadAccountGrid(AccountList.Accounts);
                return;
            }
            // Lọc list theo AccountNumber hoặc Type hoặc CustomerID
            var filtered = AccountList.Accounts.Where(a =>
                a.AccountNumber.ToLower().Contains(keyword) ||
                a.AccountTypeName.ToLower().Contains(keyword) ||
                a.CustomerID.ToString().ToLower().Contains(keyword)
            ).ToList();
            // Bind lại DataGridView
            ReloadAccountGrid(filtered);
            isNormalState = false;
        }
        // Xử lý phụ cho Search, reload table
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                ReloadAccountGrid(AccountList.Accounts);
            }
        }
        // Xử lý chức năng mở form tạo giao dịch
        private void btnOpenTransfer_Click(object sender, EventArgs e)
        {
            using FormTransaction ftransfer = new FormTransaction();
            ftransfer.ShowDialog();

            try
            {
                // FIX: Tạo instance mới để tránh conflict
                var tempAccountMgr = new AccountManagement();
                var tempCustomerMgr = new CustomerManagement();

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

                // Clear dgvSub khi reload
                LoadTransactionHistory("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi tải lại dữ liệu sau giao dịch:\n{ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // Xử lý Edit, Delete
        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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
                    "Bạn có chắc muốn xóa dòng này?",
                    "Xác nhận xóa",
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
            if (e.RowIndex < 0) return;
            string colName = dgvMain.Columns[e.ColumnIndex].Name;
            // Lấy Account từ row được chọn
            if ( colName != "Edit" && colName != "Delete")
            {
                Account? acc = dgvMain.Rows[e.RowIndex].DataBoundItem as Account;
                if (acc != null)
                {
                    LoadTransactionHistory(acc.AccountNumber);
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
            if (e.RowIndex < 0) return;
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
                        $"Lỗi khi hiển thị chi tiết giao dịch:\n{ex.Message}",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
