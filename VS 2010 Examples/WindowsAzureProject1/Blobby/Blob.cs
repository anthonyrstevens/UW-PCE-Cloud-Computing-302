using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby
{
    public class Blob
    {
        // this is a comment
        public string Container { get; set; }
        public string Uri { get; set; }
        public string Data { get; set; }

        public virtual IEnumerable<string> GetAllLines()
        {
            var lines = this.Data.Split(new string[1] {System.Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
    }
}
