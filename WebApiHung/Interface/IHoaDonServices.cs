using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHung.Model;

namespace WebApiHung.Interface
{
    public interface IHoaDonServices
    {
        //pageSize so bai tren 1 trang -1 lay ra ta cả
        // pageNumber la mấy trang, trang thứ bao nhiêu 
        public IQueryable<HoaDon> GetHD(
            string word,
            int? year=null,
            int? month=null,
            DateTime? prevNgay=null,
            DateTime? nextNgay = null,
            int? prevGia=null,
            int? nextGia=null,
            int pageSize = -1,
            int pageNumber = 1
            );
        public HoaDon AddHD(HoaDon hd);
        public HoaDon SuaHD(HoaDon hd);
        public void XoaHD(int id);
        public string MaGiaoDich();
    }
}
