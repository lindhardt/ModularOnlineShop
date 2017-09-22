using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class Product {
		public int ProductID { get; set; }
        [Required]
        [Range(0.00, 9999999999999999.99)]
        [Display(Name = "Pris")]
        public decimal Price { get; set; }
        [Display(Name = "Beskrivelse")]
        public string Descrption { get; set; }
        [Required]
        [Display(Name = "Produkt navn")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Lager")]
        public int Stock { get; set; }
	}
}