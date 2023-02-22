using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T02thanhlyHd
    {
        public long Id { get; set; }
        public string MaHd { get; set; }
        public string MaDt { get; set; }
        public string TenDt { get; set; }
        public DateTime? NgayLap { get; set; }
        public decimal GiaTri1 { get; set; }
        public decimal GiaTri2 { get; set; }
        public decimal GiaTriTh { get; set; }
        public decimal TongTienVat { get; set; }
        public decimal TongGiaTri { get; set; }
        public decimal TtDot1 { get; set; }
        public decimal TtDot2 { get; set; }
        public decimal TtDotCuoi { get; set; }
        public string GhiChu { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
