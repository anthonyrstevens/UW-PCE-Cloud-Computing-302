using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby;
using NUnit.Framework;

namespace BlobbyTest.TestCases
{
    [TestFixture]
    public class QueueProviderTests
    {
        [Test]
        public void CreateQueue_does_the_right_thing()
        {
            var provider = new Blobby.QueueProvider();
            provider.CreateQueue("DaytonaFiveHundred");
        }

    }
}
