using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwsUtils.Helpers;

namespace AwsUtils.Email
{
    public class EmailProvider
    {
        private Amazon.SimpleEmail.AmazonSimpleEmailService _client = null;
        private string _accessKey = null;
        private string _secretKey = null;
        private string _serviceUrl = null;

        public EmailProvider(AwsConfig config)
        {
            _accessKey = config.AccessKey;
            _secretKey = config.SecretKey;
            _serviceUrl = config.SesServiceUrl;
        }

        public virtual void Send(string to, string subject, string body)
        {
            var client = this.GetClient();
            throw new NotImplementedException();
        }

        protected internal virtual Amazon.SimpleEmail.AmazonSimpleEmailService GetClient()
        {
            var config = new Amazon.SimpleEmail.AmazonSimpleEmailServiceConfig
            {
                ServiceURL = _serviceUrl,
                
            };
            return (_client ?? (_client = Amazon.AWSClientFactory.CreateAmazonSimpleEmailServiceClient(_accessKey, _secretKey, config)));
        }
    }
}
