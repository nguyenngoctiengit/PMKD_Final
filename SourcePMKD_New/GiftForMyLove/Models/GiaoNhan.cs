using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class GiaoNhan
    {
        public long Id { get; set; }
        public string Macn { get; set; }
        public string Systemref { get; set; }
        public string SoHd { get; set; }
        public string MaHang { get; set; }
        public DateTime NgayGiao { get; set; }
        public string NơiGiao { get; set; }
        public string GiamDinh { get; set; }
        public string KhuTrung { get; set; }
        public string TenThuoc { get; set; }
        public string ChongAm { get; set; }
        public string Marka { get; set; }
        public string KiemDich { get; set; }
        public string SoCont { get; set; }
        public string SoSeal { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public string PackedBy { get; set; }
        public decimal NumPacked { get; set; }
        public decimal Tear { get; set; }
        public string GhiChu { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
