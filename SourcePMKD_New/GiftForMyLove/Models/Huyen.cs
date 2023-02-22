using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class Huyen
    {
        public Huyen()
        {
            Xas = new HashSet<Xa>();
        }

        public long Id { get; set; }
        public long KhuVucId { get; set; }
        public string KhuVucName { get; set; }
        public string Ten { get; set; }

        public virtual Khuvuc KhuVuc { get; set; }
        public virtual ICollection<Xa> Xas { get; set; }
    }
}
