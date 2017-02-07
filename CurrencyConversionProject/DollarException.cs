using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class DollarException inherits from class Exception, and is a custom exception class with a custom
 * message.
 */
namespace CurrencyConversionProject
{
    public class DollarException : Exception
    {
        public DollarException() : base("Select a dollar amount.")
        {

        }
    }
}
