using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05lamThem
    {
        public long Id { get; set; }
        public string MaCbNv { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public decimal SoNgay { get; set; }
        public decimal SoGio { get; set; }
        public decimal SoTien { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
