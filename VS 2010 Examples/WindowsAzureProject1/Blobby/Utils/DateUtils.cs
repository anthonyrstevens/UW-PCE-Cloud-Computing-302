using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby.Utils
{
    public class DateUtils
    {
        private System.Random _rand = null;

        public virtual DateTime GetRandomDate()
        {
            var lowerBound = new DateTime(1970, 1, 1, 0, 0, 0);
            var upperBound = DateTime.Now;
            return this.GetRandomDate(lowerBound, upperBound);
        }

        public virtual DateTime GetRandomDate(DateTime lowerBound, DateTime upperBound)
        {
            // TODO: add a check for upperbound > lowerbound
            var timeSpan = upperBound - lowerBound;
            var totalSeconds = timeSpan.TotalSeconds;
            var multiplier = this.Rand.NextDouble();
            var scaledSeconds = multiplier*totalSeconds;
            var newDate = lowerBound.AddSeconds(scaledSeconds);
            return newDate;
        }

        #region Protected Properties
        
        protected internal virtual System.Random Rand
        {
            get { return _rand ?? (_rand = new System.Random()); }
        }
        
        #endregion

    }
}
