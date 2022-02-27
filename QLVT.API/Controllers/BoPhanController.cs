using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLVT.API.Data;
using QLVT.API.Model;
using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoPhanController : ControllerBase
    {
        private readonly IBoPhanRepository _context;
        public BoPhanController(IBoPhanRepository context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll1()
        {
            return Ok( await _context.GetAll());
        }
        [HttpPost]
        public async Task<ActionResult>AddBoPhan(BoPhan bp)
        {
            return Ok(await _context.AddBoPhan(bp));
        }
    }
}
