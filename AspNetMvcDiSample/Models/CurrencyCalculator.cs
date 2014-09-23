namespace AspNetMvcDiSample.Models
{
    public class CurrencyCalculator : ICurrencyCalculator
    {
        private readonly IExchangeRateRepository _exchangeRateRepository;

        public CurrencyCalculator(IExchangeRateRepository exchangeRateRepository)
        {
            _exchangeRateRepository = exchangeRateRepository;
        }

        public Money GetValueInCurrency(Money money, string targetCurrency)
        {
            return new Money(
                _exchangeRateRepository.GetExchangeRate(money.Currency, targetCurrency)*money.Value,
                targetCurrency);
        }
    }
}