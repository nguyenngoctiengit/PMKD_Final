using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class Xeptai
    {
        public long Id { get; set; }
        public string SoXe { get; set; }
        public string HopDong { get; set; }
        public int BagTypeId { get; set; }
        public int SoBao { get; set; }
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string MaKhach { get; set; }
        public string KhachHang { get; set; }
        public int? Status { get; set; }
        public bool Iscan { get; set; }
        public DateTime Ngaycan { get; set; }
        public string Macn { get; set; }
        public string GhiChu { get; set; }
        public string UserApove { get; set; }
        public bool Aprove { get; set; }
        public DateTime NgayVao { get; set; }
        public decimal TlBaobi { get; set; }
        public string PhieuNhapKho { get; set; }
        public bool IsHoanThanh { get; set; }
    }
}
