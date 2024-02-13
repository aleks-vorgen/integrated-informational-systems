using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace lab1.ExchangeRateAPI.Adapter
{
    internal class PBExchangeRateAdapter
    {

        List<PBExchangeRate> list = new List<PBExchangeRate>();

        public PBExchangeRateAdapter()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    Task<string> rates = client.GetStringAsync(Constants.PRIVATBANK);

                    list = JsonConvert.DeserializeObject<List<PBExchangeRate>>(rates.Result);
                }
                catch (HttpRequestException ex)
                {
                    throw ex;
                }
            }
        }

        public List<PBExchangeRate> GetEUR()
        {
            return list.FindAll((obj) => obj.GetCcy() == "EUR");
        }

        public List<PBExchangeRate> GetUSD()
        {
            return list.FindAll((obj) => obj.GetCcy() == "USD");
        }

        public List<PBExchangeRate> GetExchangeRates() { return list; }

        public void SetExchangeRates(List<PBExchangeRate> list) { this.list = list; }
    }
}
