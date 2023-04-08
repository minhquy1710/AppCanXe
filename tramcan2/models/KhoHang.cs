using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("KhoHang")]
    internal class KhoHang
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoHang { get; set; }
        public string DiaChiKhoHang { get; set; }
        public string GhiChu { get; set; }
    }
}
