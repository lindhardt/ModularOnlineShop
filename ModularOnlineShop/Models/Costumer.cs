using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class Costumer {
		public int CostumerID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public int ZipCode { get; set; }
		
	}
}