using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwsUtils;
using AwsUtils.Email;
using AwsUtils.Helpers;
using NUnit.Framework;

namespace AwsUtilsTests.TestCases.EmailTests
{
    [TestFixture]
    public class EmailProviderTests
    {
        [Test]
        public void Send_sends_without_error()
        {
            var config = this.AwsConfig;
            var provider = new EmailProvider(config);
            provider.Send("anthonys@crowdify.com", "Subject", "Body");
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
