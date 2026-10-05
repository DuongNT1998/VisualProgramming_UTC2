using System.Drawing;
using System.Drawing.Drawing2D;
namespace GDI_BrushClass_Chap6
{
    public partial class Form1 : Form
    {
        private Image textureImage;
        public Form1()
        {
            InitializeComponent();

            // Tạo ảnh bitmap đơn giản cho TextureBrush
            textureImage = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage(textureImage);
            g.Clear(Color.LightYellow);
            g.FillEllipse(Brushes.Blue, 5, 5, 30, 30);
            g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font labelFont = new Font("Segoe UI", 10);
            int startY = 20;
            int spacingY = 100;
            int labelX = 20;
            int rectX = 150;
            int rectWidth = 200;
            int rectHeight = 60;

            // 1. SolidBrush
            g.DrawString("SolidBrush", labelFont, Brushes.Black, labelX, startY);
            SolidBrush solidBrush = new SolidBrush(Color.SteelBlue);
            g.FillRectangle(solidBrush, rectX, startY, rectWidth, rectHeight);
            solidBrush.Dispose();

            // 2. HatchBrush
            startY += spacingY;
            g.DrawString("HatchBrush (DiagonalCross)", labelFont, Brushes.Black, labelX, startY);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.DarkRed, Color.Yellow);
            g.FillRectangle(hatchBrush, rectX, startY, rectWidth, rectHeight);
            hatchBrush.Dispose();

            // 3. LinearGradientBrush
            startY += spacingY;
            g.DrawString("LinearGradientBrush", labelFont, Brushes.Black, labelX, startY);
            LinearGradientBrush linearBrush = new LinearGradientBrush(
                new Rectangle(rectX, startY, rectWidth, rectHeight),
                Color.Green,
                Color.LightGreen,
                LinearGradientMode.Horizontal);
            g.FillRectangle(linearBrush, rectX, startY, rectWidth, rectHeight);
            linearBrush.Dispose();

            // 4. PathGradientBrush
            startY += spacingY;
            g.DrawString("PathGradientBrush", labelFont, Brushes.Black, labelX, startY);
            GraphicsPath path = new GraphicsPath();
            Point[] points = {
                new Point(rectX, startY + rectHeight),
                new Point(rectX + rectWidth / 2, startY),
                new Point(rectX + rectWidth, startY + rectHeight)
            };
            path.AddPolygon(points);
            PathGradientBrush pathBrush = new PathGradientBrush(path);
            pathBrush.CenterColor = Color.White;
            pathBrush.SurroundColors = new Color[] { Color.Red };
            g.FillPath(pathBrush, path);
            pathBrush.Dispose();
            path.Dispose();

            // 5. TextureBrush
            startY += spacingY;
            g.DrawString("TextureBrush", labelFont, Brushes.Black, labelX, startY);
            TextureBrush textureBrush = new TextureBrush(textureImage);
            g.FillRectangle(textureBrush, rectX, startY, rectWidth, rectHeight);
            textureBrush.Dispose();

            labelFont.Dispose();
        }
    }
}
