﻿using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult> GetAll1(int page)
        {
            return Ok(await _context.GetAll(page));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult>GetByID1(Guid id)
        {
            return Ok(await _context.GetByID(id));
        }
        [HttpPost]
        public async Task CreateNew(BoPhanModel bp)
        {
            var bophan = new BoPhan()
            {
                IDBP = new Guid(),
                TenBP = bp.TenBP,
                STT = bp.STT,
                TenNDD = bp.TenNDD,
                NgayTao = DateTime.Now,
            };
            await _context.AddBoPhan(bophan);
        }
        [HttpPut("{id}")]
        public async Task UpdateDB(BoPhanModel bp,Guid id)
        {
            await _context.UpdateBoPhan(bp,id);
        }
        [HttpDelete("{id}")]
        public async Task DeleteDB(Guid id)
        {
            await _context.DeleteBP(id);
        }

    }
}
