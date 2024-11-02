using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DTC225180054
{
    internal class DTC225180054Context : DbContext
    {

            // Định nghĩa một tập hợp đại diện cho bảng Products
            public DbSet<Product> Productss { get; set; }

            // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-E2U6K8H\MSSQLSERVER01;Database=NguyenCuong;Trusted_Connection=True;TrustServerCertificate=True");
            }
      
    }
}
