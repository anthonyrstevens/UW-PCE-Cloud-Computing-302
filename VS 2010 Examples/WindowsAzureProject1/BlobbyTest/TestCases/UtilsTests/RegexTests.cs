using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Utils;
using NUnit.Framework;

namespace BlobbyTest.TestCases.UtilsTests
{
    [TestFixture]
    public class RegexTests
    {
        [Test]
        public void IsMatch_returns_true_for_numeric_input()
        {
            // arrange
            var input = "123456";
            var pattern = @"\d";
            var regex = new Blobby.Utils.Regex();

            // act
            var isMatch = regex.IsMatch(input, pattern);

            // assert
            Assert.True(isMatch);
        }

        [Test]
        public void IsMatch_returns_false_when_nonnumeric_input_is_checked_for_numbers()
        {
            // arrange
            var input = "some alpha string without numbers";
            var pattern = @"\d";
            var regex = new Blobby.Utils.Regex();

            // act
            var isMatch = regex.IsMatch(input, pattern);

            // assert
            Assert.False(isMatch);
        }

        [Test]
        public void IsAscii_returns_false_for_string_with_only_numbers()
        {
            // arrange
            var input = "123456";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.False(isAscii);
        }

        [Test]
        public void IsAscii_returns_false_for_string_with_numbers_and_letters()
        {
            // arrange
            var input = "123456 and some letters";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.False(isAscii);
        }

        [Test]
        public void IsAscii_returns_false_for_empty_string()
        {
            // arrange
            var input = "";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.False(isAscii);
        }

        [Test]
        public void IsAscii_returns_false_for_null_string()
        {
            // arrange
            string input = null;
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.False(isAscii);
        }

        [Test]
        public void IsAscii_returns_false_for_whitespace_string()
        {
            // arrange
            var input = "       ";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.False(isAscii);
        }

        [Test]
        public void IsAscii_returns_true_for_lowercase_ascii_string()
        {
            // arrange
            var input = "asdfsadf";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.True(isAscii);
        }

        [Test]
        public void IsAscii_returns_true_for_uppercase_ascii_string()
        {
            // arrange
            var input = "TYRGYRGHTRFF";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.True(isAscii);
        }

        [Test]
        public void IsAscii_returns_true_for_mixed_case_ascii_string()
        {
            // arrange
            var input = "TaYeRtGeYReerfGHdTReFF";
            var regex = new Blobby.Utils.Regex();

            // act
            var isAscii = regex.IsAscii(input);

            // assert
            Assert.True(isAscii);
        }

        [Test]
        public void GetMatches_returns_empty_list_for_null_input()
        {
            // arrange
            string input = null;
            var regex = new Regex();

            // act
            var matches = regex.GetMatches(input, "some pattern");

            // assert
            Assert.That(matches.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetMatches_returns_empty_list_for_empty_input()
        {
            // arrange
            string input = String.Empty;
            var regex = new Regex();

            // act
            var matches = regex.GetMatches(input, "some pattern");

            // assert
            Assert.That(matches.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetMatches_returns_empty_list_for_no_match()
        {
            // arrange
            var input = "abcdefg";
            var pattern = "zzz";
            var regex = new Regex();

            // act
            var matches = regex.GetMatches(input, pattern);

            // assert
            Assert.That(matches.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetMatches_returns_correct_list_for_one_match()
        {
            // arrange
            var input = "abcdefg zzz asdfds";
            var pattern = "zzz";
            var regex = new Regex();

            // act
            var matches = regex.GetMatches(input, pattern);

            // assert
            Assert.That(matches.Count, Is.EqualTo(1));
            Assert.That(matches.First(), Is.EqualTo("zzz"));
        }

        [Test]
        public void GetMatches_returns_correct_list_for_two_matches()
        {
            // arrange
            var input = "abcdefg zzz asdfds zzz werewr";
            var pattern = "zzz";
            var regex = new Regex();

            // act
            var matches = regex.GetMatches(input, pattern);

            // assert
            Assert.That(matches.Count, Is.EqualTo(2));
            Assert.That(matches.First(), Is.EqualTo("zzz"));
        }
    }
}
