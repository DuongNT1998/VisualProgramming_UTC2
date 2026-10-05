namespace MDIForm_Chap8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuSpringForm_Click(object sender, EventArgs e)
        {
            Form2 springForm = new Form2();
            springForm.MdiParent = this;
            springForm.Show();
        }

        private void mnuSummerForm_Click(object sender, EventArgs e)
        {
            Form3 summerForm = new Form3();
            summerForm.MdiParent = this;
            summerForm.Show();
        }

        private void mnuAutumnForm_Click(object sender, EventArgs e)
        {
            Form4 autumnForm = new Form4();
            autumnForm.MdiParent = this;
            autumnForm.Show();
        }

        private void mnuWinterForm_Click(object sender, EventArgs e)
        {
            Form5 winterForm = new Form5();
            winterForm.MdiParent = this;
            winterForm.Show();
        }

        private void mnuCascadeLayout_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontalLayout_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVerticalLayout_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginForm lgForm = new LoginForm();
        
            lgForm.ShowDialog();
        }
    }
}
