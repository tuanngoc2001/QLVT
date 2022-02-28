using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Model
{
    public interface IDangKyRepository
    {
        Task<ICollection<DangKy>> GetAll(int page);
        Task<ICollection<DangKy>> GetByID(Guid id);
        Task AddDK(DangKy bp);
        Task UpdateDK(DangKyModel bp, Guid id);
        Task DeleteDK(Guid id);
    }
}
