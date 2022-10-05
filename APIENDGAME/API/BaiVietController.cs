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
    public class BaiVietController : ControllerBase
    {
        private readonly BaiVietServices bvservices = new BaiVietServices();
        // GET: api/<BaiVietController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = bvservices.GetBaiViet();
            return Ok(list);
        }
        // POST api/<BaiVietController>
        [HttpPost]
        public IActionResult Post([FromBody] BaiViet bv)
        {
            var res = bvservices.ThemBaiViet(bv);
            return Ok(res);
        }

        // PUT api/<BaiVietController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] BaiViet bv)
        {
            var res = bvservices.SuaBaiViet(bv);
            return Ok(res);
        }

        // DELETE api/<BaiVietController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bvservices.XoaBaiViet(id);
            return Ok();
        }
    }
}
