using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class Product {
		public string ProductID { get; set; }
		public decimal Price { get; set; }
		public string Descrption { get; set; }
		public string Name { get; set; }
		public bool Stock { get; set; }
	}
}