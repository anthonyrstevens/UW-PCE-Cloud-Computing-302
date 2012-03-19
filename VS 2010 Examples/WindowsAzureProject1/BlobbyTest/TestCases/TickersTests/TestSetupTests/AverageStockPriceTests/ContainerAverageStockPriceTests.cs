using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby;
using Blobby.Tickers.Questions.AverageStockPrice;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests.TestSetupTests.AverageStockPriceTests
{
    [TestFixture]
    public class ContainerAverageStockPriceTests
    {
        [Test]
        public void Get_MSFT_average_price_does_not_throw()
        {
            var provider = new BlobProvider();
            var container = new ContainerAverageStockPrice(provider, "stock2");
            var averageData = container.Calculate("MSFT");
            
        }
    }
}
