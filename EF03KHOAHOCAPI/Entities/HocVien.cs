using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF03KHOAHOCAPI.Entites
{
    public class HocVien
    {
        [Key]
        public int HocvienId { get; set; }
        [MinLength(2)]
        [MaxLength(20)]
        public string Hoten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Quequan { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public int KhoaHocId { get; set; }
        public KhoaHoc KhoaHocs { get; set; }
        public HocVien() { }
        //public void NhapHocVien()
        //{
        //    Hoten = InNhap.InputSTR("Nhap ho ten hoc vien", "Nhap sai truong", 2, 20);
        //    Ngaysinh = InNhap.InputDT("Nhap ngay sinh hoc vien", "Nhap sai gia tri");
        //    Quequan = InNhap.InputSTR("Nhap que quan hoc vien", "Nhap sai gia tri", 2, 50);
        //    Diachi = InNhap.InputSTR("Nhap dia chi hoc vien", "Nhap sai gia tri", 2, 50);
        //    Dienthoai = InNhap.InputSTR("Nhap dien thoai hoc vien 10-11 so", "Nhap sai gia tri", 10, 11);
        //}
    }
}
