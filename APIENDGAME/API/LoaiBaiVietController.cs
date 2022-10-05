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
    public class LoaiBaiVietController : ControllerBase
    {
        private readonly LoaiBaiVietServices lbvServices = new LoaiBaiVietServices();
        // GET: api/<LoaiBaiVietController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = lbvServices.GetLoaiBaiViet();
            return Ok(res);
        }

        // GET api/<LoaiBaiVietController>/5

        // POST api/<LoaiBaiVietController>
        [HttpPost]
        public IActionResult Post([FromBody] LoaiBaiViet value)
        {
            var res = lbvServices.ThemLoaiBV(value);
            return Ok(res);
        }

        // PUT api/<LoaiBaiVietController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] LoaiBaiViet value)
        {
            var res = lbvServices.SuaLoaiBV(value);
            return Ok(res);
        }

        // DELETE api/<LoaiBaiVietController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            lbvServices.XoaLBV(id);
            return Ok();
        }
    }
}
