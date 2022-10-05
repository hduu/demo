using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Interface;
using APIENDGAME.Context;

namespace APIENDGAME.Sevices
{
    public class ChuDeServices : IChuDe
    {
        private readonly HocVienContext hvcontext = new HocVienContext();
        public IQueryable<ChuDe> GetChuDe()
        {
            var res = hvcontext.ChuDes.OrderBy(e => e.ChuDeID);
            return res;
        }

        public ChuDe SuaChuDe(ChuDe cd)
        {
            using(var tramit = hvcontext.Database.BeginTransaction())
            {
                var chk = hvcontext.ChuDes.FirstOrDefault(e => e.ChuDeID == cd.ChuDeID);
                if (chk == null) throw new Exception("khong co chu de nay");
                chk.TenChuDe = cd.TenChuDe;
                chk.NoiDung = cd.NoiDung;
                chk.LoaiBaiVietID = cd.LoaiBaiVietID;
                hvcontext.ChuDes.Update(chk);
                hvcontext.SaveChanges();
                tramit.Commit();
                return cd;
            }
        }

        public ChuDe ThemChuDe(ChuDe cd)
        {
            using(var tranmit = hvcontext.Database.BeginTransaction())
            {
                hvcontext.ChuDes.Add(cd);
                hvcontext.SaveChanges();
                tranmit.Commit();
                return cd;
            }
        }

        public void XoaChuDe(int key)
        {
            using(var tramit = hvcontext.Database.BeginTransaction())
            {
                var ck = hvcontext.ChuDes.FirstOrDefault(e => e.ChuDeID == key);
                if (ck == null) throw new Exception("khong ton tai chu de nay");
                hvcontext.ChuDes.Remove(ck);
                hvcontext.SaveChanges();
                tramit.Commit();
            }
        }
    }
}
