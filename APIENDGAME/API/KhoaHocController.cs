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
    public class KhoaHocController : ControllerBase
    {
        private readonly KhoaHocService khServices = new KhoaHocService();
        // GET: api/<KhoaHocController>
        [HttpGet]
        public IActionResult GetKhoaHoc()
        {
            var get = khServices.GetKhoaHoc();
            return Ok(get);
        }

        // GET api/<KhoaHocController>/5
        [HttpGet("{id}")]
        public IActionResult GetTenKH(string key)
        {
            var resul = khServices.GetKHSTRING(key);
            return Ok(resul);
        }

        // POST api/<KhoaHocController>
        [HttpPost]
        public IActionResult Post([FromBody] KhoaHoc kh)
        {
            var addkh = khServices.ThemKH(kh);
            return Ok(addkh);
        }

        // PUT api/<KhoaHocController>/5
        [HttpPut]
        public IActionResult Put(KhoaHoc kh)
        {
            var put = khServices.SuaKH(kh);
            return Ok(put);
        }

        // DELETE api/<KhoaHocController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var dele = khServices.XoaKH(id);
            return dele == 1 ? Ok(dele) : NotFound("khong tim thay ma khoa hoc ");
        }
    }
}
