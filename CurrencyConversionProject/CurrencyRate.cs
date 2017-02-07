using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class CurrencyRate encapsulates the attributes of a CurrencyRate object.
 */
namespace CurrencyConversionProject
{
    public class CurrencyRate
    {
        public string CurrencyName { get; }
        public decimal Rate { get; }
        public CurrencyRate(string currencyName, decimal rate)
        {
            CurrencyName = currencyName;
            Rate = rate;
        }
    }
}
