using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormAddEdit : Form
    {
        private User currentUser;

        // Constructor for Add/Edit mode
        public FormAddEdit(int mode = 0) // Truyền tham số giá trị 1 hoặc 0 để đổi mode là đc
        {
            InitializeComponent();

            if(mode == 0)
            {
                this.Text = "FormAdd";
                btnUser.Text = "ADD";
                this.MaximizeBox = false;                           // Ẩn nút phóng to
                this.FormBorderStyle = FormBorderStyle.FixedSingle; // Không cho resize
            }
            else if(mode == 1)
            {
                this.Text = "FormEdit";
                btnUser.Text = "SAVE";
                this.MaximizeBox = false;                           // Ẩn nút phóng to
                this.FormBorderStyle = FormBorderStyle.FixedSingle; // Không cho resize

                // load data cũ

                // ĐÂY LÀ DÒNG THỨ 36 CỦA CODE.RAUMANIA
            }
            else
            {
                throw new ArgumentException("Invalid mode. Use 0 for Add and 1 for Edit.");
            }
        }
    }
}
