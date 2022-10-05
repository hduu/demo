using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHung.Model;
using WebApiHung.Services;

namespace WebApiHung.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : ControllerBase
    {
        //private HoaDonServices hoaDonServices;
        //public HoaDonController()
        //{
        //    hoaDonServices = new HoaDonServices();
        //}
        private HoaDonServices hoaDonServices = new HoaDonServices();
        [HttpGet]
        public IActionResult Get(
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
            //pageSize so bai tren 1 trang -1 lay ra ta cả. = -1 la 1 hien ra tat ca bai
            // pageNumber la mấy trang, trang thứ bao nhiêu =1 mac dịnh là có 1 trang, hien thi ra 1 trang
            var gets =  hoaDonServices.GetHD(key,year,month,prevNgay,nextNgay,prevGia,nextGia,pageSize,pageNumber);
            return Ok(gets);
        }
        [HttpPost]
        public IActionResult ThemHD([FromBody]HoaDon hs) 
        {
            var sk = hoaDonServices.AddHD(hs);
            return Ok(sk);
        }
        [HttpPut]
        public IActionResult SuaHD([FromBody] HoaDon hs)
        {
            var suahd = hoaDonServices.SuaHD(hs);
            return Ok(suahd);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleHD(int i)
        {
            hoaDonServices.XoaHD(i);
            return Ok();
        }
    }
}
