using DemoWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Context
{
    public class HocSinhContext:DbContext 
    {
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DemoWeb;Integrated Security=True");
        }
    }
}
