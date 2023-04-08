using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("Vehicle")]
    internal class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string BienSoDauXe { get; set; }
        public string BienSoCuoiXe { get; set; }
        public double TrongTai { get; set; }
        public int DTXe { get; set; }
        public int CMNDXe { get; set; }
        public int MaTheXe { get; set; }
        public string GhiChuXe { get; set; }
        public string XeChiCan1Lan { get; set; }
    }
}
