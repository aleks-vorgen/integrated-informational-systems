using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.ExchangeRateAPI.Adapter
{
    internal class MBExchangeRateAdapter : ExchangeRate
    {
        private string currencyCodeA { get; set; }
        private string currencyCodeB { get; set; }
        private double rateBuy { get; set; }
        private double rateSell { get; set; }

        public MBExchangeRateAdapter(string currencyCodeA, string currencyCodeB, double rateBuy, double rateSell)
        {
            this.currencyCodeA = currencyCodeA;
            this.currencyCodeB = currencyCodeB;
            this.rateBuy = rateBuy;
            this.rateSell = rateSell;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override string getEUR()
        {
            throw new NotImplementedException();
        }

        protected override string getUSD()
        {
            throw new NotImplementedException();
        }
    }
}
