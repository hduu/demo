using APIENDGAME.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Context
{
    public class HocVienContext:DbContext 
    {
        public DbSet<BaiViet> BaiViets { get; set; }
        public DbSet<ChuDe> ChuDes { get; set; }
        public DbSet<DangKyHoc> DangKyHocs { get; set; }
        public DbSet<HocVien> HocViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<LoaiBaiViet> LoaiBaiViets { get; set; }
        public DbSet<LoaiKhoaHoc>   LoaiKhoaHocs { get; set; }
        public DbSet<QuyenHan> QuyenHans { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<TinhTrangHoc> TinhTrangHocs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LJ0S7JP;Initial Catalog=APIHOCVIEN;Integrated Security=True");
          
        }
    }
}
