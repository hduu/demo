using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Interface;
using APIENDGAME.Context;

namespace APIENDGAME.Sevices
{
    public class TinhTrangHocServices : ITinhTrangHoc
    {
        private readonly HocVienContext ApiCText = new HocVienContext();
        public IQueryable<TinhTrangHoc> GetDT()
        {
            var tthoc = ApiCText.TinhTrangHocs.OrderBy(e => e.TinhTrangHocID);
            return tthoc;
        }

        public TinhTrangHoc SuaDT(TinhTrangHoc tt)
        {
            using(var tran = ApiCText.Database.BeginTransaction())
            {
                var check = ApiCText.TinhTrangHocs.SingleOrDefault(e => e.TinhTrangHocID == tt.TinhTrangHocID);
                if (check == null) return null;
                check.TenTinhTrang = tt.TenTinhTrang;
                ApiCText.TinhTrangHocs.Update(check);
                ApiCText.SaveChanges();
                tran.Commit();
            }
            return tt;
        }

        public TinhTrangHoc ThemDT(TinhTrangHoc tt)
        {
            using(var tran = ApiCText.Database.BeginTransaction())
            {
                ApiCText.TinhTrangHocs.Add(tt);
                ApiCText.SaveChanges();
                tran.Commit();
            }
            return tt;
        }

        public int XoaDT(int x)
        {
           using(var tran = ApiCText.Database.BeginTransaction())
            {
                var res = ApiCText.TinhTrangHocs.SingleOrDefault(e => e.TinhTrangHocID == x);
                if (res == null) return 0;
                ApiCText.TinhTrangHocs.Remove(res);
                ApiCText.SaveChanges();
                tran.Commit();
                return 1;
            }
        }
    }
}
