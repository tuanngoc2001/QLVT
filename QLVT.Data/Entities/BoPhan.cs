using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.Data.Entities
{
    [Table("BoPhan")]
    public class BoPhan
    {
        [Key]
        public Guid IDBP { get; set; }
        [Column(TypeName ="ntext")]
        public string TenBP { get; set; }
        [MaxLength(50)]
        public string TenNDD { get; set; }
        public virtual ICollection<DangKy> matHangs { get; set; }
        public DateTime NgayTao { get; set; }
        public int STT { get; set; }

    }
}
