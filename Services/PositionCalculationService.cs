using System;
using System.Collections.Generic;
using System.Text;
using TradingSystem.Models;

namespace TradingSystem.Services
{
    public class PositionCalculationService : IPositionCalculationService
    {
        public List<PositionSummary> Calculate(List<TradeForCalculations> trades)
        {
            List<PositionSummary> positionSummary = new List<PositionSummary>();


            var groupedTrades = trades.GroupBy(x => new { x.Portfolio, x.Isin });

            foreach (var group in groupedTrades)
            {
                PositionSummary position = new PositionSummary();
                position.Portfolio = group.Key.Portfolio;
                position.Isin = group.Key.Isin;

                position.BuyQuantity = CalculateBuyQuantity(group);
                position.SellQuantity = CalculateSellQuantity(group);
                position.NetQuantity = CalculateNetQuantity(group);
                position.AverageBuyPrice = CalculateAvgBuyPrice(group);
                position.AverageSellPrice = CalculateAvgSellPrice(group);
                position.TotalCommission = CalculateCommissions(group);
                position.RealizedCashFlow = CalculateCashFlow(group);
                positionSummary.Add(position);
            }


            return positionSummary;
        }
        private decimal CalculateBuyQuantity(IEnumerable<TradeForCalculations> trades)
        {
            decimal buyQuantity = 0;

            var buyTrades = trades.Where(x => x.TradeTypeDescription.Equals("buy", StringComparison.OrdinalIgnoreCase));


            foreach (var item in buyTrades)
            {
                buyQuantity += item.Quantity;
            }

            return buyQuantity;
        }

        private decimal CalculateSellQuantity(IEnumerable<TradeForCalculations> trades)
        {
            decimal sellQuantity = 0;

            var sellTrades = trades.Where(x => x.TradeTypeDescription.Equals("sell", StringComparison.OrdinalIgnoreCase));


            foreach (var item in sellTrades)
            {
                sellQuantity += item.Quantity;
            }

            return sellQuantity;
        }

        private decimal CalculateNetQuantity(IEnumerable<TradeForCalculations> trades)
        {
            decimal netQuantity = 0;

            netQuantity += CalculateBuyQuantity(trades) - CalculateSellQuantity(trades);

            return netQuantity;
        }

        private decimal CalculateAvgBuyPrice(IEnumerable<TradeForCalculations> trades)
        {
            decimal avgBuyPrice = 0;

            decimal spendMoney = 0;
            decimal qty = 0;

            var buyTrades = trades.Where(x => x.TradeTypeDescription.Equals("buy", StringComparison.OrdinalIgnoreCase));

            foreach (var item in buyTrades)
            {
                spendMoney += item.Price * item.Quantity;
                qty += item.Quantity;
            }

            if (qty == 0)
                return 0;
            avgBuyPrice = spendMoney / qty;

            return avgBuyPrice;
        }

        private decimal CalculateAvgSellPrice(IEnumerable<TradeForCalculations> trades)
        {
            decimal avgSellPrice = 0;

            decimal spendMoney = 0;
            decimal qty = 0;

            var sellTrades = trades.Where(x => x.TradeTypeDescription.Equals("sell", StringComparison.OrdinalIgnoreCase));

            foreach (var item in sellTrades)
            {
                spendMoney += item.Price * item.Quantity;
                qty += item.Quantity;
            }

            if (qty == 0)
                return 0;
            avgSellPrice = spendMoney / qty;

            return avgSellPrice;
        }

        private decimal CalculateCommissions(IEnumerable<TradeForCalculations> trades)
        {
            decimal sumCommissions = 0;

            foreach (var item in trades)
            {
                sumCommissions += item.Commission;
            }

            return sumCommissions;
        }

        private decimal CalculateCashFlow(IEnumerable<TradeForCalculations> trades)
        {
            decimal finalSum = 0;


            //var sellTrades = trades.Where(x => x.TradeTypeDescription.Equals("sell", StringComparison.OrdinalIgnoreCase));


            foreach (var item in trades)
            {
                decimal sum = 0;
                if (item.TradeTypeDescription.Equals("buy", StringComparison.OrdinalIgnoreCase))
                {
                    sum = -(item.Price * item.Quantity) - item.Commission;
                }
                if (item.TradeTypeDescription.Equals("sell", StringComparison.OrdinalIgnoreCase))
                {
                    sum = (item.Price * item.Quantity) - item.Commission;
                }
                finalSum += sum;
            }

            return finalSum;
        }


    }


}
