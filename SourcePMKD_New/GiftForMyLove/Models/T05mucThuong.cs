using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05mucThuong
    {
        public int Id { get; set; }
        public string MaData { get; set; }
        public int ThangTn1 { get; set; }
        public int ThangTn2 { get; set; }
        public string ListChucDanh { get; set; }
        public int LoaiHd { get; set; }
        public decimal TienThuong { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
