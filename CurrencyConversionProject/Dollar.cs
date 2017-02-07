using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class Dollar encapsulates the attributes of a Dollar object, and overwrites the ToString() method.
 */
namespace CurrencyConversionProject
{
    public class Dollar
    {
        public int Value { get; }
        public Dollar(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString("N0").PadLeft(3);
        }
    }
}
