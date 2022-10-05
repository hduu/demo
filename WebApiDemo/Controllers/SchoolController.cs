using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Entities;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        [HttpGet]
        public string[] GetHS()
        {
            var list = new string[]
            {
                "chuoi 1","chuoi 2","chuoi 3"
            };
            return list;
        }
        [HttpGet("id")]
        public ActionResult GetHS(string id)   
        {
            return Ok(id);
        }
        [HttpPost]
        public ActionResult TaoHS([FromBody] HocSinh hsinh )
        {
            return CreatedAtAction("TaoHS", hsinh);
        }
        [HttpPut]
        public void SuaHS() { }
        [HttpDelete]
        public void DeleteHS() { }
    }
}
