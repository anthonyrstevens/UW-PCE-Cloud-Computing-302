using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers.Questions.AverageStockPrice
{
    public class ContainerAverageStockPrice
    {
        public ContainerAverageStockPrice(BlobProvider provider, string containerName)
        {
            this.BlobProvider = provider;
            this.ContainerName = containerName;
        }

        public virtual BlobProvider BlobProvider { get; set; }
        public virtual string ContainerName { get; set; }

        public AverageData Calculate(string identifier)
        {
            var data = new AverageData();

            var blobs = this.BlobProvider.GetAllBlobs(this.ContainerName);
            foreach (var blob in blobs)
            {
                var blobCalculator = new BlobAverageStockPrice(blob);
                var blobAverage = blobCalculator.Calculate(identifier);
                data.Merge(blobAverage);
            }

            return data;
        }
    }
}
