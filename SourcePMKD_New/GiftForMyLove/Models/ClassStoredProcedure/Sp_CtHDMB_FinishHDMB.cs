using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_CtHDMB_FinishHDMB
    {
        
        public string MaNhom { get; set; }
        [Key]
        public string mahang { get;set; }
        public string tenhang { get; set; }
        public string Gia { get; set; }
        public decimal TrongLuong { get; set; }
        public double TLGiao { get; set; }
        public double TLChenhLech { get; set; }
        public double SoBao { get; set; }
        public int SoBaoGiao { get; set; }
        public int SoBaoChenhLech { get; set; }

    }
}
