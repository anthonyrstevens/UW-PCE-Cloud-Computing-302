using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby.Utils;

namespace Blobby.Tickers
{
    public class TickerFactory
    {
        private StringUtils _stringUtils = null;
        private NumberUtils _numberUtils = null;

        public const int MAX_IDENTIFIER_LENGTH = 4;

        public virtual Ticker CreateRandomTicker()
        {
            var ticker = new Ticker
                             {
                                 Identifier = this.CreateRandomIdentifier(),
                                 Price = this.CreateRandomPrice()
                             };

            return ticker;

        }

        #region Protected Methods

        protected internal virtual string CreateRandomIdentifier()
        {
            const int lowerBound = Utils.StringUtils.UPPERCASE_A;
            const int upperBound = Utils.StringUtils.UPPERCASE_Z;
            var identifier = this.StringUtils.GenerateRandomString(lowerBound, upperBound, MAX_IDENTIFIER_LENGTH);
            return identifier;
        }

        protected internal virtual decimal CreateRandomPrice()
        {
            var price = this.NumberUtils.GetPositiveDecimal();
            return price;
        }

        #endregion

        #region Protected Properties
        
        public virtual StringUtils StringUtils
        {
            get { return _stringUtils ?? (_stringUtils = new StringUtils()); }
        }

        public virtual NumberUtils NumberUtils
        {
            get { return _numberUtils ?? (_numberUtils = new NumberUtils()); }
        }

        #endregion

    }
}
