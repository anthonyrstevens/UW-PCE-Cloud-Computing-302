using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Utils
{
    public static class DecimalExtensions
    {
        public static decimal ToTwoDecimalPlaces(this decimal input)
        {
            return decimal.Round(input, 2);
        }
    }
}
