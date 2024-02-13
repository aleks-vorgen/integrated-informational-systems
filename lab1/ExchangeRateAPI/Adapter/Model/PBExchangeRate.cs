namespace lab1.ExchangeRateAPI.Adapter
{
    internal class PBExchangeRate
    {
        private string ccy;
        private string base_ccy;
        private double buy;
        private double sale;

        public PBExchangeRate(string ccy, string base_ccy, double buy, double sale)
        {
            this.ccy = ccy;
            this.base_ccy = base_ccy;
            this.buy = buy;
            this.sale = sale;
        }

        public override string ToString()
        {
            return "ccy: " + ccy + '\n'
                + "base_ccy: " + base_ccy + '\n'
                + "buy: " + buy + '\n'
                + "sale: " + sale + '\n';
        }

        public string GetCcy() { return ccy; }
        public string GetBaseCcy() { return base_ccy; }
        public double GetBuy() { return buy; }
        public double GetSale() { return sale; }
        public void SetCcy(string ccy) { this.ccy = ccy; }
        public void SetBaseCcy(string base_ccy) { this.base_ccy = base_ccy; }
        public void SetBuy(double buy) { this.buy = buy; }
        public void SetSale(double sale) { this.sale = sale; }
    }
}
