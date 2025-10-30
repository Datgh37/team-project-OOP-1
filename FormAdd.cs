using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormAdd : Form
    {
        public Account NewAccount { get; private set; }
        public Customer NewCustomer { get; private set; }
        public FormAdd()
        {
            InitializeComponent();
            // Ẩn nút phóng to
            this.MaximizeBox = false;

            // (tuỳ chọn) không cho resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.ActiveControl = txtFirstName;
            txtFirstName.Focus();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtBalance.Text))
                {
                    MessageBox.Show("Please fill in all required fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập liệu không hợp lệ: " + ex.Message);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}

