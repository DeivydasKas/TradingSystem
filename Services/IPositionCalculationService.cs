using System;
using System.Collections.Generic;
using System.Text;
using TradingSystem.Models;

namespace TradingSystem.Services
{
    public interface IPositionCalculationService
    {
        List<PositionSummary> Calculate(List<TradeForCalculations> trades);

    }
}
