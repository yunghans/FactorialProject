using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProject
{
    public class CurrencyConverter
    {
        RateRetriever r;

        public CurrencyConverter(RateRetriever rateRet)
        {
            r = rateRet;
        }

        public double Convert(string source, string dest, double amt){
            double rate = r.GetCurrentRateFromYahooFinance(source, dest);

            return amt * rate;
        }
    }
}
