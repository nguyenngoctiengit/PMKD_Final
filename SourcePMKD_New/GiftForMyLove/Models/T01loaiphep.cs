using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T01loaiphep
    {
        public string MaPhep { get; set; }
        public string TenLoai { get; set; }
        public int LoaiPhep { get; set; }
        public bool LoaiLuong { get; set; }
        public string KhCong { get; set; }
        public decimal NgayCong { get; set; }
        public decimal NghiCoLg { get; set; }
        public decimal NghiKgLg { get; set; }
        public decimal GioTangCa { get; set; }
        public decimal NgayLamDem { get; set; }
        public string MaData { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
