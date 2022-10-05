using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class HocVien
    {
        [Key]
        public int HocVienID { get; set; }
        public string HinhAnh { get; set; }
        [MaxLength(50)]
        public string HoTen { get; set; }
        [Column(TypeName ="date")]
        public DateTime NgaySinh { get; set; }
        [MaxLength(11)]
        [Column(TypeName ="varchar")]
        public string SoDienThoai { get; set; }
        [MaxLength(40)]
        //[Index(IsUnique = true)]  
        public string Email { get; set; }
        [MaxLength(50)] 
        public string TinhThanh { get; set; }
        [MaxLength(50)]
        public string QuanHuyen { get; set; }
        [MaxLength(50)]
        public string PhuongXa { get; set; }
        [MaxLength(50)]
        public string SoNha { get; set; }
        public IList<DangKyHoc> DangKyHocs { get; set; }

    }
}
