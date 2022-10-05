using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Interface;
using APIENDGAME.Context;
using APIENDGAME.Entities;

namespace APIENDGAME.Sevices
{
    public class BaiVietServices : IBaiViet
    {
        private readonly HocVienContext hvContext = new HocVienContext();
        public IQueryable<BaiViet> GetBaiViet()
        {
            var list = hvContext.BaiViets.OrderBy(e => e.BaiVietID);
            return list;
        }

        public BaiViet SuaBaiViet(BaiViet bv)
        {
            using(var tran = hvContext.Database.BeginTransaction())
            {
                var chk = hvContext.BaiViets.FirstOrDefault(e => e.BaiVietID == bv.BaiVietID);
                if (chk == null) throw new Exception("khong co bai viet nay");
                chk.TenBaiViet = bv.TenBaiViet;
                chk.ThoiGianTao = DateTime.Now;
                chk.TacGia = bv.TacGia;
                chk.NoiDung = bv.NoiDung;
                chk.NoiDungNgan = bv.NoiDungNgan;
                chk.HinhAnh = bv.HinhAnh;
                chk.ChuDeID = bv.ChuDeID;
                chk.TaiKhoanID = bv.TaiKhoanID;
                hvContext.BaiViets.Update(chk);
                hvContext.SaveChanges();
                tran.Commit();
                return bv;
            }
        }

        public BaiViet ThemBaiViet(BaiViet bv)
        {
            using(var tranmit = hvContext.Database.BeginTransaction())
            {
                bv.ThoiGianTao = DateTime.Now;
                hvContext.BaiViets.Add(bv);
                hvContext.SaveChanges();
                tranmit.Commit();
                return bv;
            }
        }

        public void XoaBaiViet(int key)
        {
            using(var tranmit = hvContext.Database.BeginTransaction())
            {
                var chk = hvContext.BaiViets.FirstOrDefault(e => e.BaiVietID == key);
                if (chk == null) throw new Exception("khong ton tai bai viet nay");
                hvContext.BaiViets.Remove(chk);
                hvContext.SaveChanges();
                tranmit.Commit();
            }
        }
    }
}
