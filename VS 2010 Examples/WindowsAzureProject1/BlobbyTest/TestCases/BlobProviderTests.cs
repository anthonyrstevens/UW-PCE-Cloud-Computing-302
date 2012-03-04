using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blobby;
using NUnit.Framework;

namespace BlobbyTest.TestCases
{
    [TestFixture]
    public class BlobProviderTests
    {
        [Test]
        public void ListContainers_returns_correct_results()
        {
            var provider = new BlobProvider();
            var list = provider.GetAllContainers();

            var interestingList = list.Where(x=>x.Name != "vsdeploy" && x.Name != "wad-control-container");
            var count = interestingList.Count();
            Assert.That(count, Is.EqualTo(0));

        }

        [Test]
        public void ListContainers_returns_something()
        {
            var provider = new BlobProvider();
            var list = provider.GetAllContainers();

            var somethingContainer = list.FirstOrDefault(x => x.Name == "something");
            Assert.IsNotNull(somethingContainer);
        }

        [Test]
        public void ListBlobs_returns_correct_results()
        {
            var containerName = "something/";

            var provider = new BlobProvider();
            var list = provider.GetAllBlobs(containerName);

            var count = list.Count();
            Assert.That(count, Is.EqualTo(0));

        }

        [Test]
        public void CreateBlob_works_successfully()
        {
            var containerName = Guid.NewGuid().ToString().Replace("-", "");
            var blobName = "Anthony";

            var provider = new BlobProvider();
            provider.CreateContainer(containerName);

            var data = "Ticky-tack foul!";

            provider.CreateBlob(containerName, blobName, data);

        }

        [Test]
        public void GetBlob_returns_correct_data()
        {
            var containerName = "a697fc6853c44801b6e909ca74c91984";
            var blobName = "Anthony";
            var provider = new BlobProvider();
            var blob = provider.GetBlob(containerName, blobName);
            var actualData = blob.Data;
            var expected = "Ticky-tack foul!";
            Assert.That(actualData, Is.EqualTo(expected));
        }

    }
}
