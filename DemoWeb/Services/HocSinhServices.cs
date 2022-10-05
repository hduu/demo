using DemoWeb.Context;
using DemoWeb.Interface;
using DemoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Services
{
    public class HocSinhServices : IHocSinhServices
    {
        private HocSinhContext dbcontext = new HocSinhContext();

        public HocSinh CapNhapHS(int idhs, HocSinh hs)
        {

            using (var tran = dbcontext.Database.BeginTransaction())
            {
                var check = dbcontext.HocSinhs.FirstOrDefault(e => e.Id == idhs);
                if (check != null)
                {
                    check.Hoten = hs.Hoten;
                    check.Email = hs.Email;
                    check.SDT = hs.SDT;
                    check.NgaySinh = hs.NgaySinh;
                    check.LopId = hs.LopId;
                    dbcontext.HocSinhs.Update(check);
                    dbcontext.SaveChanges();
                    tran.Commit();
                    return hs;
                }
                else return null;
            }
        }

        public void DeleteHocSinh(int id)
        {
            var check = dbcontext.HocSinhs.SingleOrDefault(e => e.Id == id);
            if (check != null)
            {
                using (var transit = dbcontext.Database.BeginTransaction())
                {
                    dbcontext.HocSinhs.Remove(check);
                    dbcontext.SaveChanges();
                    transit.Commit();
                }
            }
            else throw new Exception($"Khong ton tai hoc sinh {id}");
        }

        public IList<HocSinh> GetHocSinh()
        {
            var hsinh = dbcontext.HocSinhs.ToList();
            return hsinh;
        }

        public HocSinh GetHocSinh(int id)
        {
            using (var tran = dbcontext.Database.BeginTransaction())
            {
                var hs = dbcontext.HocSinhs.SingleOrDefault(e => e.Id == id);
                return hs != null ? hs : null;
            }
            
        }
        public HocSinh ThemHocSinh(HocSinh hs)
        {
            using (var tran = dbcontext.Database.BeginTransaction()) { 
            var cheklop = dbcontext.Lops.SingleOrDefault(e => e.Id == hs.LopId);
            var count = dbcontext.Lops.SingleOrDefault(e => e.Id == hs.LopId);
            if (cheklop != null && count.Siso < 40)
            {
                count.Siso++;
                dbcontext.HocSinhs.Add(hs);
                dbcontext.Lops.Update(count);
                dbcontext.SaveChanges();
            }
                tran.Commit();
            return null;
        }
    }
        
    }
}
