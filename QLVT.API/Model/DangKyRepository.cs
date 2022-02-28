using Microsoft.EntityFrameworkCore;
using QLVT.API.Data;
using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Model
{
    public class DangKyRepository : IDangKyRepository
    {
        private readonly MyDBContext _context;
        private static int PAGE_SIZE = 2;
        public DangKyRepository(MyDBContext context)
        {
            _context = context;
        }

        

        public async Task AddDK(DangKy bp)
        {
            await _context.AddAsync(bp);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDK(Guid id)
        {
            var result = _context.dangKies.SingleOrDefault(p => p.IDDK == id);
            if (result != null)
                _context.Remove(result);
            await _context.SaveChangesAsync();
        }

       

        public async Task<ICollection<DangKy>> GetAll(int page)
        {
            var paging = _context.dangKies.AsQueryable();
            paging = paging.Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE);
            return await paging.ToListAsync();
        }

        public async Task<ICollection<DangKy>> GetByID(Guid id)
        {
            return await _context.dangKies.Where(p => p.IDDK == id).ToListAsync();
        }

        public async Task UpdateDK(DangKyModel bp, Guid id)
        {
            var result =await _context.dangKies.SingleOrDefaultAsync(p => p.IDDK == id);
            if(result!=null)
            {
                result.TenNguoiDK = bp.TenNguoiDK;
                _context.Update(result);
                await _context.SaveChangesAsync();
            } 
        }
    }
}
