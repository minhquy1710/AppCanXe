using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("KhachHang")]
    internal class KhachHang
    {
        public KhachHang()
        {
        }
        [Key]
        public int MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public int DtKH { get; set; }
        public string DiaChiKH { get; set; }
        public int CMNDKH { get; set; }
        public string NgayCapKH { get; set; }
        public string NoiCapKH { get; set; }
        public string GhiChu { get; set; }
    }
}
