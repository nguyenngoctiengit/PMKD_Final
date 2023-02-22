using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05khenThuongKyLuat
    {
        public long Id { get; set; }
        public string MaCbNv { get; set; }
        public bool Loai { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayAd { get; set; }
        public string NoiDung { get; set; }
        public decimal Tien { get; set; }
        public string GhiChu { get; set; }
        public string NguoiKy { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
