using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05dmtn
    {
        public long Id { get; set; }
        public int Stt { get; set; }
        public string MaTn { get; set; }
        public string TenTn { get; set; }
        public string LoaiTn { get; set; }
        public string CongThuc { get; set; }
        public string GhiChu { get; set; }
        public bool IsDisplay1 { get; set; }
        public bool IsDisplay2 { get; set; }
        public bool IsDisplay3 { get; set; }
        public bool IsInput { get; set; }
        public bool IsActive { get; set; }
        public string Dvt { get; set; }
        public bool Bold { get; set; }
        public string Color { get; set; }
        public string TkNo { get; set; }
        public string TkCo { get; set; }
        public string MaKm { get; set; }
        public byte[] TimeStamp { get; set; }
        public string MaData { get; set; }
        public short SttCal { get; set; }
    }
}
