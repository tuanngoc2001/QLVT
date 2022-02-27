using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.Data.Entities
{
    [Table("MatHang")]
    public class MatHang
    {
        [Key]
        public Guid IDMH { get; set; }
        [MaxLength(50)]
        public string TenMH { get; set; }
        public int SL { get; set; }
        public int STT { get; set; }
        public Guid? IDDK { get; set; }
        [ForeignKey("IDDK")]
        public DangKy dangKy { get; set; }

    }
}
