using System;
using System.Collections.Generic;
using System.Text;
using TradingSystem.Models;

namespace TradingSystem.Services
{
    public interface ITradesService
    {
        Task<List<Trade>> GetFilteredTrades(TradeFilter filter);

        Task<(bool success, string? error)> ConfirmTrade(string tradeNo);

        Task<List<TradeForCalculations>> GetTradesForCalculations(string portfolio, string isin);
    }
}
