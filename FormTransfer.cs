using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormTransfer : Form
    {
        public Account? TransferAccount; // optional pre-filled account
        private readonly AccountManagement _accountMgr; // added to lookup balances

        public FormTransfer()
        {
            InitializeComponent();

            // Ẩn nút phóng to, không cho resize
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.ActiveControl = txtFromAcc;
            txtFromAcc.Focus();

            // initialize account manager and try to load accounts (silent on error)
            _accountMgr = new AccountManagement();
            try
            {
                _accountMgr.ImportAccountListFromCSV();
            }
            catch
            {
                // ignore load errors to preserve existing behavior
            }

            // validate destination account when user leaves the field
            txtToAcc.Leave += TxtToAcc_Leave;
        }

        // optional ctor to pre-fill from-account
        public FormTransfer(Account account) : this()
        {
            TransferAccount = new Account(account);
            txtFromAcc.Text = account.AccountNumber;
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            // optional initialization
        }

        private void txtFromAcc_TextChanged(object sender, EventArgs e)
        {
            // keep simple: UI feedback can be implemented here (balance lookup, validation...)
            // Example (commented): show balance if you have a data source to lookup account
            // lblBalance.Text = $"Số dư: {foundAccount?.Balance:N2} VND";

            try
            {
                var accNum = txtFromAcc?.Text?.Trim();
                if (string.IsNullOrEmpty(accNum))
                {
                    if (lblMoney != null)
                        lblMoney.Text = "Money";
                    return;
                }

                var acc = _accountMgr[accNum];
                if (acc != null)
                {
                    if (lblMoney != null)
                        lblMoney.Text = $"{acc.Balance:N2} VND";
                }
                else
                {
                    if (lblMoney != null)
                        lblMoney.Text = "Account not found";
                }
            }
            catch
            {
                // keep silent to avoid changing existing behavior
            }
        }

        // new: validate dest account on leave
        private void TxtToAcc_Leave(object? sender, EventArgs e)
        {
            try
            {
                var toAcc = txtToAcc?.Text?.Trim();
                if (string.IsNullOrEmpty(toAcc)) return;

                if (_accountMgr[toAcc] == null)
                {
                    MessageBox.Show("Tài khoản nhận không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtToAcc.Focus();
                }
            }
            catch
            {
                // silent
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string fromAcc = txtFromAcc.Text.Trim();
            string toAcc = txtToAcc.Text.Trim();

            if (string.IsNullOrEmpty(fromAcc) || string.IsNullOrEmpty(toAcc))
            {
                MessageBox.Show("Vui lòng nhập cả tài khoản nguồn và tài khoản đích.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse amount from txtAmount
            if (!double.TryParse(txtAmount.Text.Trim(), out double amount) || amount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }

            // validate source account existence and balance/credit rules before creating transaction
            var fromAccountObj = _accountMgr[fromAcc];
            if (fromAccountObj == null)
            {
                MessageBox.Show("Tài khoản nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFromAcc.Focus();
                return;
            }

            // Check balance / overdraft / credit limit
            if (!fromAccountObj.Type.AllowOverdraft && fromAccountObj.Balance < amount)
            {
                MessageBox.Show("Số dư không đủ cho giao dịch này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }

            try
            {
                // Create transaction (validation inside Transaction constructor)
                var transaction = new Transaction(fromAcc, toAcc, amount, TransactionType.Transfer);

                // Show bill form and pass the transaction and the transfer note
                using var billForm = new FormBill(transaction, txtNotes.Text);

                // PopulateTransaction() is public on FormBill and also called on Load,
                // but calling explicitly ensures labels are up to date before showing.
                billForm.PopulateTransaction();

                // Use ShowDialog so user confirms/reads bill; after dialog closes, close transfer form
                billForm.ShowDialog(this);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
