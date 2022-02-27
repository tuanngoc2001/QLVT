using Microsoft.EntityFrameworkCore;
using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BoPhan> boPhans { get; set; }
        public DbSet<DangKy> dangKies { get; set; }
        public DbSet<MatHang> matHangs { get; set; }
       
    }
}
