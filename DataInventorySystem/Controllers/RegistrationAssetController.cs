using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataInventorySystem.Controllers
{
    public class RegistrationAssetController : Controller
    {
        //inputdb
        // GET: RegistrationAsset
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Registered()
        {
            return View();
        }
    }
}