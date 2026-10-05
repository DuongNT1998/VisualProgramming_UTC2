using System.Drawing;
using System.Windows.Forms;

namespace QuanLySanPham_EFCore_Chap8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Text = "Quản Lý Sản Phẩm - EF Core Database First";
            Width = 420;
            Height = 260;
            StartPosition = FormStartPosition.CenterScreen;

            var btnDanhMuc = new Button
            {
                Text = "Quản lý Danh mục Sản phẩm",
                Location = new Point(60, 60),
                Size = new Size(280, 40)
            };
            btnDanhMuc.Click += (s, e) => new FormDanhMucSanPham().ShowDialog();

            var btnSanPham = new Button
            {
                Text = "Quản lý Sản phẩm",
                Location = new Point(60, 120),
                Size = new Size(280, 40)
            };
            btnSanPham.Click += (s, e) => new FormSanPham().ShowDialog();

            Controls.Add(btnDanhMuc);
            Controls.Add(btnSanPham);
        }
    }
}