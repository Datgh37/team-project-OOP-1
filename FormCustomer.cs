using BankManagement.Models;
using System;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormCustomer : Form
    {
        public Account SelectedAccount { get; private set; }
        public Customer SelectedCustomer { get; private set; }
        private Account _originalAccount;
        private Customer _originalCustomer;

        public FormCustomer(Account account, Customer customer) : this()
        {
            SelectedAccount = new Account(account);
            SelectedCustomer = new Customer(customer);
            _originalAccount = new Account(account);
            _originalCustomer = new Customer(customer);
        }
        public FormCustomer()
        {
            InitializeComponent();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            lbl_uid.Text = SelectedCustomer.UID.ToString();
            lbl_cid.Text = SelectedCustomer.CID;
            UpdateInputField();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FormEdit f = new FormEdit(SelectedAccount, SelectedCustomer))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SelectedAccount = f.SelectedAccount;
                    SelectedCustomer = f.SelectedCustomer;
                    // Cập nhật lại giao diện nếu muốn
                    UpdateInputField();
                }
            }
        }
        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsSame(_originalAccount, SelectedAccount) || !IsSame(_originalCustomer, SelectedCustomer))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool IsSame(Account a, Account b)
        {
            return a.Balance == b.Balance &&
                   a.InterestRate == b.InterestRate;
        }
        private bool IsSame(Customer a, Customer b)
        {
            return a.FirstName == b.FirstName &&
                   a.LastName == b.LastName &&
                   a.CID == b.CID &&
                   a.Address == b.Address &&
                   a.Email == b.Email &&
                   a.Phone == b.Phone &&
                   a.BirthDate == b.BirthDate &&
                   a.Gender == b.Gender;
        }
        private void UpdateInputField()
        {
            lbl_firstname.Text = SelectedCustomer.FirstName;
            lbl_lastname.Text = SelectedCustomer.LastName;
            lbl_address.Text = SelectedCustomer.Address;
            lbl_email.Text = SelectedCustomer.Email;
            lbl_phone.Text = SelectedCustomer.Phone;
            lbl_dob.Text = SelectedCustomer.BirthDate.ToString("dd/MM/yyyy");
            lbl_gender.Text = SelectedCustomer.Gender.ToString();
        }
    }
}
