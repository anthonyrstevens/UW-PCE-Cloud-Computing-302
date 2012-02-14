using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwsUtils;
using AwsUtils.Entities;
using AwsUtils.Helpers;
using AwsUtils.Queues;
using AwsUtils.Serialization;

namespace InputWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Data(string id, string data)
        {
            var config = this.AwsConfig;

            var queueProvider = new QueueProvider(config);
            var daffodil = new Daffodil
                               {
                                   Id = id,
                                   Data = data,
                               };

            queueProvider.SendMessage("daffodils", daffodil);
            return Content("success");
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
