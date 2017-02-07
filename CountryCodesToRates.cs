using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class CountryCodesToRates is a class designed to hold data from a specific JSON file. A CountryCodesToRates object
 * will hold up-to-date information on currency exchange rates and the currency code associated with them.
 */
namespace CurrencyConversionProject
{
    public class CountryCodesToRates
    {
        public string Disclaimer { get; set; }
        public string License { get; set; }
        public int TimeStamp { get; set; }
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
