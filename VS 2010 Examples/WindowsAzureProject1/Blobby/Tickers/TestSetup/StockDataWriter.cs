using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers.TestSetup
{
    public class StockDataWriter
    {
        public void SetUpSampleData(string containerName, int numFiles, int fileLineCount, Identifiers allowedIdentifiers)
        {
            var provider = new BlobProvider();
            var factory = new QuoteFileFactory();
            
            for (var n = 0; n < numFiles; n++)
            {
                var fileName = "stock" + n.ToString() + ".txt";

                var file = factory.CreateRandomFile(allowedIdentifiers, fileLineCount);
                provider.CreateBlob(containerName, fileName, file.ToString());
            }
        }
    }
}
