using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05tienNopBaoHiem
    {
        public long Id { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string MaCbNv { get; set; }
        public string TenCbNv { get; set; }
        public string MaBp { get; set; }
        public decimal LuongBh { get; set; }
        public decimal HeSo { get; set; }
        public decimal DnBhxh { get; set; }
        public decimal DnBhyt { get; set; }
        public decimal DnBhtn { get; set; }
        public decimal NvBhxh { get; set; }
        public decimal NvBhyt { get; set; }
        public decimal NvBhtn { get; set; }
        public string GhiChu { get; set; }
        public string MaData { get; set; }
        public string UserCreate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
