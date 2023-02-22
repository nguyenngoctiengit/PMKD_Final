using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05phepnam
    {
        public long Id { get; set; }
        public int Nam { get; set; }
        public string MaCbNv { get; set; }
        public string TenCbNv { get; set; }
        public string MaBp { get; set; }
        public decimal SngayPhepChuan { get; set; }
        public decimal SoNamLv { get; set; }
        public decimal SngayPhepThem { get; set; }
        public decimal SngayPhepNam { get; set; }
        public decimal SngayPhepTon { get; set; }
        public decimal SngayDaNghiPhep { get; set; }
        public decimal SngayPhepConLai { get; set; }
        public decimal SphepTruT3 { get; set; }
        public string GhiChu { get; set; }
        public string MaData { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
