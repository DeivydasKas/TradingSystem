using System;
using System.Collections.Generic;
using System.Text;

namespace TradingSystem.Models
{
    public class Trade
    {
        public int Id { get; set; }

        public string TradeNo { get; set; } = string.Empty;


        public string OrderNo { get; set; } = string.Empty;

        public DateTime TradeDate { get; set; }

        public int TradeType { get; set; }

        public string TradeState { get; set; } = string.Empty;

        public string TradeTypeDescription { get; set; } = string.Empty;

        public int SecurityId { get; set; }

        public string SecClassificationCode { get; set; } = string.Empty;

        public string SecClassificationDescription { get; set; } = string.Empty;

        public string Isin { get; set; } = string.Empty;

        public string SecurityDescription { get; set; } = string.Empty;

        public string Portfolio { get; set; } = string.Empty;

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; } = string.Empty;

        public decimal Commission { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
