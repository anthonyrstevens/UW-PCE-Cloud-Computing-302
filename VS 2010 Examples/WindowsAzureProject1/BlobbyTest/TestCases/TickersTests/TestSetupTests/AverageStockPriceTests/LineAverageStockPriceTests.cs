using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers.Questions.AverageStockPrice;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests.TestSetupTests.AverageStockPriceTests
{
    [TestFixture]
    public class LineAverageStockPriceTests
    {
        [Test]
        public void GetPriceFromLine_returns_null_for_null_line()
        {
            var obj = new LineAverageStockPrice(null);
            var price = obj.GetPriceFromLine();
            Assert.IsNull(price);
        }

        [Test]
        public void GetPriceFromLine_returns_correct_value_for_correctly_formatted_line()
        {
            var obj = new LineAverageStockPrice("2012-03-05 MSFT 123.45");
            var expected = 123.45M;
            var price = obj.GetPriceFromLine();
            Assert.That(price, Is.EqualTo(expected));
        }
    }
}
