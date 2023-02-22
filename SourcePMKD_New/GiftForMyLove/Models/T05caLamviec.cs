using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05caLamviec
    {
        public long Id { get; set; }
        public DateTime NgayAd { get; set; }
        public string MaCa { get; set; }
        public string GhiChu { get; set; }
        public string GioVao { get; set; }
        public string GioRa { get; set; }
        public decimal TgLvMin { get; set; }
        public decimal TgLvMax { get; set; }
        public decimal GioTongLv { get; set; }
        public string KyHieuCong { get; set; }
        public string GiuaCa1 { get; set; }
        public string GiuaCa2 { get; set; }
        public decimal TongGioGiuaCa { get; set; }
        public decimal HeSoLv { get; set; }
        public decimal HeSoTc { get; set; }
        public decimal HeSoTc1 { get; set; }
        public decimal HeSoTc2 { get; set; }
        public string MaData { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserModifyLast { get; set; }
        public DateTime? DateModify { get; set; }
        public string GioVaoMin { get; set; }
        public string GioVaoMax { get; set; }
        public string GioRaMin { get; set; }
        public string GioRaMax { get; set; }
        public bool IsCaDem { get; set; }
        public decimal SpVaoTreCp { get; set; }
        public decimal SpRaSomCp { get; set; }
        public decimal TgTangCa { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
