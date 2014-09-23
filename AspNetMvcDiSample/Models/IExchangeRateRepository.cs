namespace AspNetMvcDiSample.Models
{
    public interface IExchangeRateRepository
    {
        decimal GetExchangeRate(string from, string to);
    }
}