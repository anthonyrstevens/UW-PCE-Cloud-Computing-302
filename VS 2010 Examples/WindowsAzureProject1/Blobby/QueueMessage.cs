using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blobby
{
    public class QueueMessage
    {
        public string QueueName { get; set; }
        public string Data { get; set; }
        public string Id { get; set; }
    }
}
