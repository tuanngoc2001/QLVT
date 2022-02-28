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
        private static int PAGE_SIZE { get; set; } = 2;
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

        public async Task<ICollection<BoPhan>> GetAll(int page)
        {
            //paging
            var paging=_context.boPhans.AsQueryable();
            paging = paging.Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE);
            return await paging.ToListAsync();
        }

        public async Task<ICollection<BoPhan>> GetByID(Guid id)
        {
            return await _context.boPhans.Where(p => p.IDBP == id).ToListAsync();
        }

      

        public async Task UpdateBoPhan(BoPhanModel bp,Guid id)
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
