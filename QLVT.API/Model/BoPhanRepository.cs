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

        public async Task AddBoPhan(BoPhan bp)
        {
            await _context.boPhans.AddAsync(bp);
            await _context.SaveChangesAsync();
            
        }

        public async Task DeleteBP(Guid id)
        {
            var result = await _context.boPhans.SingleOrDefaultAsync(p => p.IDBP == id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }  
           
        }

        public async Task<ICollection<BoPhan>> GetAll()
        {
            return await _context.boPhans.ToListAsync();
        }

        public async Task<ICollection<BoPhan>> GetByID(Guid id)
        {
            return await _context.boPhans.Where(p => p.IDBP == id).ToListAsync();
        }

      

        public async Task UpdateBoPhan(BoPhan bp,Guid id)
        {
            var result =await _context.boPhans.SingleOrDefaultAsync(item => item.IDBP == id);
            if(result!=null)
            {
                result.TenBP = bp.TenBP;
                result.TenNDD = bp.TenNDD;
                result.STT = bp.STT;
                result.NgayTao = bp.NgayTao;
                await _context.SaveChangesAsync();
            } 
           

        }

       
    }
}
