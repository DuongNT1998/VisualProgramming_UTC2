using System.Drawing;
using System.Drawing.Drawing2D;

namespace GDI_GraphicsClass_Chap6
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
            Pen pen = new Pen(Color.DarkBlue, 2);
            Brush brush = new SolidBrush(Color.Orange);
            Font labelFont = new Font("Segoe UI", 10);
            int startY = 20;
            int spacingY = 60;
            int labelX = 20;
            int shapeX = 150;

            // 1. DrawLine
            g.DrawString("DrawLine", labelFont, Brushes.Black, labelX, startY);
            g.DrawLine(pen, shapeX, startY + 10, shapeX + 150, startY + 10);

            // 2. DrawRectangle
            startY += spacingY;
            g.DrawString("DrawRectangle", labelFont, Brushes.Black, labelX, startY);
            g.DrawRectangle(pen, shapeX, startY, 100, 40);

            // 3. FillRectangle
            startY += spacingY;
            g.DrawString("FillRectangle", labelFont, Brushes.Black, labelX, startY);
            g.FillRectangle(brush, shapeX, startY, 100, 40);

            // 4. DrawEllipse
            startY += spacingY;
            g.DrawString("DrawEllipse", labelFont, Brushes.Black, labelX, startY);
            g.DrawEllipse(pen, shapeX, startY, 100, 40);

            // 5. FillEllipse
            startY += spacingY;
            g.DrawString("FillEllipse", labelFont, Brushes.Black, labelX, startY);
            g.FillEllipse(Brushes.Green, shapeX, startY, 100, 40);

            // 6. DrawArc
            startY += spacingY;
            g.DrawString("DrawArc", labelFont, Brushes.Black, labelX, startY);
            g.DrawArc(pen, shapeX, startY, 100, 40, 0, 180);

            // 7. DrawCurve
            startY += spacingY;
            g.DrawString("DrawCurve", labelFont, Brushes.Black, labelX, startY);
            Point[] curvePoints = {
                new Point(shapeX, startY + 20),
                new Point(shapeX + 30, startY - 10),
                new Point(shapeX + 60, startY + 40),
                new Point(shapeX + 90, startY + 10)
            };
            g.DrawCurve(pen, curvePoints);

            // 8. DrawBezier
            startY += spacingY;
            g.DrawString("DrawBezier", labelFont, Brushes.Black, labelX, startY);
            g.DrawBezier(pen, new Point(shapeX, startY + 20), new Point(shapeX + 30, startY - 10),
                         new Point(shapeX + 60, startY + 50), new Point(shapeX + 90, startY + 20));

            // 9. DrawPolygon
            startY += spacingY;
            g.DrawString("DrawPolygon", labelFont, Brushes.Black, labelX, startY);
            Point[] polygonPoints = {
                new Point(shapeX, startY + 30),
                new Point(shapeX + 40, startY),
                new Point(shapeX + 80, startY + 30),
                new Point(shapeX + 60, startY + 50)
            };
            g.DrawPolygon(pen, polygonPoints);

            // 10. FillPolygon
            startY += spacingY;
            g.DrawString("FillPolygon", labelFont, Brushes.Black, labelX, startY);
            g.FillPolygon(Brushes.Purple, polygonPoints);

            // 11. DrawPath
            startY += spacingY;
            g.DrawString("DrawPath", labelFont, Brushes.Black, labelX, startY);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(shapeX, startY, 60, 40);
            path.AddRectangle(new Rectangle(shapeX + 80, startY, 60, 40));
            g.DrawPath(new Pen(Color.Red, 2), path);

            // 12. FillRegion
            startY += spacingY;
            g.DrawString("FillRegion", labelFont, Brushes.Black, labelX, startY);
            Region region = new Region(path);
            g.FillRegion(Brushes.LightBlue, region);

            // 13. DrawString
            startY += spacingY;
            g.DrawString("DrawString", labelFont, Brushes.Black, labelX, startY);
            Font textFont = new Font("Segoe UI", 12, FontStyle.Bold);
            g.DrawString("Hello GDI+", textFont, Brushes.Black, shapeX, startY);
        }
    }
}
