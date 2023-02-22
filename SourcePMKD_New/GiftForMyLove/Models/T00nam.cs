using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T00nam
    {
        public int Ident00 { get; set; }
        public int Nam { get; set; }
        public string MaDvCs { get; set; }
        public int ThBdHt { get; set; }
        public bool LockedSdv { get; set; }
        public bool LockedSdk { get; set; }
        public bool LockedSdHanTt { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
