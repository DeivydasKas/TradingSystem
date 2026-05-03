using System;
using System.Collections.Generic;
using System.Text;

namespace TradingSystem.Models
{
    public class PositionSummary
    {
        public string Portfolio { get; set; } = string.Empty;
        public string Isin { get; set; } = string.Empty;

        public decimal BuyQuantity { get; set; }
        public decimal SellQuantity { get; set; }
        public decimal NetQuantity { get; set; }

        public decimal AverageBuyPrice { get; set; }
        public decimal AverageSellPrice { get; set; }

        public decimal TotalCommission { get; set; }
        public decimal RealizedCashFlow { get; set; }
    }
}
