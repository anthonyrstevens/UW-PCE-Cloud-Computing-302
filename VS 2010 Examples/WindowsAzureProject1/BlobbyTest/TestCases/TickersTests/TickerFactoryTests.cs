using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests
{
    [TestFixture]
    public class TickerFactoryTests
    {
        [Test]
        public virtual void CreateTicker_creates_ticker()
        {
            var factory = new TickerFactory();
            var ticker = factory.CreateRandomTicker();
            Assert.IsNotNull(ticker);
        }

        [Test]
        public virtual void CreateTicker_creates_ticker_with_ascii_identifier()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void CreateRandomIdentifier_returns_alpha_characters()
        {
            var factory = new TickerFactory();
            var identifier = factory.CreateRandomIdentifier();
            AssertHelper.IsAscii(identifier);
        }

    }
}
