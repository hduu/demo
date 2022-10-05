using DemoWeb.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWeb.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        private HocSinhContext context = new HocSinhContext(); 
        //public HocSinhController () { context = new HocSinhContext(); }
        // GET: api/<HocSinhController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public ActionResult Get([FromBody] string st)
        {
            return Ok(st); 
        }

        // GET api/<HocSinhController>/5
        [HttpGet("{id}")]
        public string GetOne([FromQuery]string id)
        {
            return id;
        }

        // POST api/<HocSinhController>
        [HttpPost]
        public ActionResult Post([FromQuery] HocSinh hs)
        {
            return CreatedAtAction("Post", hs);
        }

        // PUT api/<HocSinhController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HocSinhController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
