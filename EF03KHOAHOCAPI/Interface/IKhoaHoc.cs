using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF03KHOAHOCAPI.Entites;

namespace EF03KHOAHOCAPI.Interface
{
    public interface IKhoaHoc
    {
        public KhoaHoc ThemKhoaHoc(KhoaHoc kh);
    }
}
