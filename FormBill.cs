using BankManagement.Models;
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
        private Transaction _transaction;
        private string? _note; // store transfer note (if any)

        public FormBill(Transaction transaction)
        {
            InitializeComponent();
            // Ẩn nút phóng to
            this.MaximizeBox = false;

            // (tuỳ chọn) không cho resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _transaction = transaction;
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
           
        }

        /// <summary>
        /// Populates the transaction details on the bill form.
        /// </summary>
        public void PopulateTransaction()
        {
            try
            {
                if (_transaction == null) return;

                // From / FromAcc
                if (lblFrom != null) lblFrom.Text = _transaction.FromAccountNumber ?? string.Empty;

                // To / ToAcc
                if (lblTo != null) lblTo.Text = _transaction.ToAccountNumber ?? string.Empty;

                // Amount / Money
                string fmtAmount = $"{_transaction.Amount:N2} VND";
                if (lblMoney != null) lblMoney.Text = fmtAmount;

                // Transaction ID / Time
                if (lblID != null) lblID.Text = _transaction.TransactionID ?? string.Empty;
                if (lblTime != null) lblTime.Text = _transaction.TransactionTime.ToString("g");

                // Notes / Status / Description
                if (!string.IsNullOrWhiteSpace(_note))
                {
                    if (lblDescription != null)
                    {
                        lblDescription.Visible = true;
                        lblDescription.Text = _note;
                    }
                    if (lblNotes != null) lblNotes.Visible = true; // keep label visible
                }
                else
                {
                    // No note provided: show/hide as you prefer (keep existing behavior)
                    if (lblDescription != null) lblDescription.Text = string.Empty;
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
