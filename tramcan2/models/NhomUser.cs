using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("NhomUser")]
    internal class NhomUser
    {
        [Key]
        public int Id { get; set; }
        public string TenNhom { get; set; }
        public string GhiChu { get; set; }

    }
}
