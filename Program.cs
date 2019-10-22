using System;
using System.Text.RegularExpressions;

namespace RegExpressLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ValidName("Jimjimjimjimjimjimjimjimjimjim"));
            //Console.WriteLine(ValidName("jim"));
            Console.WriteLine(VaildEmail("skoretoff@chardonnayescrow.com"));
            //Console.WriteLine(PhoneNumber("734-250-0358"));
            //Console.WriteLine(PhoneNumber("1234567"));
            //Console.WriteLine(MonthYear("08/10/1988"));
            //Console.WriteLine(MonthYear("1234567"));
        }

        public static string ValidName (string name)
        {
            if(Regex.IsMatch(name, @"^[A-Z][A-Za-z]{0,29}$"))
            {
                return "Correct!";
            }
            return "Wrong!";
        }

        public static string PhoneNumber(string digits)
        {
            if (Regex.IsMatch(digits, @"\d{3}-\d{3}-\d{4}|\d{9}"))
            {
                return "Yay you did it!";
            }
            return "Oh, that didn't work.";
        }

        public static string MonthYear(string date)
        {
            if(Regex.IsMatch(date, @"^(0?[1-9]|1[0-2])[\/](0?[1-9]|[12]\d|3[01])[\/](19|20)\d{2}$"))
            {
                return "cool!";
            }
            else
            {
                return "You Suck";
            }
        }
        public static string VaildEmail (string email)
        {
            if (Regex.IsMatch(email, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"))
            {
                return "valid";
            }
            return "invalid";
        }
    }
}
