using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T00lockedMonth
    {
        public int Ident { get; set; }
        public DateTime NgayLock { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string MaData { get; set; }
        public bool? Locked { get; set; }
        public string UserCreate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
