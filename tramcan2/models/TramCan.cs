﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("TramCan")]
    internal class TramCan
    {
        [Key]
        public int Id { get; set; }
        public string Ma { get; set; }
        public string TenTramCan { get; set; }
        public string GhiChu { get; set; }
    }
}
