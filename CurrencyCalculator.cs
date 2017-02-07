using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class CurrencyCalculator is a static class that holds business methods.
 */
namespace CurrencyConversionProject
{
    public static class CurrencyCalculator
    {
        public static decimal GetConversion(Dollar dollar, CurrencyRate currencyRate)
        {
            Validate<DollarException, Dollar>(dollar);
            Validate<CurrencyRateException, CurrencyRate>(currencyRate);
            return dollar.Value * currencyRate.Rate;
        }

        //Method Validate() is a generic method that throws a specific exception if the object passed to the
        //method is null.
        private static void Validate<TException, T>(T anyT) where TException : Exception, new()
        {
            if(anyT == null)
            {
                throw new TException();
            }
        }
    }
}
