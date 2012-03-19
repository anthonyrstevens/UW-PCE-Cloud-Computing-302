using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers.Questions.AverageStockPrice
{
    public class BlobAverageStockPrice
    {
        public BlobAverageStockPrice(Blob blob)
        {
            this.Blob = blob;
        }

        public virtual Blob Blob { get; set; }

        public AverageData Calculate(string identifier)
        {
            var data = new AverageData();

            var lines = this.Blob.GetAllLines();
            foreach (var line in lines)
            {
                var lineCalculator = new LineAverageStockPrice(line);
                var lineAverage = lineCalculator.Calculate(identifier);
                data.Merge(lineAverage);
            }

            return data;
        }
    }
}
