namespace BankManagement
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAdd f = new FormAdd())   // mở form ở chế độ Add
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi bấm "Thêm" trong FormUser
                    // TODO: refresh lại DataGridView hoặc danh sách user
                    //LoadUser();
                }
            }

        }
    }
}
