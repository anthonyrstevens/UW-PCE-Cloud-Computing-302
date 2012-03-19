using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Utils;

namespace Blobby.Tickers
{
    public class Quote : Ticker
    {
        public virtual DateTime QuoteDate { get; set; }

        /// <summary>
        /// returns a formatted string.  The parameter is a C#-style format string, expecting three parameters:
        /// the date
        /// the identifier
        /// the price
        /// </summary>
        /// <param name="formatString"></param>
        /// <returns></returns>
        public virtual string ToString(string formatString)
        {
            return String.Format(formatString, this.QuoteDate, this.Identifier, this.Price);
        }
    }
}
