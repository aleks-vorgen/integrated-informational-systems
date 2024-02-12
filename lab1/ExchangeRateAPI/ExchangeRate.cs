using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public abstract class ExchangeRate
    {
        protected abstract string GetUSD();
        protected abstract string GetEUR();
    }
}
