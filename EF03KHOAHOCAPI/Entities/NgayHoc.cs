using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF03KHOAHOCAPI.Entites
{
    public class NgayHoc
    {
        [Key]
        public int NgayhocId { get; set; }
        public string Noidung { get; set; }
        public string Ghichu { get; set; }
        public int KhoaHocId { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
        public NgayHoc() { }
        //public void NhapNgayHoc()
        //{
        //    KhoaHocId = InNhap.InputINT("khoa hoc id ", "nhap sai");
        //    Noidung = InNhap.InputSTR("Nhap noi dung ngay hoc", "Nhap sai gia tri", 2, 50);
        //    Ghichu = InNhap.InputSTR("Them ghi chu cho ngay hoc", "Sai gia tri", 2, 100);
        //}
        //public void NhapNgayHoc(int kh)
        //{
        //    KhoaHocId = kh;
        //    Noidung = InNhap.InputSTR("Nhap noi dung ngay hoc", "Nhap sai gia tri", 2, 50);
        //    Ghichu = InNhap.InputSTR("Them ghi chu cho ngay hoc", "Sai gia tri", 2, 100);
        //}
    }
}
