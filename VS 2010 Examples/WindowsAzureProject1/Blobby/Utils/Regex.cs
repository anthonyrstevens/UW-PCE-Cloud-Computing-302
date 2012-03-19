using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Utils
{
    public class Regex
    {
        public virtual List<string> GetMatches(string input, string pattern)
        {
            var list = new List<string>();

            const string groupName = "capture";
            var capturePattern = String.Format("(?<{0}>{1})", groupName, pattern);
            var regex = new System.Text.RegularExpressions.Regex(capturePattern);
            var matches = regex.Matches(input);
            for (var i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                var captures = match.Captures;
                for (var c = 0; c < captures.Count; c++)
                {
                    var capture = captures[c];
                    var val = capture.Value;
                    list.Add(val);
                }
            }

            return list;
        }

        public virtual bool IsMatch(string input, string pattern)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
        }

        public virtual bool IsAscii(string input, bool uppercaseOk = true)
        {
            var isMatch = false;
            if (!String.IsNullOrWhiteSpace(input))
            {
                var pattern = "a-z";
                if (uppercaseOk)
                {
                    pattern += "A-Z";
                }
                pattern = "[^" + pattern + "]";
                isMatch = !this.IsMatch(input, pattern);
            }
            return isMatch;
        }
    }
}
