using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class Reminder
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int IdMenu { get; set; }
    }
}
