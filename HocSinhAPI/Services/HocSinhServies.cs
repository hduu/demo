using HocSinhAPI.Context;
using HocSinhAPI.Entities;
using HocSinhAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocSinhAPI.Services
{
    public class HocSinhServies : IHocSinh
    {
        private readonly HocSinhContext dbcontext = new HocSinhContext();
        public HocSinh ThemHocSinh(int lopid, HocSinh hs)
        {
            using(var tran = dbcontext.Database.BeginTransaction())
            {
                var check = dbcontext.Lops.SingleOrDefault(x => x.LopId == lopid);
                if (check == null) throw new Exception($"khong tim thay lop {lopid}");
                else
                {
                    var checksiso = dbcontext.Lops.Count(x => x.LopId == lopid);
                    if (checksiso < 20)
                    {
                        dbcontext.HocSinhs.Add(hs);
                        dbcontext.SaveChanges();
                        tran.Commit();
                    }
                    else throw new Exception("khong them duoc vi si so >= 20");
                }
                
                return hs;
            }
        }
    }
}
