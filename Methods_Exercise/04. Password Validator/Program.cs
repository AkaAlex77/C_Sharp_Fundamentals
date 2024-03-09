using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!IsLengthValid(password))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyContainDigitsAndLetter(password))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ContainAtLeast2Digits(password))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (isValid)
            {
                Console.WriteLine("Password is valid.");
            }
        }

        private static bool ContainAtLeast2Digits(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }

        private static bool OnlyContainDigitsAndLetter(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        private static bool IsLengthValid(string password)
        {
            return password.Length is >= 6 and <= 10;
        }
    }
}

