using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Interface;
using APIENDGAME.Context;

namespace APIENDGAME.Sevices
{
    public class LoaiKhoaHocService : ILoaiKhoaHoc
    {
        private readonly HocVienContext Apcontext = new HocVienContext();

        public LoaiKhoaHoc SuaLKH(LoaiKhoaHoc loaikh)
        {
            using(var tran = Apcontext.Database.BeginTransaction())
            {
                var check = Apcontext.LoaiKhoaHocs.SingleOrDefault(e => e.LoaiKhoaHocID == loaikh.LoaiKhoaHocID);
                if (check == null) return null;
                else
                {
                    check.TenLoai = loaikh.TenLoai;
                    Apcontext.LoaiKhoaHocs.Update(check);
                    Apcontext.SaveChanges();
                    tran.Commit();
                }
            }
            return loaikh;
        }

        public LoaiKhoaHoc SuaLKH(int id, LoaiKhoaHoc loaikh)
        {
            throw new NotImplementedException();
        }

        public LoaiKhoaHoc ThemLoaiKH(LoaiKhoaHoc lkh)
        {
            using (var tran = Apcontext.Database.BeginTransaction())
            {
                Apcontext.LoaiKhoaHocs.Add(lkh);
                Apcontext.SaveChanges();
                tran.Commit();
            }
            return lkh;
        }

        public int XoaLoaiKH(int key)
        {
            using(var transit = Apcontext.Database.BeginTransaction())
            {
                var check = Apcontext.LoaiKhoaHocs.FirstOrDefault(e => e.LoaiKhoaHocID == key);
                if(check !=null)
                {
                    Apcontext.LoaiKhoaHocs.Remove(check);
                    Apcontext.SaveChanges();
                    transit.Commit();
                    return 1;
                }
                return 0;
            }
        }

    }
}
