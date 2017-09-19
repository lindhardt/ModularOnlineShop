using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class Order {
		public int OrderID { get; set; }
        [Required]
		public int CostumerID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }
	}
}