using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using TradingSystem.Models;

namespace TradingSystem.Services
{
    
    public class TradesService : ITradesService
    {
        private readonly HttpClient _httpClient;
        public TradesService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DummyJsonClient");
        }

        public async Task<List<Trade>> GetFilteredTrades(TradeFilter filter)
        {
            var url = "api/trades";
            var queryParams = new List<string>();

            if(!string.IsNullOrWhiteSpace(filter.TradeState))
            {
                queryParams.Add($"tradeState={Uri.EscapeDataString(filter.TradeState)}");
            }
            if(!string.IsNullOrWhiteSpace(filter.Portfolio))
            {
                queryParams.Add($"portfolio={Uri.EscapeDataString(filter.Portfolio)}");
            }

            if(!string.IsNullOrWhiteSpace(filter.Security))
            {
                queryParams.Add($"security={Uri.EscapeDataString(filter.Security)}");
            }
            if(!string.IsNullOrWhiteSpace(filter.TradeTypeDescription))
            {
                queryParams.Add($"tradeTypeDescription={Uri.EscapeDataString(filter.TradeTypeDescription)}");
            }
            if(!string.IsNullOrWhiteSpace(filter.TradeNo))
            {
                queryParams.Add($"tradeNo={Uri.EscapeDataString(filter.TradeNo)}");
            }
            if(!string.IsNullOrWhiteSpace(filter.OrderNo))
            {
                queryParams.Add($"orderNo={Uri.EscapeDataString(filter.OrderNo)}");
            }
            if(filter.DateFrom.HasValue)
            {
                queryParams.Add($"dateFrom={filter.DateFrom.Value:yyyy-MM-dd}");
            }
            if(filter.DateTo.HasValue)
            {
                queryParams.Add($"dateTo={filter.DateTo.Value:yyyy-MM-dd}");
            }
            queryParams.Add($"loadComissions={filter.LoadCommissions.ToString().ToLower()}");

            if(queryParams.Any())
            {
                url += "?" + string.Join("&", queryParams);
            }

            var response = await _httpClient.GetFromJsonAsync<ApiResult<List<Trade>>>(url) ?? throw new Exception("No response from API");

            if(!response.Success)
            {
                throw new Exception(response.Message);
            }

            return response.Data ?? new List<Trade>();

        }

        public async Task<(bool success, string? error)> ConfirmTrade(string tradeNo)
        {
            
            var url = $"api/trades/{tradeNo}/confirm";

            var response = await _httpClient.PostAsync(url, null);

            var body = await response.Content.ReadAsStringAsync();
            if(!response.IsSuccessStatusCode)
            {
                return (false, body);
            }

            return (true, null); 
        }

        public async Task<List<TradeForCalculations>> GetTradesForCalculations(string portfolio, string isin)
        {
            string url = "api/trades/position-calculations";
            var queryParams = new List<string>();

            if(!string.IsNullOrWhiteSpace(portfolio))
            {
                queryParams.Add($"portfolio={Uri.EscapeDataString(portfolio)}");
            }
            if (!string.IsNullOrWhiteSpace(isin))
            {
                queryParams.Add($"isin={Uri.EscapeDataString(isin)}");
            }

            if(queryParams.Any())
            {
                url += "?" + string.Join("&", queryParams);
            }

            var response = await _httpClient.GetAsync(url);

            if(!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show(error);
                return new List<TradeForCalculations>();
            }
            var data = await response.Content.ReadFromJsonAsync<ApiResult<List<TradeForCalculations>>>() ?? throw new Exception("Not possible to get API response");

            if(!data.Success)
            {
                throw new Exception(data.Message);
            }
           

            return data.Data ?? new List<TradeForCalculations>();
        }

    }

}
