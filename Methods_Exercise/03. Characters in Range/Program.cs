using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());

            if (character1 > character2)
            {
                char temp = character1;
                character1 = character2;
                character2 = temp;
            }

            for (int i = character1+1; i < character2; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}

