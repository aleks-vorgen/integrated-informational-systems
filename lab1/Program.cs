using lab1.ExchangeRateAPI.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    internal static class Program
    {
        static void Main()
        {
            PBExchangeRateAdapter pb = new PBExchangeRateAdapter();
            Console.WriteLine(pb.GetEUR());
            Console.WriteLine(pb.GetUSD());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
