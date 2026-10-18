using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace AppDeployment_Chap11.Helpers
{
    public static class Strings
    {
        private static readonly Dictionary<string, Dictionary<string, string>> _map = new()
        {
            ["vi-VN"] = new()
            {
                ["AppTitle"] = "Quản lý Sản phẩm - Demo Chương 9",
                ["NgonNgu"] = "Ngôn ngữ:",
                ["PhienBan"] = "Phiên bản:",
                ["Them"] = "Thêm",
                ["Sua"] = "Sửa",
                ["Xoa"] = "Xóa",
                ["LamMoi"] = "Làm mới",
                ["TimKiem"] = "Tìm kiếm:",
                ["Tim"] = "Tìm",
                ["QuanLyDanhMuc"] = "Quản lý Danh mục Sản phẩm",
                ["QuanLySanPham"] = "Quản lý Sản phẩm",
                ["GayLoi"] = "Thử gây lỗi (demo 9.3)",
                ["MoLog"] = "Mở thư mục log (demo 9.3)",
                ["MaSP"] = "Mã SP:",
                ["TenSP"] = "Tên SP:",
                ["SoLuong"] = "Số lượng:",
                ["Dvt"] = "ĐVT:",
                ["DonGia"] = "Đơn giá:",
                ["DanhMuc"] = "Danh mục:",
                ["ChonAnh"] = "Chọn ảnh...",
                ["TyGia"] = "Quy đổi tỷ giá",
                ["ColMa"] = "Mã SP",
                ["ColAnh"] = "Ảnh",
                ["ColTen"] = "Tên sản phẩm",
                ["ColSL"] = "SL",
                ["ColDvt"] = "ĐVT",
                ["ColGia"] = "Đơn giá",
                ["ColDanhMuc"] = "Danh mục",
                ["MaDM"] = "Mã DM:",
                ["TenDM"] = "Tên danh mục:",
                ["NgayTao"] = "Ngày tạo:",
                ["CapNhat"] = "Cập nhật:",
                ["ColMaDM"] = "Mã DM",
                ["ColTenDM"] = "Tên danh mục",
                ["ColNgayTao"] = "Ngày tạo",
                ["ColCapNhat"] = "Cập nhật",
                ["ThemThanhCong"] = "Thêm sản phẩm thành công!",
                ["ThieuTenSP"] = "Vui lòng nhập tên sản phẩm!",
                ["XacNhanXoa"] = "Bạn có chắc muốn xóa sản phẩm này?",
                ["LoiChung"] = "Đã xảy ra lỗi. Chi tiết đã được ghi log.",
                ["LoiMang"] = "Không thể kết nối tới dịch vụ, vui lòng kiểm tra mạng."
            },
            ["en-US"] = new()
            {
                ["AppTitle"] = "Product Management - Chapter 9 Demo",
                ["NgonNgu"] = "Language:",
                ["PhienBan"] = "Version:",
                ["Them"] = "Add",
                ["Sua"] = "Edit",
                ["Xoa"] = "Delete",
                ["LamMoi"] = "Reset",
                ["TimKiem"] = "Search:",
                ["Tim"] = "Find",
                ["QuanLyDanhMuc"] = "Manage Product Categories",
                ["QuanLySanPham"] = "Manage Products",
                ["GayLoi"] = "Trigger an error (demo 9.3)",
                ["MoLog"] = "Open log folder (demo 9.3)",
                ["MaSP"] = "ID:",
                ["TenSP"] = "Name:",
                ["SoLuong"] = "Quantity:",
                ["Dvt"] = "Unit:",
                ["DonGia"] = "Price:",
                ["DanhMuc"] = "Category:",
                ["ChonAnh"] = "Choose image...",
                ["TyGia"] = "Convert currency",
                ["ColMa"] = "ID",
                ["ColAnh"] = "Image",
                ["ColTen"] = "Product name",
                ["ColSL"] = "Qty",
                ["ColDvt"] = "Unit",
                ["ColGia"] = "Price",
                ["ColDanhMuc"] = "Category",
                ["MaDM"] = "Category ID:",
                ["TenDM"] = "Category name:",
                ["NgayTao"] = "Created:",
                ["CapNhat"] = "Updated:",
                ["ColMaDM"] = "Category ID",
                ["ColTenDM"] = "Category name",
                ["ColNgayTao"] = "Created",
                ["ColCapNhat"] = "Updated",
                ["ThemThanhCong"] = "Product added successfully!",
                ["ThieuTenSP"] = "Please enter the product name!",
                ["XacNhanXoa"] = "Are you sure you want to delete this product?",
                ["LoiChung"] = "An error occurred. Details have been logged.",
                ["LoiMang"] = "Cannot reach the service, please check your network."
            }
        };

        public static string CurrentCulture
        {
            get
            {
                string name = Thread.CurrentThread.CurrentUICulture.Name;
                return _map.ContainsKey(name) ? name : "vi-VN";
            }
        }

        public static string Get(string key)
        {
            return _map[CurrentCulture].TryGetValue(key, out var val) ? val : key;
        }

        public static void SetCulture(string cultureCode)
        {
            var ci = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentUICulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;
        }
    }
}