using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Sevices;
using APIENDGAME.Context;
using APIENDGAME.Interface;
namespace APIENDGAME.Sevices
{
    public class LoaiBaiVietServices : ILoaiBaiViet
    {
        private readonly HocVienContext lbvcontext = new HocVienContext();
        public IQueryable<LoaiBaiViet> GetLoaiBaiViet()
        {
            var list = lbvcontext.LoaiBaiViets.OrderBy(e => e.LoaiBaiVietID);
            return list;
        }

        public LoaiBaiViet SuaLoaiBV(LoaiBaiViet lbv)
        {
            using(var tramit = lbvcontext.Database.BeginTransaction())
            {
                var check = lbvcontext.LoaiBaiViets.SingleOrDefault(e => e.LoaiBaiVietID == lbv.LoaiBaiVietID);
                if (check == null) throw new Exception("khong co bai viet nay");
                check.TenLoai = lbv.TenLoai;
                lbvcontext.LoaiBaiViets.Update(check);
                lbvcontext.SaveChanges();
                tramit.Commit();
                return lbv;
            }
        }

        public LoaiBaiViet ThemLoaiBV(LoaiBaiViet lbv)
        {
            using(var tramit = lbvcontext.Database.BeginTransaction())
            {
                lbvcontext.LoaiBaiViets.Add(lbv);
                lbvcontext.SaveChanges();
                tramit.Commit();
                return lbv;
            }
        }

        public void XoaLBV(int key)
        {
            using(var tranmit = lbvcontext.Database.BeginTransaction())
            {
                var chek = lbvcontext.LoaiBaiViets.FirstOrDefault(e => e.LoaiBaiVietID == key);
                if (chek == null) throw new Exception("khong ton tai loai bai viet nay");
                lbvcontext.LoaiBaiViets.Remove(chek);
                lbvcontext.SaveChanges();
                tranmit.Commit();
            }
        }
    }
}
