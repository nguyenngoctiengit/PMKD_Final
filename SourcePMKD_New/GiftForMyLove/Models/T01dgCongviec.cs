using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T01dgCongviec
    {
        public int Ident { get; set; }
        public string MaCbnv { get; set; }
        public string TenCbnv { get; set; }
        public string ChucVu { get; set; }
        public short Thang { get; set; }
        public short Nam { get; set; }
        public string MaKqth { get; set; }
        public string TenKqth { get; set; }
        public string TenTcDg { get; set; }
        public short DiemChuan { get; set; }
        public short DiemNvDg { get; set; }
        public short DiemLdDg { get; set; }
        public string MaCn { get; set; }
        public string LdTuNhan { get; set; }
        public bool Approve { get; set; }
        public string UserApprove { get; set; }
    }
}
