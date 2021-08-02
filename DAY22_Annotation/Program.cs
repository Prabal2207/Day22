using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAY22_Annotation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistraionAnnotation obj = new UserRegistraionAnnotation();
            Console.WriteLine("Welcome to Exception Handling Implementation!");

            string FirstName, LastName, email, PhoneNumber, Password;

            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();

            obj.FirstName = FirstName;


            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            obj.LastName = LastName;


            Console.Write("Enter your email addresss: ");
            email = Console.ReadLine();
            obj.Email_Id = email;


            Console.Write("Enter your  Phone number: ");
            PhoneNumber = Console.ReadLine();
            obj.PhoneNumber = PhoneNumber;

            Console.Write("Enter your  Password: ");
            Password = Console.ReadLine();
            obj.Password = Password;


            ValidationContext context = new ValidationContext(obj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Error Msg : {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }

            Console.ReadKey();

        }
    }
}
