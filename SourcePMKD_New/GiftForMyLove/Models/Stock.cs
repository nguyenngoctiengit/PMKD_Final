using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class Stock
    {
        public long StockId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Macn { get; set; }
        public int IsStockService { get; set; }
        public bool IsCheckKcs { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
