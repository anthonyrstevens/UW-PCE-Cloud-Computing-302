using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Tickers
{
    public class Identifiers : List<string>
    {
        private System.Random _rand = null;

        #region Constructors

        public Identifiers() : this(new List<string>())
        {

        }

        public Identifiers(IEnumerable<string> values)
        {
            this.AddRange(values);
        }

        #endregion

        public virtual string GetRandom()
        {
            string result = null;
            var count = this.Count;
            if (count > 0)
            {
                var index = this.Rand.Next(0, count);
                result = this[index];
            }
            return result;
        }

        #region Protected Properties

        protected internal virtual System.Random Rand
        {
            get { return _rand ?? (_rand = new System.Random()); }
        }

        #endregion

    }
}
