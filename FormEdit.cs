using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
            // Ẩn nút phóng to
            this.MaximizeBox = false;

            // (tuỳ chọn) không cho resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.ActiveControl = txtFirstName;
            txtFirstName.Focus();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
