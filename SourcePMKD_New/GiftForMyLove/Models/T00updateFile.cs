using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T00updateFile
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string SourceFile { get; set; }
        public string SourceFileFpt { get; set; }
        public string TargetFile { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
