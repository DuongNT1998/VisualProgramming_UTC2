using System.Drawing;
using System.Drawing.Drawing2D;
namespace GDI_FontClass_Chap6
   
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            string text = "Xin chào, đây là font demo!";
            int startY = 20;
            int spacing = 50;

            // Font bình thường
            Font font1 = new Font("Arial", 14, FontStyle.Regular);
            g.DrawString("Regular", new Font("Segoe UI", 10), Brushes.Black, 10, startY);
            g.DrawString(text, font1, Brushes.DarkBlue, 150, startY);

            // Font in đậm
            startY += spacing;
            Font font2 = new Font("Arial", 14, FontStyle.Bold);
            g.DrawString("Bold", new Font("Segoe UI", 10), Brushes.Black, 10, startY);
            g.DrawString(text, font2, Brushes.DarkGreen, 150, startY);

            // Font nghiêng
            startY += spacing;
            Font font3 = new Font("Arial", 14, FontStyle.Italic);
            g.DrawString("Italic", new Font("Segoe UI", 10), Brushes.Black, 10, startY);
            g.DrawString(text, font3, Brushes.OrangeRed, 150, startY);

            // Font gạch chân
            startY += spacing;
            Font font4 = new Font("Arial", 14, FontStyle.Underline);
            g.DrawString("Underline", new Font("Segoe UI", 10), Brushes.Black, 10, startY);
            g.DrawString(text, font4, Brushes.DarkMagenta, 150, startY);

            // Font vừa đậm vừa nghiêng
            startY += spacing;
            Font font5 = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Bold + Italic", new Font("Segoe UI", 10), Brushes.Black, 10, startY);
            g.DrawString(text, font5, Brushes.Teal, 150, startY);

            // Font với GraphicsUnit.Point
            startY += spacing;
            Font font6 = new Font("Times New Roman", 18, FontStyle.Regular, GraphicsUnit.Point);
            g.DrawString("Times New Roman", new Font("Segoe UI", 10), Brushes.Black, 10, startY);
            g.DrawString(text, font6, Brushes.Brown, 150, startY);
        }
    }
}
