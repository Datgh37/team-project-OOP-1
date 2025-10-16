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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            // Ẩn nút phóng to
            this.MaximizeBox = false;

            // (tuỳ chọn) không cho resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FormEdit f = new FormEdit())   // mở form ở chế độ Edit
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }
    }
}
