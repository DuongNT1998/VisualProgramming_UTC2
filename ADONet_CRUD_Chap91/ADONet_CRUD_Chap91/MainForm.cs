namespace ADONet_CRUD_Chap91
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.FormClosed += delegate
            {
                if (!loginForm.IsLoggedIn)
                {
                    this.Close(); // Đóng nếu login fail
                }
            };
            loginForm.Show();
        }

        private void menuItemCategory_Click(object sender, System.EventArgs e)
        {
            FormCategory fc = new FormCategory();
            fc.MdiParent = this;
            fc.Show();
        }

        private void menuItemProduct_Click(object sender, System.EventArgs e)
        {
            FormProduct fp = new FormProduct();
            fp.MdiParent = this;
            fp.Show();
        }
    }
}
