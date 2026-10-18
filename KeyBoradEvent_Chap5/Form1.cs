namespace KeyBoradEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKeyUp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T)
                MessageBox.Show("T key pressed !");
            else if (e.KeyCode == Keys.Q)
                MessageBox.Show("Q key pressed !");
            else MessageBox.Show($"{e.KeyCode} key pressed !");
        }

        private void txtKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"{e.KeyCode} key is pressed !");
        }

        private void txtKeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                MessageBox.Show("Enter key is pressed !");
        }
    }
}
