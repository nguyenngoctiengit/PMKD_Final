using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class TreHanMuaBan
    {
        public long Id { get; set; }
        public string MaDv { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int Tuan { get; set; }
        public string NhomHang { get; set; }
        public string MaHang { get; set; }
        public string HangHoa { get; set; }
        public decimal TreHanMua { get; set; }
        public string DienGiaiMua { get; set; }
        public decimal TreHanBan { get; set; }
        public string DienGiaiBan { get; set; }
        public decimal CanDoi { get; set; }
        public string DienGiaiCanDoi { get; set; }
        public int Type { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsLock { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
