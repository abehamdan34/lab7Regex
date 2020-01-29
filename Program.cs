using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name!");
            string name = NameValidation(Console.ReadLine());
            Console.WriteLine(name);
            
            Console.WriteLine("Please enter a valid Email!");
            string email = EmailValidation(Console.ReadLine());
            Console.WriteLine(email);

            Console.WriteLine("Please enter a valid Phone Number");
            string phoneNumber = PhoneNumberValidation(Console.ReadLine());
            Console.WriteLine(phoneNumber);

            Console.WriteLine("Please enter a valid date! mm/dd/yyyy");
            string date = DateValidation(Console.ReadLine());
            Console.WriteLine(date);
        }
        public static string NameValidation(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z]{1,30}$"))
            {
                return "Name is valid.";
            }

            return "Name is not valid.";
        }
        public static string EmailValidation(string email)
        {
            if (Regex.IsMatch(email, @"^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})$")) 
            {
                return "Email is valid.";
            }

            return "Email is not valid.";
        }
        public static string PhoneNumberValidation(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                return "Phone number is valid.";
            }

            return "Phone number is not valid.";
        }
        public static string DateValidation(string date)
        {
            if (Regex.IsMatch(date, @"(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"))
            {
                return "Date is valid.";
            }

            return "Date is not valid.";
        }
    }
}
