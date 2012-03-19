using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers.TestSetup
{
    public class QuoteFileFactory
    {
        private QuoteFactory _quoteFactory = null;

        public virtual QuoteFile CreateRandomFile(Identifiers allowedIdentifiers, int lineCount)
        {
            var quoteFile = new QuoteFile();
            var randomQuotes = this.QuoteFactory.CreateListOfRandomQuotes(allowedIdentifiers, lineCount);
            quoteFile.AddRange(randomQuotes);
            return quoteFile;
        }

        #region Protected Methods

        protected internal virtual QuoteFactory QuoteFactory
        {
            get { return _quoteFactory ?? (_quoteFactory = new QuoteFactory()); }
        }

        #endregion

    }
}
