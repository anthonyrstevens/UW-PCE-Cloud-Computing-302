using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests
{
    [TestFixture]
    public class IdentifiersTests
    {
        [Test]
        public void Constructor_with_empty_list_sets_up_properly()
        {
            // arrange
            var input = new List<string>();

            // act
            var identifiers = new Identifiers(input);

            // assert
            Assert.That(identifiers.Count, Is.EqualTo(0));
        }

        [Test]
        public void Constructor_with_nonempty_list_sets_up_properly()
        {
            // arrange
            var input = new List<string> { "MSFT", "SBUX", "FOO", "BAR" };

            // act
            var identifiers = new Identifiers(input);

            // assert
            Assert.That(identifiers.Count, Is.EqualTo(input.Count));
        }

        [Test]
        public virtual void GetRandom_returns_null_for_empty_list()
        {
            // arrange
            var identifiers = new Identifiers();

            // act
            var result = identifiers.GetRandom();

            Assert.IsNull(result);
        }

        [Test]
        public virtual void GetRandom_returns_correct_result_for_one_item_list()
        {
            // arrange
            var identifiers = new Identifiers(new List<string> { "MSFT" });

            // act
            var result = identifiers.GetRandom();

            Assert.That(result, Is.EqualTo("MSFT"));
        }

        [Test]
        public virtual void GetRandom_returns_correct_results_for_multiple_item_list()
        {
            // arrange
            var allowed = new List<string> {"MSFT", "SBUX", "CSCO", "AMZN"};
            var identifiers = new Identifiers(allowed);

            // act
            for (var i = 0; i < 100; i++)
            {
                var result = identifiers.GetRandom();
                // assert
                Assert.That(allowed.Contains(result), Is.True);
            }
        }
    }
}
