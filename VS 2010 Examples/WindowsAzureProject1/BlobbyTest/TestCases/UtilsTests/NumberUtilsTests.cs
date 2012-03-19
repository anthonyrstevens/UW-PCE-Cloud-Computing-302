using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Utils;
using NUnit.Framework;

namespace BlobbyTest.TestCases.UtilsTests
{
    [TestFixture]
    public class NumberUtilsTests
    {
        [Test]
        public void GetPositiveDecimal_returns_decimal_greater_than_zero()
        {
            // arrange
            var utils = new NumberUtils();
            
            // act
            var num = utils.GetPositiveDecimal();

            // assert
            Assert.Greater(num, 0.0M);
        }

        [Test]
        public void GetPositiveDecimal_returns_decimal_greater_than_zero_on_repeated_runs()
        {
            // arrange
            var utils = new NumberUtils();

            // act
            for (var i = 0; i < 100; i++)
            {
                var num = utils.GetPositiveDecimal();
                Console.Out.WriteLine(num);
                // assert
                Assert.Greater(num, 0.0M);
            }
            
        }
    }
}
