using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Interface;
using APIENDGAME.Entities;
using APIENDGAME.Context;

namespace APIENDGAME.Sevices
{
    public class KhoaHocService : IKhoaHoc
    {
        private readonly HocVienContext AdbContext = new HocVienContext();
        public IQueryable<KhoaHoc> GetKhoaHoc()
        {
            var query = AdbContext.KhoaHocs.OrderBy(x => x.KhoaHocID);
            return query;
        }
        public IQueryable<KhoaHoc> GetKHSTRING(string tenkh)
        {
            var query = AdbContext.KhoaHocs.Where(e => e.TenKhoaHoc.ToLower().Contains(tenkh.ToLower()));
            return query;
        }

        public KhoaHoc SuaKH(KhoaHoc kh)
        {
            using(var trans = AdbContext.Database.BeginTransaction())
            {
                var oks = AdbContext.LoaiKhoaHocs.FirstOrDefault(e => e.LoaiKhoaHocID == kh.LoaiKhoaHocID);
                if (oks != null)
                {
                    AdbContext.KhoaHocs.Update(kh);
                    AdbContext.SaveChanges();
                    trans.Commit();
                }
                else return null;
            }
            return kh;
        }

        public KhoaHoc ThemKH(KhoaHoc kh)
        {
            using (var tran = AdbContext.Database.BeginTransaction())
            {
                var ckLoaikh = AdbContext.LoaiKhoaHocs.FirstOrDefault(e => e.LoaiKhoaHocID == kh.LoaiKhoaHocID);
                if (ckLoaikh != null)
                {
                    AdbContext.KhoaHocs.Add(kh);
                    AdbContext.SaveChanges();
                    tran.Commit();
                }
                else throw new Exception("khoa hoc them vao khong thuoc loai nao");
            }
            return kh;
        }

        public int XoaKH(int id)
        {
            using(var transit = AdbContext.Database.BeginTransaction())
            {
                var xoa = AdbContext.KhoaHocs.SingleOrDefault(e => e.KhoaHocID == id);
                if (xoa == null) return 0;
                else
                {
                    AdbContext.KhoaHocs.Remove(xoa);
                    AdbContext.SaveChanges();
                    transit.Commit();
                }
                return 1;
            }
        }
    }
}
