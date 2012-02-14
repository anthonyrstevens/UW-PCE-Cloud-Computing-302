using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwsUtils;
using AwsUtils.Helpers;
using AwsUtils.SimpleDb;

namespace InputWeb.Controllers
{
    public class DaffodilController : Controller
    {
        //
        // GET: /Daffodil/

        public ActionResult Index()
        {
            var config = this.AwsConfig;
            var provider = new SimpleDbProvider(config);
            var model = provider.ReadDaffodils();
            return View(model);
        }

        protected internal virtual AwsConfig AwsConfig
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
