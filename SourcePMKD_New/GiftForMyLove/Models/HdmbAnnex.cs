﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class HdmbAnnex
    {
        public long Id { get; set; }
        public string Systemref { get; set; }
        public string Number { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayTao { get; set; }
        public string Path { get; set; }
    }
}
