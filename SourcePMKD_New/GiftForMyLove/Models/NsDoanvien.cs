﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class NsDoanvien
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public string MaThe { get; set; }
        public DateTime NgayVao { get; set; }
        public string NoiVao { get; set; }
        public string NoiSh { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayCap { get; set; }
    }
}
