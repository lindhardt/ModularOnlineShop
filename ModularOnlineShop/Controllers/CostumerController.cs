using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModularOnlineShop.Controllers
{
    public class CostumerController : Controller
    {
        // GET: Costumer
        public ActionResult Index()
        {
            return View();
        }
    }
    
}