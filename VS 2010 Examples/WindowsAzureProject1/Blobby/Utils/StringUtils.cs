using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Utils
{
    public class StringUtils
    {
        private System.Random _rand = null;

        public const int UPPERCASE_A = 65;
        public const int UPPERCASE_Z = 90;
        public const int LOWERCASE_A = 97;
        public const int LOWERCASE_Z = 122;

        public virtual string GenerateRandomString(int asciiLowerBound, int asciiUpperBound, int length)
        {
            var result = "";
            for (int i = 0; i < length; i++)
            {
                var chr = this.Rand.Next(asciiLowerBound, (asciiUpperBound + 1));
                result += System.Convert.ToChar(chr);
            }
            return result;
        }

        public virtual string GenerateRandomAlpha(int length)
        {
            if (length < 0)
            {
                throw new Exception("length param must be a positive integer");
            }
            var returnValue = String.Empty;
            for (var i = 0; i < length; i++)
            {
                var chr = this.GetRandomAlphaChar();
                returnValue += chr;
            }
            return returnValue;

        }

        public virtual char GetRandomAlphaChar(bool uppercaseOk = true)
        {
            var asciiIndex = this.GetRandomAsciiIndex(uppercaseOk);
            var chr = System.Convert.ToChar(asciiIndex);
            return chr;
        }

        public virtual int GetRandomAsciiIndex(bool uppercaseOk = true)
        {
            const int lowerBound = 0;
            var upperBound = uppercaseOk ? 52 : 26;
            var randomIndex = this.Rand.Next(lowerBound, upperBound);
            var asciiIndex = (randomIndex <= 25) ? (randomIndex + LOWERCASE_A) : (randomIndex - 26 + UPPERCASE_A);
            return asciiIndex;
        }

        #region Protected Properties

        protected internal virtual System.Random Rand
        {
            get { return _rand ?? (_rand = new System.Random()); }
        }

        #endregion


    }
}
