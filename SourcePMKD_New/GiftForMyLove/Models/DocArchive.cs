using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class DocArchive
    {
        public long Id { get; set; }
        public long DocId { get; set; }
        public long ArchivesId { get; set; }
    }
}
