using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers;
using Blobby.Tickers.TestSetup;

namespace BlobbyTest.TestCases.TickersTests.TestSetupTests
{
    public class OneTimeSetup
    {
        public void OneTimeSetup_Method()
        {
            var identifiers = new Identifiers(
                                  new List<string>
                                  {
                                      "MSFT",
                                      "AMZN",
                                      "SBUX",
                                      "CSCO",
                                      "F",
                                      "X",
                                      "T",
                                      "BA",
                                      "ANTHONY",
                                      "CLOUD302"
                                  });

            var writer = new StockDataWriter();
            writer.SetUpSampleData("stockdata2", 2, 100000, identifiers);
        }
    }
}
