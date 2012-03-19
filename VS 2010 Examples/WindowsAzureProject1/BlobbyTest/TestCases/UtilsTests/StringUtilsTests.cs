using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Utils;
using NUnit.Framework;

namespace BlobbyTest.TestCases.UtilsTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void GenerateRandomAlpha_returns_empty_string_for_zero_length()
        {
            // arrange
            var utils = new StringUtils();
            string expected = String.Empty;
            
            // act
            var actual = utils.GenerateRandomAlpha(0);
            
            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateRandomAlpha_throws_for_negative_number()
        {
            // arrange
            var utils = new StringUtils();
            
            // act & assert
            Assert.Throws<Exception>(()=>utils.GenerateRandomAlpha(-1));
        }

        [Test]
        public void GenerateRandomAlpha_returns_string_of_correct_length()
        {
            // arrange
            var utils = new StringUtils();
            var expected = 8;

            // act
            var actual = utils.GenerateRandomAlpha(8);

            // assert
            Assert.That(actual.Length, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateRandomAlpha_returns_string_with_only_ascii_characters()
        {
            // arrange
            var utils = new StringUtils();
            
            // act
            var actual = utils.GenerateRandomAlpha(8);

            // assert
            var regex = new Blobby.Utils.Regex();
            var isAscii = regex.IsAscii(actual);
            Assert.True(isAscii);
        }

        [Test]
        public void GenerateRandomString_returns_single_character_for_single_input()
        {
            var utils = new StringUtils();
            var result = utils.GenerateRandomString(StringUtils.LOWERCASE_A, StringUtils.LOWERCASE_A, 1);
            Assert.That(result, Is.EqualTo("a"));
        }
    
    }
}
