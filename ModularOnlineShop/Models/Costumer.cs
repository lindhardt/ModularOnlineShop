using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
	public class Costumer {
		/*public int CostumerID { get; set; }
        [Required]
        [Display(Name = "Fornavn")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Efternavn")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Gentag Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "Adresse linje 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Adresse linje 2")]
        public string AddressLine2 { get; set; }
        [Required]
        [Display(Name = "Postnummer")]
        public int ZipCode { get; set; }*/
		
	}
    public class LoginModel {
        //UserName
        [Required]
        [Display(Name = "User name")] //or email??
        public string UserName { get; set; }

        //Password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Remember Me
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //Model for registering
    public class RegisterModel {

        public int CostumerID { get; set; }

        [Required]
        [Display(Name = "Fornavn")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Efternavn")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        //Password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //Confirm Password
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Adresse linje 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Adresse linje 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [Display(Name = "Postnummer")]
        public int ZipCode { get; set; }
    }

    //This model is for resetting the password
    public class LocalPasswordModel {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}