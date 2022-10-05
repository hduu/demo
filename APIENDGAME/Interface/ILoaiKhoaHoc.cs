using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface ILoaiKhoaHoc
    {
        public LoaiKhoaHoc ThemLoaiKH(LoaiKhoaHoc lkh);
        public LoaiKhoaHoc SuaLKH(int id, LoaiKhoaHoc loaikh);
        public int XoaLoaiKH(int key);
    }
}
