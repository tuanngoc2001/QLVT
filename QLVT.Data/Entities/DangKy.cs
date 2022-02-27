using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.Data.Entities
{
    [Table("DangKy")]
    public class DangKy
    {
        [Key]
        public Guid IDDK { get; set; }
        public string TenNguoiDK { get; set; }
        public virtual ICollection<MatHang> matHangs { get; set; }
        public Guid? IDBP { get; set; }
        [ForeignKey("IDBP")]
        public BoPhan boPhan { get; set; }

    }
}
