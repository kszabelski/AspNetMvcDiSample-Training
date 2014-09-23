namespace AspNetMvcDiSample.Models
{
    public interface ICurrencyCalculator
    {
        Money GetValueInCurrency(Money money, string targetCurrency);
    }
}