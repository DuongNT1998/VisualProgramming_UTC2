using Microsoft.EntityFrameworkCore;
using QuanLySanPham_EFCore_Chap8.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace QuanLySanPham_EFCore_Chap8.Helpers
{
    // Vì QL_SanPhamContext (Database First) yêu cầu DbContextOptions qua constructor,
    // Helper này đóng vai trò nơi duy nhất cấu hình connection string.
    public static class DbContextHelper
    {
        // ĐỔI connection string này cho đúng SQL Server của bạn
        private const string ConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=QL_SanPham;Trusted_Connection=True;TrustServerCertificate=True;";

        public static QL_SanPhamContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<QL_SanPhamContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new QL_SanPhamContext(optionsBuilder.Options);
        }
    }
}
