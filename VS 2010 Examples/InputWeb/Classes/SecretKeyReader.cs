using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwsUtils;
using AwsUtils.Helpers;

namespace InputWeb.Classes
{
    public class SecretKeyReader
    {
        private string _secretKey = null;
        private const string appConfigKeyName = "awssecretkeyfile";

        public virtual void LoadSecretKeyFromFile()
        {
            var secretKeyFileName = System.Configuration.ConfigurationManager.AppSettings[appConfigKeyName];
            var physicalPath = HttpContext.Current.Server.MapPath(secretKeyFileName);
            _secretKey = (new FileReader()).Read(physicalPath);
        }

        public virtual string GetForDisplay()
        {
            var result = "n/a";
            var length = this.SecretKey.Length;
            if (length > 6)
            {
                var firstThree = this.SecretKey.Substring(0, 3);
                var lastThree = this.SecretKey.Substring(length - 3);
                var middle = ".".Repeat(length - 6);
                result = firstThree + middle + lastThree;
            }
            return result;
        }

        protected internal virtual string SecretKey
        {
            get { return _secretKey ?? ""; }
        }
    }
}