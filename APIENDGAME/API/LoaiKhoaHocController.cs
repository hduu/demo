using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Sevices;
using APIENDGAME.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIENDGAME.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiKhoaHocController : ControllerBase
    {
        private readonly LoaiKhoaHocService loaiKHService = new LoaiKhoaHocService();
        // GET: api/<LoaiKhoaHocController>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<LoaiKhoaHocController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<LoaiKhoaHocController>
        [HttpPost]
        public IActionResult Post([FromBody] LoaiKhoaHoc loaikh)
        {
            var oks = loaiKHService.ThemLoaiKH(loaikh);
            return Ok(oks);
        }

        // PUT api/<LoaiKhoaHocController>/5
        [HttpPut]
        public IActionResult Put([FromBody] LoaiKhoaHoc loaikh)
        {
            var ck = loaiKHService.SuaLKH(loaikh);
            if (ck == null) return NotFound("khong tim thay ");
            return Ok(ck);
        }

        // DELETE api/<LoaiKhoaHocController>/5
        [HttpDelete]
        public IActionResult Delete([FromBody]int id)
        {
             var oks = loaiKHService.XoaLoaiKH(id);
            return oks ==1 ? Ok(oks) : NotFound("khong ton tai");
        }
    }
}
