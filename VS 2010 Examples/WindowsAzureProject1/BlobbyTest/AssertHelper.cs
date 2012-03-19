using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BlobbyTest
{
    public static class AssertHelper
    {
        public static void IsAscii(string input)
        {
            var regex = new Blobby.Utils.Regex();
            var isAscii = regex.IsAscii(input);
            Assert.True(isAscii);
        }

        public static void IsPositive(decimal input)
        {
            Assert.True(input > 0.0M);
        }
        
        public static void AssertHasLines(string input, int expectedLineCount)
        {
            string delimiter = System.Environment.NewLine;
            var temp = input;
            var count = 0;
            var currentIndex = temp.IndexOf(delimiter, 0);
            while (currentIndex > 0)
            {
                count++;
                currentIndex = temp.IndexOf(delimiter, (currentIndex + 1));
            }
            Assert.That(count, Is.EqualTo(expectedLineCount));
            
        }
    }
}
