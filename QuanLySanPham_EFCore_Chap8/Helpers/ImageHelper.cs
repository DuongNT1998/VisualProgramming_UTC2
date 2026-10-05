using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLySanPham_EFCore_Chap8.Helpers
{
    public static class ImageHelper
    {
        // Thư mục lưu ảnh sản phẩm — nằm cạnh file .exe khi chạy
        public static readonly string ImageFolder =
            Path.Combine(Application.StartupPath, "Images", "SanPham");

        static ImageHelper()
        {
            if (!Directory.Exists(ImageFolder))
                Directory.CreateDirectory(ImageFolder);
        }

        /// Copy ảnh người dùng chọn vào thư mục Images/SanPham, đặt tên file duy nhất (Guid)
        /// Trả về TÊN FILE (không phải full path) — đây là giá trị lưu vào cột hinh_anh trong DB
        public static string CopyImageToFolder(string sourceFilePath)
        {
            string extension = Path.GetExtension(sourceFilePath);
            string newFileName = $"{Guid.NewGuid()}{extension}";
            string destPath = Path.Combine(ImageFolder, newFileName);

            File.Copy(sourceFilePath, destPath, overwrite: true);
            return newFileName;
        }

        /// Đọc ảnh an toàn từ tên file (đọc qua MemoryStream để không khóa file gốc)
        public static Image LoadImage(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return CreatePlaceholder();

            string fullPath = Path.Combine(ImageFolder, fileName);
            if (!File.Exists(fullPath))
                return CreatePlaceholder();

            byte[] bytes = File.ReadAllBytes(fullPath);
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        /// Ảnh placeholder khi sản phẩm chưa có ảnh hoặc file ảnh bị mất
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

        /// Xóa file ảnh cũ khi thay ảnh mới hoặc xóa sản phẩm
        public static void DeleteImageFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) return;
            string fullPath = Path.Combine(ImageFolder, fileName);
            if (File.Exists(fullPath))
            {
                try { File.Delete(fullPath); } catch { /* bỏ qua nếu file đang bị khóa */ }
            }
        }
    }
}