using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class PairedPlan
    {
        public string PlansId { get; set; }
        public string ContracId { get; set; }
        public string SystemId { get; set; }
        public double Trongluong { get; set; }
        public string Dvt { get; set; }
        public string Macn { get; set; }

        public virtual Plan Plans { get; set; }
    }
}
