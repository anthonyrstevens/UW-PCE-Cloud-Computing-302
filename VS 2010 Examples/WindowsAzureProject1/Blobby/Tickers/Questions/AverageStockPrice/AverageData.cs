using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers.Questions.AverageStockPrice
{
    public class AverageData
    {
        public virtual decimal? CalculatedAverage { get; set; }
        public virtual int DataPoints { get; set; }

        public virtual void Merge(AverageData other)
        {
            lock (this)
            {
                var currentTotal = this.CalculatedAverage.GetValueOrDefault(0.0M)*(decimal) this.DataPoints;
                var otherTotal = other.CalculatedAverage.GetValueOrDefault(0.0M)*(decimal) other.DataPoints;
                var newTotal = currentTotal + otherTotal;
                var newDataPoints = this.DataPoints + other.DataPoints;

                this.DataPoints = newDataPoints;
                this.CalculatedAverage = newTotal/newDataPoints;
            }
        }
    }
}
