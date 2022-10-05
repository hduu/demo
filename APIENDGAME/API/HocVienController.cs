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
    public class HocVienController : ControllerBase
    {
        private readonly HocVienServices hvservices = new HocVienServices();
        // GET: api/<HocVienController>
        [HttpGet]
        public IActionResult Get(string ten=null,string emai=null)
        {
            var res = hvservices.GetHocVien(ten,emai);
            return Ok(res);
        }

        // GET api/<HocVienController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<HocVienController>
        [HttpPost]
        public IActionResult Post([FromBody] HocVien hv)
        {
            var res = hvservices.ThemHocVien(hv);
            return Ok(res);
        }

        // PUT api/<HocVienController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] HocVien hv)
        {
            var res = hvservices.SuaHocVien(hv);
            return Ok(res);
        }

        // DELETE api/<HocVienController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var res = hvservices.XoaHocVien(id);
            return res == true ? Ok("Xoa thanh cong") : NotFound("Khong xoa thanh cong");
        }
    }
}
