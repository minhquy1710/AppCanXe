using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("LoaiHang")]
    internal class LoaiHang
    {
        [Key]
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string TenLoaiHang { get; set; }
        public double DonGia { get; set; }
        public double TyLeQuyDoi { get; set; }
        public string GhiChu { get; set; }
    }
}
