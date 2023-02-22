using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05luongTamung
    {
        public long Id { get; set; }
        public string MaData { get; set; }
        public string MaCbNv { get; set; }
        public string TenCbNv { get; set; }
        public string MaBp { get; set; }
        public string ChucVu { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string GhiChu { get; set; }
        public string BacLuongHq { get; set; }
        public decimal LuongHq { get; set; }
        public decimal PhuCap { get; set; }
        public decimal TongLuong { get; set; }
        public decimal TamUng { get; set; }
        public decimal ThucLanh { get; set; }
        public string UserCreate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
