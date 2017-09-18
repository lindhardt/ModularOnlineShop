using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModularOnlineShop.Models;

namespace ModularOnlineShop.Controllers
{
    public class ProductsController : Controller
    {
		private Product context;
        // GET: Products
        public ActionResult Index()
        {
			Product product = new Product();
            return View();
        }
		public ProductsController() {
			context = new Product();
		}

    }
}