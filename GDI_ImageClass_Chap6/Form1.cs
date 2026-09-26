using System.Drawing;
using System.Drawing.Imaging;
namespace GDI_ImageClass_Chap6
{
    public partial class Form1 : Form
    {
        private Image image;    // Biến lưu ảnh
        private Icon icon;      // Biến lưu icon
        public Form1()
        {
            InitializeComponent();

            // Tải ảnh và icon
            image = Image.FromFile("D://Tài liệu giảng dạy UIT//Tài liệu UTC2//Lập trình trực quan//Code demo LT//GDI_ImageClass_Chap6//car.jpg");    // Đảm bảo có ảnh "example.jpg" trong thư mục chạy
            icon = new Icon("D://Tài liệu giảng dạy UIT//Tài liệu UTC2//Lập trình trực quan//Code demo LT//GDI_ImageClass_Chap6//email.ico");           // Đảm bảo có icon "example.ico"
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font labelFont = new Font("Segoe UI", 10);
            int startY = 20;
            int spacingY = 120;
            int labelX = 20;
            int imageX = 150;
            int imageWidth = 200;
            int imageHeight = 150;

            // 1. DrawImage (Vẽ hình ảnh với kích thước cụ thể)
            g.DrawString("DrawImage (Scaled)", labelFont, Brushes.Black, labelX, startY);
            g.DrawImage(image, imageX, startY + 20, imageWidth, imageHeight);

            // 2. DrawImageUnscaled (Vẽ hình ảnh không thay đổi kích thước)
            startY += spacingY;
            g.DrawString("DrawImageUnscaled", labelFont, Brushes.Black, labelX, startY);
            g.DrawImageUnscaled(image, imageX, startY + 20);

            // 3. DrawIcon (Vẽ biểu tượng)
            startY += spacingY;
            g.DrawString("DrawIcon", labelFont, Brushes.Black, labelX, startY);
            g.DrawIcon(icon, imageX, startY + 20);

            // 4. DrawIconUnstretched (Vẽ biểu tượng không thay đổi kích thước)
            startY += spacingY;
            g.DrawString("DrawIconUnstretched", labelFont, Brushes.Black, labelX, startY);
            g.DrawIconUnstretched(icon, new Rectangle(imageX, startY + 20, icon.Width, icon.Height));

            // 5. RotateFlip (Xoay và lật hình ảnh)
            startY += spacingY;
            g.DrawString("RotateFlip (90 degrees)", labelFont, Brushes.Black, labelX, startY);
            Image rotatedImage = (Image)image.Clone();
            rotatedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            g.DrawImage(rotatedImage, imageX, startY + 20, imageWidth, imageHeight);

            labelFont.Dispose();
            rotatedImage.Dispose();
        }
    }
}
