using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardLink_Project.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        ////[Display(Name = "First Name")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "First Name Required.")]
        //public string FirstName { get; set; }

        ////[Display(Name = "Last Name")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "Last Name Required.")]
        //public string LastName { get; set; }

        ////[Display(Name = "Email Address")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "E-Mail Address Required.")]
        ////[DataType(DataType.EmailAddress)]
        //public string EmailId { get; set; }

        ////[Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        ////[DataType(DataType.Password)]
        ////[MinLength(8, ErrorMessage = "Minimum 8 characters required.")]
        //public string Password { get; set; }

        ////[Display(Name = "Confirm Password")]
        ////[DataType(DataType.Password)]
        ////[Compare("Password", ErrorMessage = "Passwords do not match.")]
        //public string ConfirmPassword { get; set; }

    }
}