using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.StorageClient;

namespace Blobby
{
    public class BlobProvider : ProviderBase
    {
        public List<Container> GetAllContainers()
        {
            var list = new List<Container>();

            var blobClient = this.GetAccount().CreateCloudBlobClient();
            var containers = blobClient.ListContainers();
            foreach (var c in containers)
            {
                var container = new Blobby.Container
                                    {
                                        Name = c.Name,
                                        Uri = c.Uri.ToString()
                                    };

                list.Add(container);
            }

            return list;

        }

        public List<Blob> GetAllBlobs(string containerName)
        {
            var list = new List<Blob>();

            var blobClient = this.GetAccount().CreateCloudBlobClient();

            var blobs = blobClient.ListBlobsWithPrefix(containerName);
            foreach (var b in blobs)
            {
                var blob = new Blobby.Blob
                {
                    Container = b.Container.Name,
                    Uri = b.Uri.ToString()
                };

                list.Add(blob);
            }

            return list;

        }

        public CloudBlobContainer CreateContainer(string containerName)
        {
            var blobClient = this.GetAccount().CreateCloudBlobClient();
            var containerRef = blobClient.GetContainerReference(containerName);
            containerRef.CreateIfNotExist();
            return containerRef;
        }

        public void CreateBlob(string containerName, string blobName, string data)
        {
            var containerRef = this.CreateContainer(containerName);
            var blob = containerRef.GetBlobReference(blobName);
            blob.UploadText(data);
        }

        public Blob GetBlob(string containerName, string blobName)
        {
            var containerRef = this.CreateContainer(containerName);
            var blob = containerRef.GetBlobReference(blobName);
            var data = blob.DownloadText();

            var myBlob = new Blobby.Blob
                             {
                                 Container = containerName,
                                 Data = data,
                                 Uri = blob.Uri.ToString(),
                             };

            return myBlob;

        }
    }
}
