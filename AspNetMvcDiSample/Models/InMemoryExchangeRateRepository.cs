using System.Collections.Generic;
using AspNetMvcDiSample.Tests;

namespace AspNetMvcDiSample.Models
{
    public class InMemoryExchangeRateRepository : IExchangeRateRepository
    {
        private Dictionary<string, decimal> _rates = new Dictionary<string, decimal>
        {
            {"PLNUSD", 3.24980257m},
            {"USDPLN", 0.307711m},
        };

        public decimal GetExchangeRate(string @from, string to)
        {
            return _rates[to + @from];
        }
    }
}