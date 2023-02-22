using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05chamcongPhep
    {
        public long Id { get; set; }
        public string MaCbNv { get; set; }
        public string MaPhep { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public decimal SngayNghi { get; set; }
        public string LydoNghi { get; set; }
        public string GhiChu { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
