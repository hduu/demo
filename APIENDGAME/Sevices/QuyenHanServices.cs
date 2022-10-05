using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Interface;
using APIENDGAME.Context;

namespace APIENDGAME.Sevices
{
    public class QuyenHanServices:IQuyenHan
    {
        private readonly HocVienContext apiContext = new HocVienContext();

        public IQueryable<QuyenHan> GetQuyenHan()
        {
            using(var tran = apiContext.Database.BeginTransaction())
            {
                var listquyenhan = apiContext.QuyenHans;
                return listquyenhan;
            }

        }

        public QuyenHan SuaQuyenHan(QuyenHan qh)
        {
            using(var tran = apiContext.Database.BeginTransaction())
            {
                var check = apiContext.QuyenHans.FirstOrDefault(e => e.QuyenHanID == qh.QuyenHanID);
                if (check == null) return null;
                check.TenQuyenHan = qh.TenQuyenHan;
                apiContext.QuyenHans.Update(check);
                apiContext.SaveChanges();
                tran.Commit();
            }
            return qh;
        }

        public QuyenHan ThemQuyenHan(QuyenHan qh)
        {
            using(var tran = apiContext.Database.BeginTransaction())
            {
                var ck = apiContext.QuyenHans.FirstOrDefault(e => e.QuyenHanID == qh.QuyenHanID);
                if (ck != null) return null;
                apiContext.QuyenHans.Add(qh);
                apiContext.SaveChanges();
                tran.Commit();
            }
            return qh;
        }

        public void XoaQuyenHan(int key)
        {
            using(var tran = apiContext.Database.BeginTransaction())
            {
                var check = apiContext.QuyenHans.SingleOrDefault(e => e.QuyenHanID == key);
                if (check == null)  throw new  Exception("khong co ma id nay");
                else
                {
                    apiContext.QuyenHans.Remove(check);
                    apiContext.SaveChanges();
                    tran.Commit();
                }
            }
        }
    }
}
