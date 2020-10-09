using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registraton");
            Console.Write("Enter User First Name: ");
            string firstName = Console.ReadLine();
            FirstNameCheck(firstName);
            Console.Write("Enter User Last Name: ");
            string lastName = Console.ReadLine();
            LastNameCheck(lastName);
            Console.Write("Enter User Email ID: ");
            string emailID = Console.ReadLine();
            EmailCheck(emailID);
            Console.Write("Enter User Mobile Number: ");
            string mobile = Console.ReadLine();
            MobileNumberCheck(mobile);
            Console.Write("Enter User Password: ");
            string pass1 = Console.ReadLine();
            PasswordCheck(pass1);
        }
        public static void FirstNameCheck(string firstName)
        {
            string pattern = "^[A-Z]+[a-z A-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(firstName);
            if (match.Success)
            {
                Console.WriteLine("User First Name entered successfully.");
            }
            else
            {
                Console.WriteLine("User First Name is Invalid.");
            }
        }
        public static void LastNameCheck(string lastName)
        {
            string pattern = "^[A-Z]+[a-z A-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(lastName);
            if (match.Success)
            {
                Console.WriteLine("User Last Name entered successfully.");
            }
            else
            {
                Console.WriteLine("User Last Name is Invalid.");
            }
        }
        public static void EmailCheck(string emailID)
        {
            string pattern = "(^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$)";
            bool validate = Regex.IsMatch(emailID, pattern);
            if (validate)
            {
                Console.WriteLine("User Email entered successfully");
            }
            else
            {
                Console.WriteLine("User Email is invalid.");
            }
        }
        public static void MobileNumberCheck(string mobile)
        {
            string pattern = "^[+91]{2,3}[ -]*[0-9]{10}";
            bool validate = Regex.IsMatch(mobile, pattern);
            if (validate)
            {
                Console.WriteLine("Mobile Number entered successfully");
            }
            else
            {
                Console.WriteLine("Mobile Number is invalid. Make sure to enter country code +91 before the 10 digit number");
            }
        }
        public static void PasswordCheck(string pass1)
        {
            string pattern = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{8,}$";
            bool validate = Regex.IsMatch(pass1, pattern);
            if (validate)
            {
                Console.WriteLine("User Password entered successfully");
            }
            else
            {
                Console.WriteLine("User Password is Invalid. The password must be of atleast 8 characters and should have atleast one upper case and a numeric character.");
            }
        }
    }
}
