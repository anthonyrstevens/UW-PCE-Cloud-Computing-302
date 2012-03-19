using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers
{
    public class QuoteFile : List<Quote>
    {
        private string _lineDelimiter = System.Environment.NewLine;
        private string _quoteFormatString = "{0:yyyy-MM-dd}\t{1}\t{2:0.00}";

        public virtual string LineDelimiter
        {
            get { return _lineDelimiter; }
        }

        public virtual string QuoteFormatString
        {
            get { return _quoteFormatString; }
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var quote in this)
            {
                var line = quote.ToString(this.QuoteFormatString);
                
#if DEBUG
                Console.Out.WriteLine(line);
#endif
                sb.Append(line);
                sb.Append(this.LineDelimiter);
            }
            return sb.ToString();
        }
    }
}
