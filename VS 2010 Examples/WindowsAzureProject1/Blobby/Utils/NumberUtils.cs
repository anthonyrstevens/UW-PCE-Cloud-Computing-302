using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Utils
{
    public class NumberUtils
    {
        private System.Random _rand = null;

        public virtual decimal GetPositiveDecimal(decimal upperBound = 500.0M)
        {
            var num = this.Rand.NextDouble();
            // scale it
            var scaled = (decimal)num * upperBound;
            return scaled;
        }

        #region Protected Properties

        protected internal virtual System.Random Rand
        {
            get { return _rand ?? (_rand = new System.Random()); }
        }
        
        #endregion

    }
}
