using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class NhomHangHoa
    {
        public int NhomHangHoaId { get; set; }
        public string TenNhom { get; set; }
        public string TenFull { get; set; }
        public Int16 Order_Nhom { get; set; }
    }
}
