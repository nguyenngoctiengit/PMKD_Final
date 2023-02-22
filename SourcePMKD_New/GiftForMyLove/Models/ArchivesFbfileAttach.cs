using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class ArchivesFbfileAttach
    {
        public long Id { get; set; }
        public long ArchivesFbid { get; set; }
        public string FileAttach { get; set; }
        public string FileSource { get; set; }
    }
}
