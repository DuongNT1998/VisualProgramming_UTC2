using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppDeployment_Chap11.Helpers
{

    public static class ImageHelper
    {
        public static readonly string ImageFolder =
            Path.Combine(Application.StartupPath, "Images", "SanPham");

        static ImageHelper()
        {
            if (!Directory.Exists(ImageFolder))
                Directory.CreateDirectory(ImageFolder);
        }

        public static string CopyImageToFolder(string sourceFilePath)
        {
            string extension = Path.GetExtension(sourceFilePath);
            string newFileName = $"{System.Guid.NewGuid()}{extension}";
            string destPath = Path.Combine(ImageFolder, newFileName);
            File.Copy(sourceFilePath, destPath, overwrite: true);
            return newFileName;
        }

        public static Image LoadImage(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) return CreatePlaceholder();
            string fullPath = Path.Combine(ImageFolder, fileName);
            if (!File.Exists(fullPath)) return CreatePlaceholder();

            byte[] bytes = File.ReadAllBytes(fullPath);
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        public static Image CreatePlaceholder()
        {
            var bmp = new Bitmap(100, 100);
            using var g = Graphics.FromImage(bmp);
            g.Clear(Color.WhiteSmoke);
            g.DrawRectangle(Pens.Gray, 0, 0, 99, 99);
            using var font = new Font("Segoe UI", 8);
            g.DrawString("No Image", font, Brushes.Gray, 15, 40);
            return bmp;
        }

        public static void DeleteImageFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) return;
            string fullPath = Path.Combine(ImageFolder, fileName);
            if (File.Exists(fullPath))
            {
                try { File.Delete(fullPath); } catch { }
            }
        }
    }
}
