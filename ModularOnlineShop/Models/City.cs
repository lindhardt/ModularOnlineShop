using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class City {

		public int ZipCode { get; set; }
        [Display(Name = "By navn")]
        public string CityName { get; set; }
	}
}