using QLVT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Model
{
    public interface IBoPhanRepository
    {
        Task<ICollection<BoPhan>> GetAll();
        Task<ICollection<BoPhan>> GetByID(Guid id);
        Task AddBoPhan(BoPhan bp);
        Task UpdateBoPhan(BoPhan bp,Guid id);
        Task DeleteBP(Guid id);
    }
}
