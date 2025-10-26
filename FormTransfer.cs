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
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
            // đặt con trỏ vào txtFromAcc khi form được load
            this.ActiveControl = txtFromAcc;
            txtFromAcc.Focus();
        }
    }
}
