using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab1.ExchangeRateAPI.Adapter
{
    internal class PBExchangeRateAdapter : ExchangeRate
    {
        private string ccy { get; set; }
        private string base_ccy { get; set; }
        private string buy { get; set; }
        private string sale { get; set; }

        public PBExchangeRateAdapter()
        {
            using (var client = new HttpClient())
            {
                Task<string> rates = client.GetStringAsync(Constants.PRIVATBANK);
                
                Console.WriteLine(JsonSerializer.Deserialize<PBExchangeRateAdapter>(rates.Result));
            }
        }

        public PBExchangeRateAdapter(string ccy, string base_ccy, string buy, string sale)
        {
            this.ccy = ccy;
            this.base_ccy = base_ccy;
            this.buy = buy;
            this.sale = sale;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override string GetEUR()
        {
            return null;
        }

        protected override string GetUSD()
        {
            return null;
        }
    }
}
