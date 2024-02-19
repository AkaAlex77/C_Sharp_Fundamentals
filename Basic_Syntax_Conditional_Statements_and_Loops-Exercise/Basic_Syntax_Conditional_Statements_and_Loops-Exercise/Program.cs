using System;

namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int.TryParse(input, out int age);
            //int age = int.Parse(Console.ReadLine());

            if (age >=0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 60)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
