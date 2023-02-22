using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class ArchivesFileAttach
    {
        public long Id { get; set; }
        public long ArchivesId { get; set; }
        public string FileAttach { get; set; }
        public string FileSource { get; set; }
    }
}
