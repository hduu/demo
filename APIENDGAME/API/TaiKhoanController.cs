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
    public class TaiKhoanController : ControllerBase
    {
        private readonly TaiKhoanServices addcontroller = new TaiKhoanServices();
        // GET: api/<TaiKhoanController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = addcontroller.GetTaiKhoan();
            return Ok(res);
        }

        // POST api/<TaiKhoanController>
        [HttpPost]
        public IActionResult Post([FromBody] TaiKhoan tk)
        {
            var res = addcontroller.ThemTaiKhoan(tk);
            return Ok(res);
        }

        // PUT api/<TaiKhoanController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TaiKhoan tk)
        {
            //if()
            var res = addcontroller.SuaTaiKhoan(tk);
            return Ok(res);
        }

        // DELETE api/<TaiKhoanController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            addcontroller.XoaTaiKhoan(id);
            return Ok();
        }
    }
}
