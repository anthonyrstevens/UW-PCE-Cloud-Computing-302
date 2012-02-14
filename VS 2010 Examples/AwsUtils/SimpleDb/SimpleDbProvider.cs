using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SimpleDB.Model;
using AwsUtils.Entities;
using AwsUtils.Helpers;
using AwsUtils.Serialization;
using Attribute = Amazon.SimpleDB.Model.Attribute;

namespace AwsUtils.SimpleDb
{
    public class SimpleDbProvider
    {
        private Amazon.SimpleDB.AmazonSimpleDB _client = null;
        private string _serviceUrl = null;
        private string _accessKey = null;
        private string _secretKey = null;
        
        public SimpleDbProvider(AwsConfig config)
        {
            _serviceUrl = config.SdbServiceUrl;
            _accessKey = config.AccessKey;
            _secretKey = config.SecretKey;
        }

        public virtual void CreateDomainIfNecessary(string domainName)
        {
            if (!this.DoesDomainExist(domainName))
            {
                this.CreateDomain(domainName);
            }
        }

        public virtual bool DoesDomainExist(string domainName)
        {
            var exists = false;
            var client = this.GetClient();
            var request = new ListDomainsRequest();
                              
            var response = client.ListDomains(request);

            response.ListDomainsResult.DomainName.ForEach(x =>
                                                           {
                                                               if (x == domainName)
                                                               {
                                                                   exists = true;
                                                               }
                                                           });

            return exists;
        }

        public virtual void CreateDomain(string domainName)
        {
            var client = this.GetClient();
            var request = new CreateDomainRequest
                              {
                                  DomainName = domainName
                              };

            var response = client.CreateDomain(request);
            
        }
        
        protected internal virtual Amazon.SimpleDB.AmazonSimpleDB GetClient()
        {
            var config = new Amazon.SimpleDB.AmazonSimpleDBConfig
                             {
                                 ServiceURL = _serviceUrl,
                             };
            return (_client ?? (_client = Amazon.AWSClientFactory.CreateAmazonSimpleDBClient(_accessKey, _secretKey, config)));
        }

        public void Persist(Daffodil daffodil)
        {

#if DEBUG
            Assert.Fail(()=>(!String.IsNullOrWhiteSpace(_serviceUrl)), "You are a big dummy!");
#endif

            this.CreateDomainIfNecessary("daffodil");

            var client = this.GetClient();
            var attributes = new List<ReplaceableAttribute>
                                 {
                                     new ReplaceableAttribute
                                         {
                                             Name = "Id",
                                             Replace = true,
                                             Value = daffodil.Id,
                                         },
                                     new ReplaceableAttribute
                                         {
                                             Name = "Data",
                                             Replace = true,
                                             Value = daffodil.Data,
                                         }
                                 };
        
            var request = new PutAttributesRequest
                              {
                                  DomainName = "daffodil",
                                  Attribute = attributes,
                                  ItemName = daffodil.Id
                              };
            client.PutAttributes(request);
            
        }

        public virtual List<Daffodil> ReadDaffodils()
        {
            var daffodils = new List<Daffodil>();

            var client = this.GetClient();
            var request = new SelectRequest
            {
                SelectExpression = "SELECT * FROM daffodil",
            };

            var response = client.Select(request);
            var items = response.SelectResult.Item;
            foreach(var item in items)
            {
                var idFromDb = item.Attribute.First(x => x.Name == "Id").Value;
                var dataFromDb = item.Attribute.First(x => x.Name == "Data").Value;

                var daffodil = new Daffodil
                {
                    Id = idFromDb,
                    Data = dataFromDb,
                };

                daffodils.Add(daffodil);
            }
            
            return daffodils;
        }

        public virtual Daffodil Read(string domain, string id)
        {
            var client = this.GetClient();
            var request = new GetAttributesRequest
                              {
                                  ItemName = id,
                                  DomainName = domain,
                              };

            var response = client.GetAttributes(request);
            var attributes = response.GetAttributesResult.Attribute;
            var idFromDb = attributes.First(x => x.Name == "Id").Value;
            var dataFromDb = attributes.First(x => x.Name == "Data").Value;

            var daffodil = new Daffodil
                               {
                                   Id = idFromDb,
                                   Data = dataFromDb,
                               };

            return daffodil;
        }
    }
}
