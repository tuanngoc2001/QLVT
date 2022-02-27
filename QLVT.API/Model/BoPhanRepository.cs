using Microsoft.EntityFrameworkCore;
using QLVT.API.Data;
using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Model
{
    public class BoPhanRepository : IBoPhanRepository
    {
        private readonly MyDBContext _context;
        public BoPhanRepository(MyDBContext context)
        {
            this._context = context;
        }

        public async Task<BoPhan> AddBoPhan(BoPhan bp)
        {
            var bophan =await _context.boPhans.AddAsync(bp);
            await _context.SaveChangesAsync();
            return bophan.Entity;
        }

        public async Task<ICollection<BoPhan>> GetAll()
        {
            return await _context.boPhans.ToListAsync();
        }
    }
}
