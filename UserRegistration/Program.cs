﻿using System;
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
            Console.Write("Enter User Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter User Email ID: ");
            string emailID = Console.ReadLine();
            Console.Write("Enter User Mobile Number: ");
            string mobile = Console.ReadLine();
            Console.Write("Enter User Password: ");
            string pass1 = Console.ReadLine();
            FirstNameCheck(firstName);
            LastNameCheck(lastName);
            EmailCheck(emailID);
            MobileNumberCheck(mobile);
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
        public static void EmailCheck(string emailID) /*UC9-will clear all email samples*/
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
        public static void PasswordCheck(string input)
        {
            string pattern = "(?=.*[0-9])(?=.*[!@#$%^&*?])(?=.*[A-Z]).{8,}";
            string regex = "^(?=.*[0-9A-Za-z])[0-9A-Za-z]*[$&+,:;=?@#|'<>.-^*()%!][0-9A-Za-z]*$";
            bool validate = Regex.IsMatch(input, pattern);
            bool validate1 = Regex.IsMatch(input, regex);
            if (validate && validate1)
            {
                Console.WriteLine("User Password entered successfully");
            }
            else
            {
                Console.WriteLine("User Password is Invalid. The password must be of atleast 8 characters and should have atleast one upper case, one numeric, and one special character.");
            }
        }
    }
}
