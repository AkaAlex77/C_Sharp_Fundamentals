using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Console.WriteLine(VowelsCount(input));
        }

        static int VowelsCount(string input)
        {
            int cout = 0;
            foreach (var character in input)
            {
                if (IsVoler(character))
                {
                    cout++;
                }
            }
            return cout;
        }

        static bool IsVoler(char character)
        {
            return "aeiouAEIOUY".IndexOf(character) >= 0;
        }
    }
}

