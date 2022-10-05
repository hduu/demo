//using DemoWeb.Context;
//using DemoWeb.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace DemoWeb.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HocSinhCSController : ControllerBase
//    {
//        protected HocSinhContext dbcontext = new HocSinhContext();
//        // GET api/<HocSinhCSController>/5
//        //[HttpGet()]
//        //public ActionResult Get()
//        //{
//        //    var hslist = dbcontext.HocSinhs.ToList();
//        //    return Ok(hslist);
//        //}
//        [HttpGet("{id}")]
//        public ActionResult Get(int id)
//        {
//            var list = dbcontext.HocSinhs.Find(id);
//            if (list == null) return NotFound("khong tin thay ban ghi");
//            else return Ok(list);
//        }
//        [HttpGet()]
//        public ActionResult Get()  //[FromQuery] string str=null
//        {
//            var check = dbcontext.HocSinhs.Include(e => e.Lop).ToList();
//                //Where(e => e.Hoten.ToLower().Contains(str.ToLower())).ToList();
//            return Ok(check);
//        }
//        // POST api/<HocSinhCSController>
//        [HttpPost]
//        public ActionResult Post([FromBody] HocSinh hocSinh)
//        {
//            dbcontext.HocSinhs.Add(hocSinh);
//            dbcontext.SaveChanges();
//            return CreatedAtAction("Post", hocSinh);
//        }

//        // PUT api/<HocSinhCSController>/5
//        [HttpPut("{id}")]
//        public ActionResult Put(int id, [FromBody] HocSinh  hocSinh)
//        {
//            var finID = dbcontext.HocSinhs.Find(id);
//            if (finID == null) return NotFound($"Khong tim thay hoc sinh {id}");
//            else
//            {
//                finID.Hoten = hocSinh.Hoten;
//                finID.Email = hocSinh.Email;
//                finID.SDT = hocSinh.SDT;
//                finID.NgaySinh = hocSinh.NgaySinh;
//                finID.LopId = hocSinh.LopId;
//                dbcontext.HocSinhs.Update(finID);
//                dbcontext.SaveChanges();
//                return Ok("update thanh cong");
//            }
//        }

//        // DELETE api/<HocSinhCSController>/5
//        [HttpDelete("{id}")]
//        public ActionResult Delete(int id)
//        {
//            var timkiem = dbcontext.HocSinhs.Find(id);
//            if (timkiem == null) return NotFound("khong tim thay ");
//            else
//            {
//                dbcontext.HocSinhs.Remove(timkiem);
//                dbcontext.SaveChanges();
//                return Ok("xoa thanh cong");
//            }
//        }
//    }
//}
