namespace lab1.ExchangeRateAPI.Adapter.Model
{
    internal class MBExchangeRate
    {
        private string currencyCodeA;
        private string currencyCodeB;
        private double rateBuy;
        private double rateSell;

        public MBExchangeRate(string currencyCodeA, string currencyCodeB, double rateBuy, double rateSell)
        {
            switch (currencyCodeA)
            {
                case "840": { this.currencyCodeA = "USD"; break; }
                case "978": { this.currencyCodeA = "EUR"; break; }
                case "980": { this.currencyCodeA = "UAH"; break; }
                default: { this.currencyCodeA = currencyCodeA; break; }
            }
            switch (currencyCodeB)
            {
                case "840": { this.currencyCodeB = "USD"; break; }
                case "978": { this.currencyCodeB = "EUR"; break; }
                case "980": { this.currencyCodeB = "UAH"; break; }
                default: { this.currencyCodeB = currencyCodeB; break; }
            }
            this.rateBuy = rateBuy;
            this.rateSell = rateSell;
        }

        public override string ToString()
        {
            return "currencyCodeA: " + currencyCodeA + '\n'
                + "currencyCodeB: " + currencyCodeB + '\n'
                + "rateBuy: " + rateBuy + '\n'
                + "rateSell: " + rateSell + '\n';
        }

        public string GetCurrencyCodeA() { return currencyCodeA; }
        public string GetCurrencyCodeB() { return currencyCodeB; }
        public double GetRateBuy() { return rateBuy; }
        public double GetRateSell() { return rateSell; }
        public void SetCurrencyCodeA(string currencyCodeA) { this.currencyCodeA = currencyCodeA; }
        public void SetCurrencyCodeB(string currencyCodeB) { this.currencyCodeB = currencyCodeB; }
        public void SetRateBuy(double rateBuy) { this.rateBuy = rateBuy; }
        public void SetRateSell(double rateSell) { this.rateSell = rateSell; }
    }
}
