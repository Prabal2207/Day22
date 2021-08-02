using System;
using System.ComponentModel.DataAnnotations;

namespace DAY22_Annotation
{
    public  class UserRegistraionAnnotation
    {

        //UC1
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("^[A-Z][A-Za-z]{2,}$", ErrorMessage = "Invalid input minimum 1 upper case and 2 chars are required")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }



        
        //UC2
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("^[A-Z][A-Za-z]{2,}$", ErrorMessage = "Invalid Input minimum 1 upper case and 2 chars are required")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        

        //UC3
        [Required(ErrorMessage = "User {0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email_Id { get; set; }
       

        //UC4
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
       

        //UC5-8
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("((?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%]).[A-Z0-9a-z@#$%]{8,})", ErrorMessage = "Invalid input minimum 1 upper case, one special char, one nummeric value and 8 chars are required")]
        [DataType(DataType.Text)]
        public string Password { get; set; }
        
    }
}

