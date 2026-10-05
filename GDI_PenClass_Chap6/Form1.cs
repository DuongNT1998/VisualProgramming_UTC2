using System.Drawing.Drawing2D;

namespace GDI_PenClass_Chap6
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
            Font labelFont = new Font("Segoe UI", 10);
            int startY = 20;
            int spacingY = 100;
            int labelX = 20;
            int lineX = 150;
            int lineLength = 400;

            // 1. Sử dụng Pen với LineCap và DashCap
            g.DrawString("Pen with LineCap", labelFont, Brushes.Black, labelX, startY);
            Pen penWithLineCap = new Pen(Color.SteelBlue, 5);
            penWithLineCap.StartCap = LineCap.Round;    // Dấu bắt đầu đường vẽ
            penWithLineCap.EndCap = LineCap.Square;    // Dấu kết thúc đường vẽ
            g.DrawLine(penWithLineCap, lineX, startY + 20, lineX + lineLength, startY + 20);
            penWithLineCap.Dispose();

            // 2. Sử dụng Pen với DashStyle
            startY += spacingY;
            g.DrawString("Pen with DashStyle", labelFont, Brushes.Black, labelX, startY);
            Pen penWithDashStyle = new Pen(Color.Red, 5);
            penWithDashStyle.DashStyle = DashStyle.DashDot;  // Dấu chấm và gạch
            g.DrawLine(penWithDashStyle, lineX, startY + 20, lineX + lineLength, startY + 20);
            penWithDashStyle.Dispose();

            // 3. Sử dụng Pen với DashCap
            startY += spacingY;
            g.DrawString("Pen with DashCap", labelFont, Brushes.Black, labelX, startY);
            Pen penWithDashCap = new Pen(Color.Green, 5);
            penWithDashCap.DashCap = DashCap.Round;  // Tạo đầu và cuối đường nét gạch tròn
            penWithDashCap.DashStyle = DashStyle.Dash;  // Chỉ sử dụng đường gạch
            g.DrawLine(penWithDashCap, lineX, startY + 20, lineX + lineLength, startY + 20);
            penWithDashCap.Dispose();

            // 4. Sử dụng Pen với Custom Dash Pattern
            startY += spacingY;
            g.DrawString("Pen with Custom DashPattern", labelFont, Brushes.Black, labelX, startY);
            Pen penCustomDash = new Pen(Color.Purple, 5);
            penCustomDash.DashPattern = new float[] { 10, 5, 2, 5 }; // Chỉnh đường nét của Dash
            g.DrawLine(penCustomDash, lineX, startY + 20, lineX + lineLength, startY + 20);
            penCustomDash.Dispose();

            labelFont.Dispose();
        }
    }
}
