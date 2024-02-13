using lab1.ExchangeRateAPI.Adapter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace lab1.ExchangeRateAPI.Adapter
{
    internal class MBExchangeRateAdapter
    {
        private List<MBExchangeRate> list = new List<MBExchangeRate>();

        public MBExchangeRateAdapter()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    Task<string> rates = client.GetStringAsync(Constants.MONOBANK);

                    List<MBExchangeRate> tmp = new List<MBExchangeRate>();
                    tmp = JsonConvert.DeserializeObject<List<MBExchangeRate>>(rates.Result);

                    foreach (MBExchangeRate rate in tmp)
                    {
                        if (rate.GetCurrencyCodeB() == "UAH" && rate.GetCurrencyCodeA() == "EUR" || rate.GetCurrencyCodeA() == "USD")
                        {
                            list.Add(rate);
                        }
                    }

                    tmp.Clear();
                }
                catch (AggregateException ex)
                {
                    throw ex;
                }
            }
        }

        public List<MBExchangeRate> GetEUR()
        {
            return list.FindAll((obj) => obj.GetCurrencyCodeA() == "EUR");
        }

        public List<MBExchangeRate> GetUSD()
        {
            return list.FindAll((obj) => obj.GetCurrencyCodeA() == "USD");
        }

        public List<MBExchangeRate> GetExchangeRates() { return list; }

        public void SetExchangeRates(List<MBExchangeRate> list) { this.list = list; }
    }
}
