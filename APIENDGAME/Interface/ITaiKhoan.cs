using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface ITaiKhoan
    {
        public IQueryable<TaiKhoan> GetTaiKhoan();
        public TaiKhoan ThemTaiKhoan(TaiKhoan tk);
        public TaiKhoan SuaTaiKhoan(TaiKhoan tk);
        public void XoaTaiKhoan(int key);

    }
}
