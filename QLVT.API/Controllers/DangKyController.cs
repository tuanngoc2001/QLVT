using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class DangKyController : ControllerBase
    {
        private readonly IDangKyRepository _context;
        public DangKyController(IDangKyRepository context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> Getall(int page)
        {
            return Ok(await _context.GetAll(page));
        }
        //update
        [HttpPut("{id}")]
        public async Task UpdateDk(DangKyModel DK,Guid id)
        {
            await _context.UpdateDK(DK, id);
        }
        [HttpDelete("{id}")]
        public async Task DeleteDK(Guid id)
        {
            await _context.DeleteDK(id);
        }
        [HttpPost]
        public async Task CreatNew(DangKyModel dk)
        {
            var dk1 = new DangKy()
            {
                IDDK = new Guid(),
                TenNguoiDK = dk.TenNguoiDK,
            };
            await _context.AddDK(dk1);
        }
    }
}
