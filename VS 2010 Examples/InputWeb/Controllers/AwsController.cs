using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InputWeb.Classes;

namespace InputWeb.Controllers
{
    public class AwsController : Controller
    {
        public ActionResult SecretKey()
        {
            var secretKeyReader = new SecretKeyReader();
            secretKeyReader.LoadSecretKeyFromFile();
            string forDisplay = secretKeyReader.GetForDisplay();
            return View(model: forDisplay);
        }
    }
}
