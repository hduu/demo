using EF03KHOAHOCAPI.Context;
using EF03KHOAHOCAPI.Entites;
using EF03KHOAHOCAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF03KHOAHOCAPI.Services
{
    public class KhoaHocServices : IKhoaHoc
    {
        private readonly KhoaHocContext dbcontext;
        public KhoaHoc ThemKhoaHoc(KhoaHoc kh)
        {
            using(var tran = dbcontext.Database.BeginTransaction())
            {
                tran.Commit();
                return kh;
            }
        }
    }
}