using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF03KHOAHOCAPI.Entites
{
    public class KhoaHoc
    {
        [Key]
        public int KhoaHocId { get; set; }
        [MaxLength(10)]
        public string TenKH { get; set; }
        public string Mota { get; set; }
        public int Hocphi { get; set; }
        public DateTime Ngaybatdau { get; set; }
        public DateTime Ngaykethuc { get; set; }
        public  IList<NgayHoc> NgayHocs { get; set; }
        public IList<HocVien> HocViens { get; set; }
        public KhoaHoc() { }
        //public void NhapKH()
        //{
        //    TenKH = InNhap.InputSTR("Nhap ten khoa hoc", "Nhap sai gia tri", 2, 10);
        //    Mota = InNhap.InputSTR("Nhap mo ta khoa hoc", "Nhap sai gia tri", 2, 50);
        //    Hocphi = InNhap.InputINT("Nhap hoc phi khoa hoc", "Nhap sai gia tri");
        //    Ngaybatdau = InNhap.InputDT("Nhap ngay bat dau khoa hoc", "Nhap sai gia tri");
        //    Ngaykethuc = InNhap.InputDT("Nhap ngay ket thuc khoa hoc", "Nhap sai gia tri");
        //}
    }
}
