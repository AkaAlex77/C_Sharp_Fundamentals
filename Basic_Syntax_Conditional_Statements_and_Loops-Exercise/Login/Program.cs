using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string expPassword = new string(username.Reverse().ToArray());

            int loginAttemots = 0;

            while (true)
            {
                string providedPassword = Console.ReadLine();
                if (providedPassword == expPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    loginAttemots++;
                    Console.WriteLine("Incorrect password. Try again.");
                }
                if (loginAttemots == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

            }
        }
    }
}
