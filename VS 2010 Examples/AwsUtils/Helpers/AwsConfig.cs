using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwsUtils.Helpers
{
    public class AwsConfig
    {
        private string _secretKey = null;
        public string AccessKey
        { 
            get { return System.Configuration.ConfigurationManager.AppSettings["awsaccesskey"]; }
        }
        
        public string SecretKey
        {
            get
            {
                return _secretKey ?? (_secretKey = System.Configuration.ConfigurationManager.AppSettings["awssecretkey"]);
            }
            set { _secretKey = value; }
        }

        public string SqsServiceUrl
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["sqs.serviceurl"]; }
        }

        public string SdbServiceUrl
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["sdb.serviceurl"]; }
        }

        public string SesServiceUrl
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ses.serviceurl"]; }
        }

        public string SqsBaseUrl
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["sqs.baseurl"]; }
        }
    }


}
