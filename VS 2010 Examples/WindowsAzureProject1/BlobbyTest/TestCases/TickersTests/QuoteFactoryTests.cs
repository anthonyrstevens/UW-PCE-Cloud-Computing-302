using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests
{
    [TestFixture]
    public class QuoteFactoryTests
    {
        [Test]
        public void CreateRandomQuote_creates_quote()
        {
            // arrange
            var factory = new QuoteFactory();

            // act
            var quote = factory.CreateRandomQuote();

            // assert
            Assert.IsNotNull(quote);
        }

        [Test]
        public void CreateListOfRandomQuotes_returns_list_of_correct_length()
        {
            // arrange
            var factory = new QuoteFactory();
            var count = 1000;

            // act
            var quotes = factory.CreateListOfRandomQuotes(count);

            // assert
            Assert.That(quotes.Count, Is.EqualTo(count));
        }

        [Test]
        public void CreateRandomQuote_respects_my_authority()
        {
            // arrange
            var factory = new QuoteFactory();
            var allowedIdentifiers = new Identifiers(new List<string> { "SBUX" });
            // act
            var quote = factory.CreateRandomQuote(allowedIdentifiers);

            // assert
            Assert.That(quote.Identifier, Is.EqualTo("SBUX"));
        }
    }
}
