using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05luongThuong
    {
        public long Id { get; set; }
        public string MaData { get; set; }
        public string MaCbNv { get; set; }
        public string TenCbNv { get; set; }
        public string MaBp { get; set; }
        public string ChucVu { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public decimal LuongThuong { get; set; }
        public string UserCreate { get; set; }
        public DateTime NgayChotThuong { get; set; }
        public int SoThangLv { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
