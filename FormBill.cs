using BankManagement.Models;
using BankManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormBill : Form
    {
        public Transaction CurrentTransaction { get; set; }
        private string? _note; // store transfer note (if any)
        private TransactionType _mode; // Transaction mode

        public FormBill(Transaction transaction)
        {
            InitializeComponent();
            CurrentTransaction = transaction;
            _mode = transaction.Type; // Set mode based on transaction type
        }

        // new overload to accept note from FormTransfer
        public FormBill(Transaction transaction, string? note) : this(transaction)
        {
            _note = note;
        }

        // ensure this handler exists in the same partial class (same namespace)
        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            PopulateTransaction();
            ApplyModeLayout(); // Apply layout based on mode
        }

        /// <summary>
        /// Applies UI layout changes based on transaction mode (Deposit/Withdraw/Transfer)
        /// Completely removes hidden rows from the layout so other rows move up
        /// </summary>
        private void ApplyModeLayout()
        {
            try
            {
                // Suspend layout để tránh flicker khi thay đổi nhiều lần
                tableLayoutPanel.SuspendLayout();

                switch (_mode)
                {
                    case TransactionType.Deposit:
                        // DEPOSIT: Chỉ hiển thị thông tin người nhận
                        HideRow(pnlRowFrom);
                        ShowRow(pnlRowTo); 

                        // Update title
                        if (lblTitle != null) lblTitle.Text = "DEPOSIT RECEIPT";
                        break;

                    case TransactionType.Withdraw:
                        // WITHDRAW: Chỉ hiển thị thông tin người rút
                        ShowRow(pnlRowFrom);
                        HideRow(pnlRowTo); 

                        // Update title
                        if (lblTitle != null) lblTitle.Text = "WITHDRAWAL RECEIPT";
                        break;

                    case TransactionType.Transfer:
                        // TRANSFER: Hiển thị đầy đủ cả 2 hàng
                        ShowRow(pnlRowFrom); 
                        ShowRow(pnlRowTo);

                        // Update title
                        if (lblTitle != null) lblTitle.Text = "TRANSFER RECEIPT";
                        break;
                }

                // Resume layout và refresh
                tableLayoutPanel.ResumeLayout(true);
                tableLayoutPanel.PerformLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying mode layout:\n{ex.Message}", "FormBill Layout Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Hides a panel row completely - the row disappears and other rows move up
        /// </summary>
        /// <param name="panel">The panel to hide</param>
        private void HideRow(Panel panel)
        {
            if (panel == null) return;

            // Set Visible = false để ẩn panel
            panel.Visible = false;

            // Get vị trí row của panel trong TableLayoutPanel
            int row = tableLayoutPanel.GetRow(panel);

            // Set row height = 0 để các row khác dồn lên
            if (row >= 0 && row < tableLayoutPanel.RowStyles.Count)
            {
                tableLayoutPanel.RowStyles[row].SizeType = SizeType.Absolute;
                tableLayoutPanel.RowStyles[row].Height = 0;
            }
        }

        /// <summary>
        /// Shows a panel row - restore its visibility and auto-height
        /// </summary>
        /// <param name="panel">The panel to show</param>
        private void ShowRow(Panel panel)
        {
            if (panel == null) return;

            // Set Visible = true để hiện panel
            panel.Visible = true;

            // Get vị trí row của panel trong TableLayoutPanel
            int row = tableLayoutPanel.GetRow(panel);

            // Restore row height về AutoSize để tự động tính chiều cao
            if (row >= 0 && row < tableLayoutPanel.RowStyles.Count)
            {
                tableLayoutPanel.RowStyles[row].SizeType = SizeType.AutoSize;
            }
        }

        /// <summary>
        /// Populates the transaction details on the bill form.
        /// </summary>
        public void PopulateTransaction()
        {
            try
            {
                if (CurrentTransaction == null) return;

                // From / FromAcc
                if (lblFrom != null)
                {
                    lblFrom.Text = CurrentTransaction.Sender ?? "N/A";
                    lblFromAccNum.Text = CurrentTransaction.FromAccountNumber ?? string.Empty; 
                }

                // To / ToAcc
                if (lblTo != null)
                {
                    lblTo.Text = CurrentTransaction.Receiver ?? "N/A";
                    lblToAccNum.Text = CurrentTransaction.ToAccountNumber ?? string.Empty; 
                }

                // Amount / Money
                string fmtAmount = $"{CurrentTransaction.Amount:N0} VND";
                if (lblMoney != null) lblMoney.Text = fmtAmount;

                // Transaction Type
                if (lblTransactionType != null) lblTransactionType.Text = _mode.ToString();

                // Transaction ID / Time
                if (lblID != null) lblID.Text = CurrentTransaction.TransactionID ?? string.Empty;
                if (lblTime != null) lblTime.Text = CurrentTransaction.TransactionTime.ToString("g");

                // Notes / Status / Description
                if (!string.IsNullOrWhiteSpace(_note))
                {
                    if (lblDescription != null)
                    {
                        lblDescription.Visible = true;
                        lblDescription.Text = _note;
                    }
                    if (lblNotes != null) lblNotes.Visible = true;
                }
                else
                {
                    // No note provided: hide notes section
                    HideNotes();
                }

                if (lblSta != null) lblSta.Text = "Successful";

            }
            catch (Exception ex)
            {
                // Show full exception to help identify the crash cause
                MessageBox.Show($"PopulateTransaction threw an exception:\n{ex}", "FormBill error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Make sure the bill will not show notes/descriptions copied from transfer form.
        /// </summary>
        public void HideNotes()
        {
            // Clear text and hide note-related labels so transfer notes are not shown on the bill
            if (lblNotes != null)
            {
                lblNotes.Text = string.Empty;
                lblNotes.Visible = false;
            }
            if (lblDescription != null)
            {
                lblDescription.Text = string.Empty;
                lblDescription.Visible = false;
            }
        }
    }
}
