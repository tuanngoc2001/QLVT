using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Model
{
    public interface IBoPhanRepository
    {
        Task<ICollection<BoPhan>> GetAll(int page);
        Task<ICollection<BoPhan>> GetByID(Guid id);
        Task AddBoPhan(BoPhan bp);
        Task UpdateBoPhan(BoPhanModel bp,Guid id);
        Task DeleteBP(Guid id);
    }
}
