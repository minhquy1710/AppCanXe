using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("TTCanXe")]
    internal class TTCanXe
    {
        [Key]
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string IdNhomUser { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string BienSoDauXe { get; set; }
        public string BienSoDuoiXe { get; set; }
        public double KhoiLuongL1 { get; set; }
    }
}
