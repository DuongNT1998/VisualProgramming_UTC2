namespace MouseEvent_Chap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbMouseClick_MouseClick(object sender, MouseEventArgs e)
        {
            //Sự kiện Mouse Click: click vào label sẽ đổi màu nền label
            lbMouseClick.BackColor = Color.Yellow;
        }

        private void lbEnterHoverLeave_MouseEnter(object sender, EventArgs e)
        {
            //Sự kiện Mouse Enter: sẽ đổi màu chữ  sang xanh
            //lbEnterHoverLeave.ForeColor = Color.Green;
        }

        private void lbEnterHoverLeave_MouseHover(object sender, EventArgs e)
        {
            //Sự kiện Mouse Hover: sẽ đổi màu chữ  sang đỏ
           // lbEnterHoverLeave.ForeColor = Color.Red;
        }

        private void lbEnterHoverLeave_MouseLeave(object sender, EventArgs e)
        {
            //Sự kiện Mouse Leave: sẽ đổi màu chữ  sang Nâu
            //lbEnterHoverLeave.ForeColor = Color.Brown;
        }

        private void txtMouseUpDown_MouseDown(object sender, MouseEventArgs e)
        {
            txtMouseDown.BackColor = Color.Green;
            MessageBox.Show("Bạn vừa nhấn chuột xuống");
        }



        private void txtMouseUp_MouseUp(object sender, MouseEventArgs e)
        {
           txtMouseUp.BackColor = Color.Red;
            MessageBox.Show("Bạn vừa thả chuột ra ");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Violet;
            MessageBox.Show("Bạn đang di chuyển trên form ");

        }
    }
}
