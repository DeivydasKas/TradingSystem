using System;
using System.Collections.Generic;
using System.Text;

namespace TradingSystem.Models
{
    public class TradeForCalculations
    {
        public string TradeTypeDescription { get; set; } = string.Empty;

        public string Isin { get; set; } = string.Empty;

        public string Portfolio { get; set; } = string.Empty;

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Commission { get; set; }
    }
}
