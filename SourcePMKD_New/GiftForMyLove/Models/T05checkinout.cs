using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05checkinout
    {
        public long Id { get; set; }
        public string UserEnrollNumber { get; set; }
        public DateTime? TimeDate { get; set; }
        public DateTime TimeStr { get; set; }
        public string OriginType { get; set; }
        public string NewType { get; set; }
        public string Source { get; set; }
        public byte? MachineNo { get; set; }
        public byte? WorkCode { get; set; }
        public string MaData { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
