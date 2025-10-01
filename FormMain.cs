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
            using (FormAddEdit f = new FormAddEdit(0))   // mở form ở chế độ Add
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi bấm "Thêm" trong FormUser
                    // TODO: refresh lại DataGridView hoặc danh sách user
                    // LoadUsers();  
                }
            }
        }
    }
}
