using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string getCcy() {  return ccy; }
        public string getBaseCcy() {  return base_ccy; }
        public double getBuy() { return buy;}
        public double getSale() { return sale;}
        public void setCcy(string ccy) {  this.ccy = ccy; }
        public void setBaseCcy(string base_ccy) {  this.base_ccy = ccy; }
        public void setBuy(double buy) { this.buy = buy; }
        public void setSale(double sale) { this.sale = sale; }
    }
}
