using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class Order {
		public int OrderID { get; set; }
		public int CostumerID { get; set; }
		public int ProductID { get; set; }
		public decimal TotalPrice { get; set; }
	}
}