using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocSinhAPI.Services;
using HocSinhAPI.Entities;

namespace HocSinhAPI.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        private readonly HocSinhServies hocSinhServies = new HocSinhServies();

        [HttpPost]
        public IActionResult ThemHS(int idlop, HocSinh hs)
        {
            var trans = hocSinhServies.ThemHocSinh(idlop, hs);
            return Ok(trans);
        }
        //[HttpGet]
        //public IActionResult GetHs(int id)
        //{
             
        //}
    }
}
