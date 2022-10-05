using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocSinhAPI.Entities;

namespace HocSinhAPI.Context
{
    public class HocSinhContext: DbContext 
    {
        public DbSet<Lop> Lops { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=DESKTOP-LJ0S7JP;Database=HocSinhAPI;integrated security=sspi");
        }
    }
}
