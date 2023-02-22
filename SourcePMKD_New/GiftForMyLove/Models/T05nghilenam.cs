using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05nghilenam
    {
        public long Id { get; set; }
        public int Nam { get; set; }
        public string MaData { get; set; }
        public string MaNgayNghi { get; set; }
        public string GhiChu { get; set; }
        public decimal HeSoLv { get; set; }
        public decimal HeSoTc { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserModifyLast { get; set; }
        public DateTime? DateModify { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
