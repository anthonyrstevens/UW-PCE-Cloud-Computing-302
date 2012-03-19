using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Utils;

namespace Blobby.Tickers
{
    public class QuoteFactory
    {
        private TickerFactory _tickerFactory = new TickerFactory();
        private DateUtils _dateUtils = new DateUtils();
        private System.Random _rand = null;

        public virtual List<Quote> CreateListOfRandomQuotes(Identifiers allowedIdentifiers, int count)
        {
            var list = new List<Quote>();
            for (var i = 0; i < count; i++)
            {
                var quote = this.CreateRandomQuote(allowedIdentifiers);
                list.Add(quote);
            }
            return list;
        }

        public virtual List<Quote> CreateListOfRandomQuotes(int count)
        {
            var list = new List<Quote>();
            for (var i = 0; i < count; i++)
            {
                var quote = this.CreateRandomQuote();
                list.Add(quote);
            }
            return list;
        }

        public virtual Quote CreateRandomQuote(Identifiers allowedIdentifiers)
        {
            var count = allowedIdentifiers.Count;
            var rand = this.Rand.Next(0, count);
            var chosenIdentifier = allowedIdentifiers[rand];

            var ticker = this.TickerFactory.CreateRandomTicker();
            var quoteDate = this.DateUtils.GetRandomDate();
            var quote = new Quote
            {
                Identifier = chosenIdentifier,
                Price = ticker.Price,
                QuoteDate = quoteDate,
            };
            return quote;
        }

        public virtual Quote CreateRandomQuote()
        {
            var ticker = this.TickerFactory.CreateRandomTicker();
            var quoteDate = this.DateUtils.GetRandomDate();
            var quote = new Quote
                            {
                                Identifier = ticker.Identifier,
                                Price = ticker.Price,
                                QuoteDate = quoteDate,
                            };
            return quote;
        }

        #region Protected Properties

        protected internal virtual System.Random Rand
        {
            get { return _rand ?? (_rand = new System.Random()); }
        }

        protected internal virtual TickerFactory TickerFactory
        {
            get { return _tickerFactory ?? (_tickerFactory = new TickerFactory()); }
        }

        protected internal virtual DateUtils DateUtils
        {
            get { return _dateUtils ?? (_dateUtils = new DateUtils()); }
        }
        
        #endregion

    }
}
