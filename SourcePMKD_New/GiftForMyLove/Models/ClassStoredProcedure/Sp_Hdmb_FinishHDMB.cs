using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_Hdmb_FinishHDMB
    {
        
        public string systemref { get; set; }
        public string mua_ban { get; set; }
        [Key]
        public string refnumber { get; set; }
        public string sohd { get; set; }
        public DateTime? ngayky { get; set; }
        public DateTime? ngaygiao { get; set; }
        public string ten_khach { get; set; }
        public decimal? TrongLuong { get; set; }
        public double? SL_Giao { get; set; }
        public int? Checked { get; set; }
        public int? DK { get; set; }
        public decimal? TrongLuongConLai { get; set; }
        public Int32 trangthai { get; set; }
    }
}
