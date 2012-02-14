using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputWeb.Classes
{
    public class SqsConfig
    {
        public virtual string ServiceUrl
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["sqs.serviceurl"]; }
        }
    }
}