using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GiaoNhan_HistoryHDMB
    {
        public string sohdmua { get; set; }
        public string sohdban { get; set; }
        public DateTime ngayky { get; set; }
        public string ItemCode { get; set; }
        public decimal SLHD { get; set; }
        public int SoBaoHD { get; set; }
        public double SLGiao { get; set; }
        public int SoBao { get; set; }
        public string NgayGiaoHang { get; set; }
        public string ten_khach { get; set; }
        public string NgayGiaoTrenHĐ { get; set; }
        public string Gia { get; set; }
        public string xe_vc { get; set; }
        public string NoiGiaoHang { get; set; }
        [Key]
        public string Id { get; set; }

    }
}
