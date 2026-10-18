using AppDeployment_Chap11.Helpers;
using AppDeployment_Chap11.Models;
using Microsoft.EntityFrameworkCore;


namespace AppDeployment_Chap11.Helpers
{
  
    public static class DbContextHelper
    {
        public static QL_SanPhamContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<QL_SanPhamContext>();
            optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());
            return new QL_SanPhamContext(optionsBuilder.Options);
        }
    }
}
