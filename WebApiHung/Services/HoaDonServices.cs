using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHung.Interface;
using WebApiHung.Model;
using WebApiHung.Context;
using Microsoft.EntityFrameworkCore;

namespace WebApiHung.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        protected ApiContext dbcontext;
        public HoaDonServices () { dbcontext = new ApiContext(); }
        public HoaDon AddHD(HoaDon hd)
        {
            using (var transit = dbcontext.Database.BeginTransaction())
            {
                #region comment
                //var ss = dbcontext.HoaDons.Local.Count();
                //var db = dbcontext.Entry(HoaDon);
                //var db = dbcontext.Entry(HoaDon).Reference(c => c.KhachHang).Load;
                #endregion
                hd.ThoiGianTao = DateTime.Now;
                hd.MaGiaoDich = MaGiaoDich();
                hd.ThoiGianCapNhap = DateTime.Now;
                var lstcthoadon = hd.ChiTietHoaDons;
                hd.ChiTietHoaDons = null;
                dbcontext.HoaDons.Add(hd);
                dbcontext.SaveChanges();
                foreach (var ctiet in lstcthoadon)
                {
                    if (dbcontext.SanPhams.Any(e => e.Sanphamid == ctiet.SanPhamid))
                    {
                        ctiet.HoaDonid = hd.HoanDonid;
                        var sp = dbcontext.SanPhams.FirstOrDefault(e => e.Sanphamid == ctiet.SanPhamid);
                        ctiet.ThanhTien = ctiet.SoLuong * sp.GiaThanh;
                        dbcontext.ChiTietHoaDons.Add(ctiet);
                        dbcontext.SaveChanges();
                    }
                    else throw new Exception($"San pham khong ton tai {ctiet.SanPhamid}");
                }
                hd.TongTien = lstcthoadon.Sum(e => e.ThanhTien);
                dbcontext.SaveChanges();
                transit.Commit();
                return hd;
            }
        }
        public string MaGiaoDich()
        {
            var taoma = DateTime.Now.ToString("yyyyMMdd") + "_";
            var sogiaodichhientai = dbcontext.HoaDons.Count(x => x.ThoiGianTao.Date == DateTime.Now.Date);
            if (sogiaodichhientai < 0) return taoma + "001";
            else
            {
                 return taoma = taoma +"0"+ (sogiaodichhientai + 1).ToString();
            }
        }
        public HoaDon SuaHD(HoaDon hd)
        {
            using (var tran = dbcontext.Database.BeginTransaction())
            {
                if (hd.ChiTietHoaDons == null || hd.ChiTietHoaDons.Count == 0)
                {
                    var listhientai = dbcontext.ChiTietHoaDons.Where(x => x.HoaDonid == hd.HoanDonid);
                    dbcontext.RemoveRange(listhientai);
                    dbcontext.SaveChanges();
                }
                else
                {
                    var list = dbcontext.ChiTietHoaDons.Where(x => x.HoaDonid == hd.HoanDonid).ToList();
                    var newlist = new List<ChiTietHoaDon>();
                    foreach (var item in list)
                    {
                        if (hd.ChiTietHoaDons == null || hd.ChiTietHoaDons.Count() == 0)
                        {
                            var ctnew = dbcontext.ChiTietHoaDons.Where(e => e.HoaDonid == item.HoaDonid);
                            dbcontext.RemoveRange(ctnew); // xoa het cac bản ghi
                            dbcontext.SaveChanges();
                        }
                        else
                        {
                            var ctnew = dbcontext.ChiTietHoaDons.Where(e => e.HoaDonid == item.HoaDonid).ToList();
                            var listnew = new List<ChiTietHoaDon>();
                            foreach (var e in ctnew)
                            {
                                if (!hd.ChiTietHoaDons.Any(i => i.chietiethoadonid == e.chietiethoadonid))
                                {
                                    listnew.Add(e);
                                }
                                else
                                {
                                    var ctlistnew = hd.ChiTietHoaDons.FirstOrDefault(x => x.chietiethoadonid == e.chietiethoadonid);
                                    e.SanPhamid = ctlistnew.SanPhamid;
                                    e.SoLuong = ctlistnew.SoLuong;
                                    e.DonViTinh = ctlistnew.DonViTinh;
                                    var spnew = dbcontext.SanPhams.FirstOrDefault(y => y.Sanphamid == ctlistnew.SanPhamid);
                                    e.ThanhTien = spnew.GiaThanh * ctlistnew.SoLuong;
                                    dbcontext.Update(e);
                                    dbcontext.SaveChanges();
                                }
                            }
                            dbcontext.RemoveRange(listnew);
                            dbcontext.SaveChanges();
                            foreach (var cti in hd.ChiTietHoaDons)
                            {
                                if(!ctnew.Any(e=>e.chietiethoadonid == cti.chietiethoadonid))
                                {
                                    cti.HoaDonid = hd.HoanDonid;
                                    var sp = dbcontext.SanPhams.FirstOrDefault(i => i.Sanphamid == cti.SanPhamid);
                                    cti.ThanhTien = sp.GiaThanh * cti.SoLuong;
                                    dbcontext.Add(cti);
                                    dbcontext.SaveChanges();
                                }    
                            }
                        }
                        var tongtien = dbcontext.ChiTietHoaDons.Where(x => x.HoaDonid == hd.HoanDonid).Sum(z => z.ThanhTien);
                        hd.TongTien = tongtien;
                        hd.ThoiGianCapNhap = DateTime.Now;
                        hd.ChiTietHoaDons = null;
                        dbcontext.Update(hd);
                        dbcontext.SaveChanges();
                        tran.Commit();
                    }
                }
            }
            return hd;
        }
        public void XoaHD(int id)
        {
            if (dbcontext.HoaDons.Any(x => x.HoanDonid == id))
            {
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    var listchitiet = dbcontext.ChiTietHoaDons.Where(e => e.HoaDonid == id);
                    dbcontext.RemoveRange(listchitiet);
                    var hoadons = dbcontext.HoaDons.Find(id);
                    dbcontext.Remove(hoadons);
                    dbcontext.SaveChanges();
                    tran.Commit();
                }
            }
            else throw new Exception($"Hoa don khong ton tai {id}");
        }
        public IQueryable<HoaDon> GetHD(
            string key,
            int? year,
            int? month = null,
            DateTime? prevNgay = null,
            DateTime? nextNgay = null,
            int? prevGia = null,
            int? nextGia = null,
            int pageSize = -1,
            int pageNumber = 1
            )
        {
            //pageSize so bai tren 1 trang -1 lay ra ta cả
            // pageNumber la mấy trang, trang thứ bao nhiêu 
            var listhd = dbcontext.HoaDons.Include(x=>x.ChiTietHoaDons)
                .OrderByDescending(x => x.ThoiGianTao)
               .AsQueryable();
            if (pageSize > 0)
            {
                listhd = listhd.Skip(pageSize * (pageNumber - 1)).Take(pageSize).AsQueryable();
            }
            if (!string.IsNullOrEmpty(key))
            {
                listhd = listhd.Where(i => i.TenHoaDon.ToLower().Contains(key.ToLower())
                || i.MaGiaoDich.ToLower().Contains( key.ToLower())
                );
            }
            if (year.HasValue)
            {
                listhd = listhd.Where(i => i.ThoiGianTao.Year == year);
            }
            if (month.HasValue)
            {
                listhd = listhd.Where(i => i.ThoiGianTao.Month == month);
            }
            if (prevNgay.HasValue)
            {
                listhd = listhd.Where(i => i.ThoiGianTao.Date >= prevNgay);
            }
            if (nextNgay.HasValue)
            {
                listhd = listhd.Where(i => i.ThoiGianTao.Date <= nextNgay);
            }
            if (prevGia.HasValue)
            {
                listhd = listhd.Where(i => i.TongTien >= prevGia);
            }
            if(nextGia.HasValue)
            {
                listhd = listhd.Where(i => i.TongTien <= nextGia);
            }    
            return listhd;
        }
    }
}
