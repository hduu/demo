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
    public class ChuDeController : ControllerBase
    {
        private readonly ChuDeServices cdservices = new ChuDeServices();
        // GET: api/<ChuDeController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = cdservices.GetChuDe();
            return Ok(res);
        }
        // POST api/<ChuDeController>
        [HttpPost]
        public IActionResult Post([FromBody] ChuDe cd)
        {
            var res = cdservices.ThemChuDe(cd);
            return Ok(res);
        }

        // PUT api/<ChuDeController>/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] ChuDe cd)
        {
            var res = cdservices.SuaChuDe(cd);
            return Ok(res);
        }

        // DELETE api/<ChuDeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            cdservices.XoaChuDe(id);
            return Ok();
        }
    }
}
