using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure;

namespace Blobby
{
    public class ProviderBase
    {
        public virtual CloudStorageAccount GetAccount()
        {
            var cred = new Microsoft.WindowsAzure.StorageCredentialsAccountAndKey("cloud302blobby",
                                                                                  "PDyi8E91Txm+NqS7yUByQkQ933Tfp6/tbgvVG0Z4zvrIrgnG0P5J3bf9hMm7EZ9Ll6R2ol70UjjHU3rI9EO8uA==");
            var account = new Microsoft.WindowsAzure.CloudStorageAccount(cred, true);
            return account;
        }
    }
}
