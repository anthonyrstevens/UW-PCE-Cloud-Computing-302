using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwsUtils;
using AwsUtils.Helpers;
using AwsUtils.Queues;
using AwsUtils.SimpleDb;

namespace DaffodilReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = AwsConfig;
            var provider = new QueueProvider(config);
            var daffodil = provider.ReadMessage("daffodils");
            // persist to SimpleDB

            var simpleDbProvider = new SimpleDbProvider(config);
            simpleDbProvider.Persist(daffodil);

        }

        static AwsConfig AwsConfig
        {
            get
            {
                var config = new AwsConfig();
                var reader = new FileReader();
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                config.SecretKey = reader.Read(assembly, @"secretkey.txt");
                return config;
            }
        }
    }
}
