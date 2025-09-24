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
    public partial class FormFlash : Form
    {
        public FormFlash()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e) 
        {
            this.DialogResult = DialogResult.OK;
            timer1.Enabled = false;
        }

        private void FormFlash_Load(object sender, EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }
    }
}
