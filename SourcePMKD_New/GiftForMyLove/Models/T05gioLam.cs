using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05gioLam
    {
        public long Id { get; set; }
        public string MaCbNv { get; set; }
        public string TenCbNv { get; set; }
        public string MaBp { get; set; }
        public string GioVao { get; set; }
        public string GioRa { get; set; }
        public DateTime NgayAp { get; set; }
        public decimal GioLv { get; set; }
        public int LoaiCong { get; set; }
        public string MaData { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
