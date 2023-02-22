using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_Hdmb_HistoryHDMB
    {
        public string sohd { get; set; }
        [Key]
        public string hanghoa { get; set; }
        public double? TLGiao { get; set; }
        public DateTime ngayky { get; set; }
        public DateTime ngaygiao { get; set; }
        
        public string systemref { get; set; }
       
        public string mahang { get; set; }
        public string Price { get; set; }
        public Int32 trangthai { get; set; }
        public decimal trongluong { get; set; }
        public string DVTTheoHD { get; set; }
        public string Ref { get; set; }
        public DateTime? ngaytl { get; set; }
        public string ghichu { get; set; }
    }
}
