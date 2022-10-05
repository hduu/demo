using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
using APIENDGAME.Sevices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIENDGAME.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinhTrangHocController : ControllerBase
    {
        private readonly TinhTrangHocServices ttSV = new TinhTrangHocServices();
        // GET: api/<TinhTrangHocController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = ttSV.GetDT();
            return Ok(list);
        }
        // POST api/<TinhTrangHocController>
        [HttpPost]
        public IActionResult Post([FromBody] TinhTrangHoc tt)
        {
            var res = ttSV.ThemDT(tt);
            return Ok(res);
        }

        // PUT api/<TinhTrangHocController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] TinhTrangHoc tt)
        {
            var res = ttSV.SuaDT(tt);
            return res != null ? Ok(res) : NotFound();
        }

        // DELETE api/<TinhTrangHocController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var res = ttSV.XoaDT(id);
            return res == 0 ? NotFound() : Ok(res);
        }
    }
}
