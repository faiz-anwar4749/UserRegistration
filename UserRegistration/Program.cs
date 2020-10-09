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
    }
}
