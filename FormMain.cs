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
        private AccountManagement AccList = new AccountManagement();
        private CustomerManagement CustomerList = new CustomerManagement();
        private List<Account> currentAccounts = new();  // danh sách đang hiển thị (tham chiếu tới objects)
        private List<string> originalSerialized = new(); // bản gốc serialized để so sánh chính xác ký tự
        private bool isChanged = false;
        private readonly string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "AccountInfo.csv");// path lưu file (giữ cùng chỗ AccountManagement đọc)
        private DataTable dt = new DataTable();
        public FormMain()
        {
            InitializeComponent();
            Load += FormMain_Load;
            FormClosing += FormMain_FormClosing;
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            // Load danh sách từ AccountManagement (không sửa AccountManagement)
            var accountList = AccList.GetAccountList() ?? new List<Account>();
            currentAccounts = accountList;

            // Tạo bản serialized ban đầu (dùng để so sánh chính xác từng ký tự/dấu phẩy)
            originalSerialized = currentAccounts.Select(a => SerializeAccount(a)).ToList();

            // Gán DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = currentAccounts;

            // Sự kiện

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private string SerializeAccount(Account a)
        {
            string typeValue = a.Type.ToString() switch
            {
                "Debit" => "0",
                "Credit" => "1",
                "Savings" => "2",
                _ => "0"
            };

            return string.Join(",",
                a.AccountNumber,
                a.Balance.ToString(CultureInfo.InvariantCulture),
                a.InterestRate.ToString(CultureInfo.InvariantCulture),
                a.OpenAt.ToString("dd-MM-yyyy"),
                typeValue,
                a.CustomerID.ToString()
            );
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //mở form Add
            using var fadd = new FormAdd();
            fadd.ShowDialog();
        }


        ///////////////////////////////////////////////////////////
        private void FormMain_Load_1(object sender, EventArgs e)///
        {                                                       ///
                                                                ///
        }                                                       ///
        ///////////////////////////////////////////////////////////
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
                    if (e.RowIndex >= 0 && e.RowIndex < currentAccounts.Count)
                    {
                        currentAccounts.RemoveAt(e.RowIndex); // xóa object khỏi list hiện tại
                        // rebind để cập nhật DataGridView
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = currentAccounts;
                        isChanged = true;
                    }
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo serialized hiện tại
            var currentSerialized = currentAccounts.Select(a => SerializeAccount(a)).ToList();

            // So sánh chuỗi (SequenceEqual đảm bảo thứ tự và nội dung chính xác, khác dù 1 ký tự)
            bool hasChanged = !originalSerialized.SequenceEqual(currentSerialized);

            if (hasChanged || isChanged)
            {
                var result = MessageBox.Show(
                    "Dữ liệu đã thay đổi. Bạn có muốn lưu lại không?",
                    "Xác nhận lưu",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SaveAccountsToCsv(currentAccounts, csvPath);
                    isChanged = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Ở lại form
                }
                // Nếu No -> thoát mà không lưu
            }
        }

        // 🔹 Hàm này tự xử lý ghi file CSV (không đụng đến AccountManagement)
        private void SaveAccountsToCsv(List<Account> accounts, string path)
        {
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(dir))
                Directory.CreateDirectory(dir);

            using (var writer = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                writer.WriteLine("AccountNumber,Balance,InterestRate,OpenAt,Type,CustomerID");
                foreach (var a in accounts)
                {
                    writer.WriteLine(SerializeAccount(a));
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu textbox trống → hiện tất cả
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = currentAccounts;
                return;
            }

            // Lọc list theo AccountNumber hoặc Type hoặc CustomerID
            var filtered = currentAccounts.Where(a =>
                a.AccountNumber.ToLower().Contains(keyword) ||
                a.Type.ToString().ToLower().Contains(keyword) ||
                a.CustomerID.ToString().ToLower().Contains(keyword)
            ).ToList();

            // Bind lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered;
        }

        private void pictureBox_OpenTransfer_Click(object sender, EventArgs e)
        {
            using var ftransfer = new FormTransfer();
            ftransfer.ShowDialog();
        }
    }
}
