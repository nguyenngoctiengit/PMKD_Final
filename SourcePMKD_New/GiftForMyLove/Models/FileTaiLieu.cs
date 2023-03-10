using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class FileTaiLieu
    {
        public long Id { get; set; }
        public long TaiLieuId { get; set; }
        public string FileStore { get; set; }
        public string FileName { get; set; }
        public string Ext { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserCreate { get; set; }
        public int Status { get; set; }
        public bool IsPublic { get; set; }

        public virtual TaiLieu TaiLieu { get; set; }
    }
}
