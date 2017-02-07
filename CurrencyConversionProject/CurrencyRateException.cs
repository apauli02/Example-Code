using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class CurrencyRateException inherits from class Exception, and is a custom exception class with a custom
 * message.
 */ 
namespace CurrencyConversionProject
{
    public class CurrencyRateException : Exception
    {
        public CurrencyRateException() : base("Select a currency.")
        {

        }
    }
}
