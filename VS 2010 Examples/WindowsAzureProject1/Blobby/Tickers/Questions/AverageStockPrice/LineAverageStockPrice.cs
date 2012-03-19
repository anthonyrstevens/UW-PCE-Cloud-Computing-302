using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Blobby.Tickers.Questions.AverageStockPrice;

namespace Blobby.Tickers.Questions.AverageStockPrice
{
    public class LineAverageStockPrice
    {
        public LineAverageStockPrice(string line)
        {
            this.Line = line;
        }

        public virtual string Line { get; set; }

        public AverageData Calculate(string identifier)
        {
            var returnValue = new AverageData();

            if (this.DoesContainIdentifier(identifier))
            {
                returnValue.CalculatedAverage = this.GetPriceFromLine();
                returnValue.DataPoints = 1;
            }

            return returnValue;
        }

        protected internal virtual bool DoesContainIdentifier(string identifier)
        {
            var regex = new Blobby.Utils.Regex();
            var pattern = String.Format(@"\w{0}\w", identifier);
            return regex.IsMatch(this.Line, pattern);
        }

        protected internal virtual decimal? GetPriceFromLine()
        {
            decimal? price = null;
            try
            {
                var regex = new Blobby.Utils.Regex();
                const string pattern = @"\w\d*\.\d*$";
                var matches = regex.GetMatches(this.Line, pattern);
                price = decimal.Parse(matches.First());

            }
            catch (Exception exc)
            {
                Trace.TraceError(exc.ToString());
            }
            return price;

        }
    }
}
