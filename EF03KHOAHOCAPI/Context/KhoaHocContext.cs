using EF03KHOAHOCAPI.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF03KHOAHOCAPI.Context
{
    public class KhoaHocContext: DbContext
    {
        public DbSet<HocVien> HocViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<NgayHoc> NgayHocs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connect = "Data Source =.; Initial Catalog = KhoaHocAPI; Integrated Security = True";
            optionsBuilder.UseSqlServer("Server=DESKTOP-LJ0S7JP;initial catalog =KhoaHocAPI;integrated security=sspi");
        }
    }
}
