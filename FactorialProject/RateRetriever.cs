using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProject
{
    public interface RateRetriever
    {
        double GetCurrentRateFromYahooFinance(string source, string dest);
    }
}
