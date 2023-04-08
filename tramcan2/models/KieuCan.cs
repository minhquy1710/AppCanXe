using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("KieuCan")]
    internal class KieuCan
    {
        [Key]
        public int Id { get; set; }
        public string TenKieuCan { get; set; }
        public string GhiChu { get; set; }
        public int SoLanCan { get; set; }
        public string TenThongTinChua { get; set; }
        public double DuLieuDieuChinh { get; set; }
    }
}
