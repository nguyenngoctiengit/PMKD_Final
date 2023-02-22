using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class XuatKho
    {
        public string RefmuaBan { get; set; }
        public string MaKho { get; set; }
        public string MaHang { get; set; }
        public decimal Hinhthuc { get; set; }
        public string DienGiai { get; set; }
        public DateTime Ngay { get; set; }
        public decimal Soluong { get; set; }
        public decimal Trongluong { get; set; }
        public string Dvt { get; set; }
        public string Systemref { get; set; }
        public string Macn { get; set; }
        public string PhieuNhapXuat { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
