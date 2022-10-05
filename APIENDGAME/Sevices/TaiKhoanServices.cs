using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Context;
using APIENDGAME.Interface;

namespace APIENDGAME.Sevices
{
    public class TaiKhoanServices : ITaiKhoan
    {
        private readonly HocVienContext apiContext = new HocVienContext();
        public IQueryable<TaiKhoan> GetTaiKhoan()
        {
            using (var tran = apiContext.Database.BeginTransaction())
            {
                var list = apiContext.TaiKhoans.OrderBy(e => e.TaiKhoanID);
                tran.Commit();
                return list;
            }
        }

        public TaiKhoan SuaTaiKhoan(TaiKhoan tk)
        {
            using(var tran = apiContext.Database.BeginTransaction())
            {
                apiContext.TaiKhoans.Update(tk);
                apiContext.SaveChanges();
                tran.Commit();
                return tk;
            }
        }

        public TaiKhoan ThemTaiKhoan(TaiKhoan tk)
        {
            using(var add = apiContext.Database.BeginTransaction())
            {
                apiContext.TaiKhoans.Add(tk);
                apiContext.SaveChanges();
                add.Commit();
                return tk;
            }
        }

        public void XoaTaiKhoan(int key)
        {
            using(var tran = apiContext.Database.BeginTransaction())
            {
                var check = apiContext.TaiKhoans.FirstOrDefault(e => e.TaiKhoanID == key);
                if (check == null) throw new Exception("khong ton tai");
                apiContext.TaiKhoans.Remove(check);
                apiContext.SaveChanges();
                tran.Commit();
            }
        }
    }
}
