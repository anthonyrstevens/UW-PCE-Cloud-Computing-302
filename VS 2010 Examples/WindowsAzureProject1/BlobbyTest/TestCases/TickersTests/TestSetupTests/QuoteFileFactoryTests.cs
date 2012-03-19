using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers;
using Blobby.Tickers.TestSetup;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests.TestSetupTests
{
    [TestFixture]
    public class QuoteFileFactoryTests
    {
        [Test]
        public void CreateRandomFile_creates_expected_number_of_lines()
        {
            // arrange
            var factory = new QuoteFileFactory();
            var allowedIdentifiers = new List<string> {"MSFT", "CSCO", "AMZN", "SBUX"};
            var identifiers = new Identifiers(allowedIdentifiers);
            var expectedLines = 100;

            // act
            var file = factory.CreateRandomFile(identifiers, expectedLines);

            // assert
            var fileContents = file.ToString();
            AssertHelper.AssertHasLines(fileContents, expectedLines);

        }
    }
}
