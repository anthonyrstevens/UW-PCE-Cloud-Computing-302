using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AwsUtils;
using AwsUtils.Entities;
using AwsUtils.Helpers;
using AwsUtils.Queues;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AwsUtilsTests.TestCases.QueueTests
{
    [TestFixture]
    public class QueueProviderTests
    {
        [Test]
        public void CreateQueue_creates_queue_without_error()
        {
            // Arrange
            var config = this.AwsConfig;
            
            var provider = new QueueProvider(config);
            var queueName = Guid.NewGuid().ToString().Replace("-", "");
            
            // Act
            provider.CreateQueue(queueName);

            // Assert

        }

        [Test]
        public void SendMessage_sends_without_error()
        {
            var config = this.AwsConfig;
            var provider = new QueueProvider(config);
            var queueName = Guid.NewGuid().ToString().Replace("-", "");
            provider.CreateQueue(queueName);

            var daffodil = new Daffodil
                               {
                                   Id = "123456",
                                   Data = "Long John Silver Was A Beastly Pirate Who Sailed The Seven Seas"
                               };

            provider.SendMessage(queueName, daffodil);
        }

        [Test]
        public void CreateQueueIfNecessary_does_not_throw_error()
        {
            // Arrange
            var config = this.AwsConfig;
            var provider = new QueueProvider(config);
            var queueName = Guid.NewGuid().ToString().Replace("-", "");

            // Act
            provider.CreateQueueIfNecessary(queueName);

            // Assert
        }

        [Test]
        public void CalculateQueueUrl_correctly_joins_parts()
        {
            var provider = new QueueProvider(this.AwsConfig);
            var expected = "foo/bar";
            var actual = provider.CalculateQueueUrl("foo/", "bar");
            // Assert
            Assert.That(actual, Is.EqualTo(expected));


        }

        [Test]
        public void DoesQueueExist_works()
        {
            var config = this.AwsConfig;
            var provider = new QueueProvider(config);
            var exists = provider.DoesQueueExist("3557b2d8a3264b1aa855f2a11557089c");
            Assert.True(exists);
        }

        [Test]
        public void ReadMessage_reads_from_queue()
        {
            var config = this.AwsConfig;
            var provider = new QueueProvider(config);

            var data = "Alexander the Great";
            var id = "123";
            var daffodil = new Daffodil {Id = id, Data = data};

            var temp = Guid.NewGuid().ToString().Replace("-", "");

            provider.SendMessage(temp, daffodil);

            Thread.Sleep(2000);

            var newDaffodil = provider.ReadMessage(temp);
            
            Assert.That(newDaffodil.Data, Is.EqualTo(data));
            Assert.That(newDaffodil.Id, Is.EqualTo(id));
        }

        protected internal virtual AwsConfig AwsConfig
        {
            get
            { 
                var config = new AwsConfig();
                var reader = new FileReader();
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                config.SecretKey = reader.Read(assembly, @"Resources\secretkey.txt");

                return config;

            }
        }
    }
}
