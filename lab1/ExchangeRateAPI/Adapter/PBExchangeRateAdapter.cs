using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.ExchangeRateAPI.Adapter
{
    internal class PBExchangeRateAdapter : ExchangeRate
    {
        private string ccy { get; set; }
        private string base_ccy { get; set; }
        private double buy { get; set; }
        private double sell { get; set; }

        public PBExchangeRateAdapter(string ccy, string base_ccy, double buy, double sell)
        {
            this.ccy = ccy;
            this.base_ccy = base_ccy;
            this.buy = buy;
            this.sell = sell;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override string getEUR()
        {
            
        }

        protected override string getUSD()
        {
            
        }
    }
}
