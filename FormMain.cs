using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace BankManagement
{
    public partial class FormMain : Form
    {
        private AccountManagement AccountList = new AccountManagement(); // danh sách thao tác 
        private CustomerManagement CustomerList = new CustomerManagement();
        private List<Account> initAccountList = new();  // danh sách khi khởi tạo form (để đối chiếu thay đổi và save file)
        private bool isChanged = false;
        // Dùng cho chức năng sort
        private enum SortState { None, Asc, Desc };
        private SortState accountNumberSort = SortState.None;
        private SortState balanceSort = SortState.None;
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            isNormalState = ReferenceEquals(list, AccountList.Accounts);
        }
        // FORM, EVENTS
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            AccountList.ImportAccountListFromCSV();
            // Tạo bản sao độc lập để so sánh về sau
            initAccountList = AccountList.Accounts.Select(a => new Account(a)).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = AccountList.Accounts; // <-- dùng AccountList.Accounts
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
                    //SaveAccountsToCsv(initAccountList, csvPath);
                    isChanged = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Ở lại form
                }
                // Nếu No -> thoát mà không lưu
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //mở form Add
            using var fadd = new FormAdd();
            fadd.ShowDialog();
        }
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                ReloadAccountGrid(AccountList.Accounts);
            }
        }
        private void ptb_OpenTransfer_Click(object sender, EventArgs e)
        {
            using var ftransfer = new FormTransfer();
            ftransfer.ShowDialog();
        }
        // Xử lý Edit, Delete
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                using var fedit = new FormEdit();
                fedit.ShowDialog();
                // Nếu FormEdit thay đổi object hiện tại, bạn nên đặt isChanged = true ở đó hoặc sau khi form đóng kiểm tra thay đổi
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
                    var acc = dataGridView1.Rows[e.RowIndex].DataBoundItem as Account; // DataBoundItem trỏ đến danh sách gốc (chưa lọc)
                    if (acc != null)
                    {
                        AccountList.RemoveAccount(acc);
                        isChanged = true;
                        // Sau khi xóa, nếu đang tìm kiếm thì lọc lại, nếu không thì hiển thị toàn bộ
                        ReloadAccountGrid(AccountList.Accounts);
                    }
                }
            }
        }
        // Xử lý Sort = Column Header
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            List<Account>? sorted = null;

            if (colName == "AccountNumber")
            {
                // Xoay vòng sort None->Asc->Desc->None
                accountNumberSort = accountNumberSort == SortState.None ? SortState.Asc :
                                    accountNumberSort == SortState.Asc ? SortState.Desc : SortState.None;
                balanceSort = SortState.None; accountTypeSorted = false;
                if (accountNumberSort == SortState.Asc)
                    sorted = [.. AccountList.Accounts.OrderBy(a => a.AccountNumber.ToInt())];
                else if (accountNumberSort == SortState.Desc)
                    sorted = [.. AccountList.Accounts.OrderByDescending(a => a.AccountNumber.ToInt())];
            }
            else if (colName == "Balance")
            {
                balanceSort = balanceSort == SortState.None ? SortState.Asc :
                              balanceSort == SortState.Asc ? SortState.Desc : SortState.None;
                accountNumberSort = SortState.None; accountTypeSorted = false;
                if (balanceSort == SortState.Asc)
                    sorted = [.. AccountList.Accounts.OrderBy(a => a.Balance)];
                else if (balanceSort == SortState.Desc)
                    sorted = [.. AccountList.Accounts.OrderByDescending(a => a.Balance)];
            }
            else if (colName == "AccountType")
            {
                accountTypeSorted = !accountTypeSorted;
                accountNumberSort = SortState.None; balanceSort = SortState.None;
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit" || colName == "Delete") return;

            var acc = dataGridView1.Rows[e.RowIndex].DataBoundItem as Account;
            if (acc != null)
            {
                var customer = CustomerList.Customers.FirstOrDefault(c => c.UID == acc.CustomerID);
                if (customer != null)
                {
                    using var fCustomer = new FormCustomer();
                    fCustomer.ShowDialog();
                }
            }
        }
        
    }
}
