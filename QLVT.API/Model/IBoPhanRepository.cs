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
        Task<BoPhan> AddBoPhan(BoPhan bp);
    }
}
