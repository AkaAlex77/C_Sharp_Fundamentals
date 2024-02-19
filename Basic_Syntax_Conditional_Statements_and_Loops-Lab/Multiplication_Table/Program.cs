using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int t = 0;
            for (int i = s; i <= 10; i++)
            {
                if (s > 10)
                {
                    t = n * i;
                    Console.WriteLine($"{n} X {s} = {t}");
                    return;
                }
                t = n*i;
                Console.WriteLine($"{n} X {i} = {t}");
            }
     
        }
    }
}
