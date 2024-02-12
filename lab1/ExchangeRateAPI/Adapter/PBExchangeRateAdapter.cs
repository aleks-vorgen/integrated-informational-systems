using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace lab1.ExchangeRateAPI.Adapter
{
    internal class PBExchangeRateAdapter : ExchangeRate
    {

        List<PBExchangeRate> list = new List<PBExchangeRate>();
        
        public PBExchangeRateAdapter()
        {
            using (var client = new HttpClient())
            {
                Task<string> rates = client.GetStringAsync(Constants.PRIVATBANK);

                list = JsonConvert.DeserializeObject<List<PBExchangeRate>>(rates.Result);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string GetEUR()
        {
           
            return list.Find((obj) => obj.getCcy() == "EUR").ToString();
        }

        public override string GetUSD()
        {
            return list.Find((obj) => obj.getCcy() == "USD").ToString();
        }
    }
}
