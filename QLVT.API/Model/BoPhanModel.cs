using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLVT.API.Model
{
    public class BoPhanModel
    {
        [Column(TypeName = "ntext")]
        public string TenBP { get; set; }
        [MaxLength(50)]
        public string TenNDD { get; set; }
        public DateTime NgayTao { get; set; }
        public int STT { get; set; }
    }
}
