using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Tickers.Questions.AverageStockPrice;
using NUnit.Framework;

namespace BlobbyTest.TestCases.TickersTests.TestSetupTests.AverageStockPriceTests
{
    [TestFixture]
    public class AverageDataTests
    {
        [Test]
        public void Merge_returns_expected_value_0_0()
        {
            // arrange
            var data = new AverageData();
            var other = new AverageData();
            
            // act
            data.Merge(other);

            // assert
            Assert.IsNull(data.CalculatedAverage);
            Assert.That(data.DataPoints, Is.EqualTo(0));
        }

        [Test]
        public void Merge_returns_expected_value_3_0()
        {
            // arrange
            var data = new AverageData {CalculatedAverage = 9.9M, DataPoints = 3};
            var other = new AverageData();

            // act
            data.Merge(other);

            // assert
            Assert.That(data.CalculatedAverage, Is.EqualTo(9.9M));
            Assert.That(data.DataPoints, Is.EqualTo(3));
        }

        [Test]
        public void Merge_returns_expected_value_3_1()
        {
            // arrange
            var data = new AverageData { CalculatedAverage = 9.9M, DataPoints = 3 };
            var other = new AverageData {CalculatedAverage = 100.0M, DataPoints = 1};

            var expectedAverage = ((9.9M*3.0M) + (100.0M*1.0M))/4.0M;

            // act
            data.Merge(other);

            // assert
            Assert.That(data.CalculatedAverage, Is.EqualTo(expectedAverage));
            Assert.That(data.DataPoints, Is.EqualTo(4));
        }
    }
}
