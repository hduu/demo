using DemoWeb.Models;
using DemoWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        private HocSinhServices hocsinhServices = new HocSinhServices();
        // GET: api/<HocSinhController>
        [HttpGet]
        public IActionResult Get()
        {
            var geths = hocsinhServices.GetHocSinh();
            return Ok(geths);
        }
        // GET api/<HocSinhController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res = hocsinhServices.GetHocSinh(id);
            if (res!=null) return Ok(res);
            else return NotFound("Khong ton tai");
        }
        // POST api/<HocSinhController>
        [HttpPost]
        public IActionResult Post([FromBody] HocSinh hs)
        {
            var res = hocsinhServices.ThemHocSinh(hs);
            if (res != null) return Ok(res);
            else return NotFound("Them khong thanh cong");
        }
        // PUT api/<HocSinhController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] HocSinh hsinh)
        {
            var capnhat = hocsinhServices.CapNhapHS(id, hsinh);
            return Ok(capnhat);
        }
        // DELETE api/<HocSinhController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            hocsinhServices.DeleteHocSinh(id);
            return Ok();
        }
    }
}
