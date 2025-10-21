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
        public FormMain()
        {
            InitializeComponent();
            Load += FormMain_Load;
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new FormAdd();
            if (f.ShowDialog() == DialogResult.OK)
                
        }

        
    }
}
