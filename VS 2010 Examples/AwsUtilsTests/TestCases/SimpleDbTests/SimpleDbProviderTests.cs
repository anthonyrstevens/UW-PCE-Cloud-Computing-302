using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwsUtils;
using AwsUtils.Entities;
using AwsUtils.Helpers;
using AwsUtils.SimpleDb;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AwsUtilsTests.TestCases.SimpleDbTests
{
    [TestFixture]
    public class SimpleDbProviderTests
    {
        [Test]
        public void Persist_persists_without_error()
        {
            var config = this.AwsConfig;
            var provider = new SimpleDbProvider(config);
            var daffodil = new Daffodil {Id = "foo2", Data = "bar2"};
            provider.Persist(daffodil);

        }

        [Test]
        public void Read_successfully_reads()
        {
            // Arrange
            var config = this.AwsConfig;
            var provider = new SimpleDbProvider(config);
            var daffodil = new Daffodil { Id = "foo", Data = "bar" };
            provider.Persist(daffodil);

            // Act
            var daffodilFromDb = provider.Read("daffodil", "foo");

            // Assert
            Assert.That(daffodilFromDb.Data, Is.EqualTo("bar"));

        }

        [Test]
        public void ReadDaffodils_successfully_reads()
        {
            // Arrange
            var config = this.AwsConfig;
            var provider = new SimpleDbProvider(config);
            var daffodil = new Daffodil { Id = "foo", Data = "bar" };
            provider.Persist(daffodil);

            // Act
            var daffodilsFromDb = provider.ReadDaffodils();

            // Assert
            Assert.That(daffodilsFromDb.Count, Is.GreaterThanOrEqualTo(1));

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
