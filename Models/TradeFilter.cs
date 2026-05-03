using System;
using System.Collections.Generic;
using System.Text;

namespace TradingSystem.Models
{
    public class TradeFilter
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? Security { get; set; }
        public string? Portfolio { get; set; }
        public string? TradeState { get; set; }
        public string? TradeTypeDescription { get; set; }
        public string? TradeNo { get; set; }
        public string? OrderNo { get; set; }
        public bool LoadCommissions { get; set; } = true;
    }
}
