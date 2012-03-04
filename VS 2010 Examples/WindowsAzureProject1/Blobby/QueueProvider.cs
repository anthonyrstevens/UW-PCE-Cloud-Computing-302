using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;

namespace Blobby
{
    public class QueueProvider : ProviderBase
    {
        public void CreateQueue(string queueName)
        {
            // Create the queue client
            CloudQueueClient queueClient = this.GetAccount().CreateCloudQueueClient();

            // Retrieve a reference to a queue
            CloudQueue queue = queueClient.GetQueueReference(queueName);
            queue.CreateIfNotExist();
        }

        public void Push(string queueName, string data)
        {
            // Create the queue client
            CloudQueueClient queueClient = this.GetAccount().CreateCloudQueueClient();

            // Retrieve a reference to a queue
            CloudQueue queue = queueClient.GetQueueReference(queueName);
            var message = new CloudQueueMessage(data);
            queue.AddMessage(message);
        }

        public QueueMessage Pop(string queueName)
        {
            // assume we want to delete as well?
            throw new NotImplementedException();
        }

        public void Delete(QueueMessage message)
        {
            // deletes the queue message with id 'messageIdentifier'
        }

    }
}
