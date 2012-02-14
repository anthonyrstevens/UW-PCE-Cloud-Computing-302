using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SQS;
using Amazon.SQS.Model;
using AwsUtils.Entities;
using AwsUtils.Helpers;
using AwsUtils.Serialization;

namespace AwsUtils.Queues
{
    public class QueueProvider
    {
        private AmazonSQS _client = null;
        private string _serviceUrl = null;
        private string _accessKey = null;
        private string _secretKey = null;
        private string _baseUrl = null;

        public QueueProvider(AwsConfig config)
        {
            _serviceUrl = config.SqsServiceUrl;
            _accessKey = config.AccessKey;
            _secretKey = config.SecretKey;
            _baseUrl = config.SqsBaseUrl;
        }

        public virtual Daffodil ReadMessage(string queueName)
        {
            Daffodil daffodil = null;

            var client = this.GetClient();
            var request = new ReceiveMessageRequest
                              {
                                  QueueUrl = this.CalculateQueueUrl(_baseUrl, queueName),
                                  MaxNumberOfMessages = 1,
                              };

            var response = client.ReceiveMessage(request);
            if (response.IsSetReceiveMessageResult())
            {
                var messageResult = response.ReceiveMessageResult;
                if (messageResult.IsSetMessage())
                {
                    var messages = messageResult.Message;
                    if ((messages != null)
                        && (messages.Count > 0))
                    {
                        var message = messages.First();
                        if (message != null)
                        {
                            if (message.IsSetBody())
                            {
                                var body = message.Body;
                                daffodil = body.DeserializeFromJson<Daffodil>();
                            }
                        }
                    }
                }
            }

            return daffodil;
        }

        public virtual void CreateQueueIfNecessary(string queueName)
        {
            if (!this.DoesQueueExist(queueName))
            {
                this.CreateQueue(queueName);
            }
        }

        public virtual bool DoesQueueExist(string queueName)
        {
            var exists = false;
            var client = this.GetClient();
            var request = new ListQueuesRequest
                              {
                                  QueueNamePrefix = queueName
                              };
            var response = client.ListQueues(request);

            response.ListQueuesResult.QueueUrl.ForEach(x =>
                                                           {
                                                               if (x.EndsWith(queueName))
                                                               {
                                                                   exists = true;
                                                               }
                                                           });

            return exists;
        }

        public virtual void CreateQueue(string queueName)
        {
            var client = this.GetClient();
            var request = new CreateQueueRequest
                              {
                                  QueueName = queueName,
                              };

            var response = client.CreateQueue(request);
            
        }

        public virtual void SendMessage(string queueName, Daffodil daffodil)
        {

#if DEBUG
            Assert.Fail(() => (!String.IsNullOrWhiteSpace(_baseUrl)), "Hey!  Your _baseUrl is null or blank, dummy!");

#endif

            this.CreateQueueIfNecessary(queueName);

            var serializedData = daffodil.SerializeToJson<Daffodil>();

            var client = this.GetClient();
            var request = new SendMessageRequest
                              {
                                  MessageBody = serializedData,
                                  QueueUrl = this.CalculateQueueUrl(_baseUrl, queueName),
                              };

            var response = client.SendMessage(request);
        }

        protected internal virtual AmazonSQS GetClient()
        {
            var config = new AmazonSQSConfig
                             {
                                 ServiceURL = _serviceUrl,
                             };
            return (_client ?? (_client = Amazon.AWSClientFactory.CreateAmazonSQSClient(_accessKey, _secretKey, config)));
        }

        protected internal virtual string CalculateQueueUrl(string baseUrl, string queueName)
        {
            var fmt = "{0}/{1}";
            var baseUrlTrimmed = (baseUrl ?? "").TrimEnd(new char[2] {'/', ' '});
            var queueNameTrimmed = (queueName ?? "").TrimStart(new char[2] {'/', ' '});
            return String.Format(fmt, baseUrlTrimmed, queueNameTrimmed);
        }

    }
}
