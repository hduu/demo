using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Interface;
using APIENDGAME.Context;
using Microsoft.EntityFrameworkCore;
namespace APIENDGAME.Sevices
{
    public class HocVienServices : IHocVien
    {
        private readonly HocVienContext ApiContext = new HocVienContext();

        public string ChuanHoa(string str)
        {
            string kq;
            string sluu = "";
            kq = str.Trim();
            kq = kq.ToLower();
            while(kq.IndexOf(" ") != -1)
            {
                kq = kq.Remove(kq.IndexOf(" "), 1);
            }
            string[] mang = kq.Split(" ");
            for (int i = 0; i < mang.Length; i++)
            {
                string s1 = mang[i].Substring(0, 1);
                string s2 = mang[i].Substring(1,mang[i].Length-1);
                sluu = s1.ToUpper()+ s2 + " ";
            }
            sluu = sluu.Remove(sluu.LastIndexOf(" "), 1);
            return sluu;
        }

        public IQueryable<HocVien> GetHocVien(string? ten = null, string? emai = null)
        {
            var query = ApiContext.HocViens.AsQueryable();
            if(!string.IsNullOrEmpty(ten))
            {
                query = query.Where(x => x.HoTen.ToLower().Contains(ten.ToLower()));
            }
            if(!string.IsNullOrEmpty(emai))
            {
                query = query.Where(e => e.Email.ToLower().Contains(emai.ToLower()));
            }
            return query;
        }

        public HocVien SuaHocVien(HocVien hv)
        {
            using (var trasit = ApiContext.Database.BeginTransaction())
            {
                hv.HoTen = ChuanHoa(hv.HoTen);
                ApiContext.HocViens.Update(hv);
                ApiContext.SaveChanges();
                trasit.Commit();
            }
            return hv;
        }

        public HocVien ThemHocVien(HocVien hv)
        {
            using(var transit = ApiContext.Database.BeginTransaction())
            {
                var email = ApiContext.HocViens.FirstOrDefault(e => e.Email.ToLower() == (hv.Email.ToLower()));
                var sdt = ApiContext.HocViens.FirstOrDefault(e => e.SoDienThoai.ToLower() == (hv.SoDienThoai.ToLower()));
                if (email != null) { Console.WriteLine("email bi trung"); return null; }
                if (sdt != null) { Console.WriteLine("so dien thoai bi trung"); return null; }
                hv.HoTen = ChuanHoa(hv.HoTen);
                ApiContext.HocViens.Add(hv);
                ApiContext.SaveChanges();
                transit.Commit();
            }
            return hv;
        }

        public bool XoaHocVien(int idhocvien)
        {
            using(var log = ApiContext.Database.BeginTransaction())
            {
                var kiemtra = ApiContext.HocViens.SingleOrDefault(e => e.HocVienID == idhocvien);
                if (kiemtra == null) return false;
                ApiContext.HocViens.Remove(kiemtra);
                ApiContext.SaveChanges();
                log.Commit();
                return true;
            }
        }
    }
}
