using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class AutomaticValuesBranchChange
    {
        public string ObjectName { get; set; }
        public string MaCn { get; set; }
        public string PrefixOfDefaultValueForId { get; set; }
        public byte? LengthOfDefaultValueForId { get; set; }
        public string LastValueOfColumnId { get; set; }
        public string NextValueOfColumnId { get; set; }
        public int? Nam { get; set; }
        public bool? IsUpdate { get; set; }
    }
}
