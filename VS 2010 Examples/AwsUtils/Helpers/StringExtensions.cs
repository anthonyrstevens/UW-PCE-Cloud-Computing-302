using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwsUtils.Helpers
{
    public static class StringExtensions
    {
        public static string Repeat(this string input, int count)
        {
            var result = "";
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
