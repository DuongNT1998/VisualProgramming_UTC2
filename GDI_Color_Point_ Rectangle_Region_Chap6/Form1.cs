using System.Drawing;
using System.Drawing.Drawing2D;
namespace GDI_Color_Point__Rectangle_Region_Chap6
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

            // 1. Color - tạo màu xanh dương
            Color myColor = Color.FromArgb(0, 120, 215); // RGB

            // 2. Point - xác định vị trí bắt đầu
            Point startPoint = new Point(50, 50);

            // 3. Rectangle - xác định hình chữ nhật
            Rectangle rect = new Rectangle(startPoint.X, startPoint.Y, 200, 100);

            // Vẽ viền hình chữ nhật
            Pen pen = new Pen(Color.Violet, 20);
            pen.DashStyle = DashStyle.DashDot;
            g.DrawRectangle(pen, rect);


            // Tô màu hình chữ nhật
            Brush brush = new SolidBrush(Color.Yellow);
            g.FillRectangle(brush, rect);



            // 4. Region - tạo vùng hình elip để tô vùng riêng
            Rectangle ellipseRect = new Rectangle(300, 50, 200, 100);
            Region ellipseRegion = new Region(new GraphicsPath());
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(ellipseRect);
            ellipseRegion = new Region(path);

            // Tô vùng Region
            g.FillRegion(Brushes.OrangeRed, ellipseRegion);

            // Ghi chú
            Font font = new Font("Segoe UI", 12);
            g.DrawString("Rectangle with Color and Point", font, Brushes.Black, new PointF(50, 170));
            g.DrawString("Region with Ellipse", font, Brushes.Green, new PointF(300, 170));
        }
    }
}
