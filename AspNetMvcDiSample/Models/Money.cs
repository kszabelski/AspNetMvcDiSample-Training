namespace AspNetMvcDiSample.Models
{
    public class Money
    {
        public Money(decimal value, string currency)
        {
            Value = value;
            Currency = currency;
        }

        public decimal Value { get; private set; }
        public string Currency { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Value, Currency);
        }

        public override bool Equals(object obj)
        {
            var moneyObj = obj as Money;
            if (moneyObj == null)
                return false;
            return Value == moneyObj.Value && Currency == moneyObj.Currency;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode() * Currency.GetHashCode();
        }
    }
}